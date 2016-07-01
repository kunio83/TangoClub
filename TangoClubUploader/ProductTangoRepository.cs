﻿using Bukimedia.PrestaSharp.Entities;
using Bukimedia.PrestaSharp.Factories;
using Bukimedia.PrestaSharp;
//using Bukimedia.PrestaSharp.Entities.AuxEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangoClubUploader.Modelo;
using System.Security.Cryptography;
using System.IO;
using TangoCommon;

namespace TangoClubUploader
{
    public class ProductTangoRepository
    {
        public TangoClubCatalogoEntities _context = new TangoClubCatalogoEntities();
        public ProductFactory _productFactory;
        public ProductFeatureFactory _pFeatureFactory;
        public ProductFeatureValueFactory _pFValueFactory;
        public ProductDownloadFactory _productDownloadFactory;
        public List<TangoClub> _cancionesAAgregar;

        public int totalEnTienda { get; set; }
        public int totalLocal { get; set; }
        public int totalASubir { get; set; }

        public ProductTangoRepository(String BaseUrl, String Account, String Password)
        {
            TangoClubCatalogoEntities context = new TangoClubCatalogoEntities();
            _productFactory = new ProductFactory(BaseUrl, Account, Password);
            _pFeatureFactory = new ProductFeatureFactory(BaseUrl, Account, Password);
            _pFValueFactory = new ProductFeatureValueFactory(BaseUrl, Account, Password);
            _productDownloadFactory = new ProductDownloadFactory(BaseUrl, Account, Password);

        }

        public void RefreshInfoCarga()
        {
            //Cargar datos de subida
            _cancionesAAgregar = getCancionesAAgregar();
            totalEnTienda = this._productFactory.GetIds().Count - 1; //resto el Producto Base
            totalLocal = this._context.TangoClub.Count();
            totalASubir = this._cancionesAAgregar.Count;
        }

        public int CargarCancionProducto(TangoClub cancion,String newFileName)
        {
            int result = 0;
            try
            {
                if (File.Exists(cancion.Path))
                {
                    //Genero y Cargo y Obtengo el product
                    int idProductoBase = Convert.ToInt32(Properties.Settings.Default.IdProductoBase);
                    product productBase = this._productFactory.Get(25);
                    List<product_feature_value> lstFeatureValues = GetTangoProductFeatureValues(cancion);
                    productBase = CargarTangoProductFeaturesAProducto(lstFeatureValues, productBase);
                    productBase.active = 1;
                    productBase.id = 0;
                    productBase.price = Convert.ToDecimal(Properties.Settings.Default.Precio);
                    productBase.cache_has_attachments = 1;
                    productBase.associations.product_bundle = null;
                    //productBase.id_default_image = 1;
                    productBase.associations.images = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.image>() { new Bukimedia.PrestaSharp.Entities.AuxEntities.image() { id = 1 } };
                    productBase.name = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                    {
                        new Bukimedia.PrestaSharp.Entities.AuxEntities.language() {id = 1,Value = cancion.Tema },
                        new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { id = 2,Value = cancion.Tema }

                    };
                    //Pongo descripcion corta y larga iguales
                    productBase.description = productBase.description_short = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                    {
                        new Bukimedia.PrestaSharp.Entities.AuxEntities.language
                        {
                            id = 1, Value = this.GetDescription(cancion)
                        },
                        new Bukimedia.PrestaSharp.Entities.AuxEntities.language
                        {
                            id = 2, Value = this.GetDescription(cancion)
                        }
                    };

                    productBase = this._productFactory.Add(productBase);

                    //Genero el registro en tabla de download
                    product_download pDownload = new product_download()
                    {
                        active = 1,
                        date_add = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                        date_expiration = "2999-01-01",
                        display_filename = Path.GetFileName(cancion.Path),
                        filename = newFileName,
                        id_product = productBase.id,
                        id = 0,
                        is_shareable = 0,
                        nb_days_accessible = Convert.ToInt32(Properties.Settings.Default.DiasDisponible),
                        nb_downloadable = Convert.ToInt32(Properties.Settings.Default.CantidadDescargas)


                    };
                    pDownload = this._productDownloadFactory.Add(pDownload);

                    result = (Int32)productBase.id;
                }
                else
                    result = 0;
            }
            catch (Exception ex)
            {
                result = 0;
                throw new Exception(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Guarda una lista de features_value y la devuelve con sus id, lista para asignarla al producto
        /// </summary>
        /// <param name="cancion">la cancion sacada de la base de datos antigua</param>
        /// <returns></returns>
        private List<product_feature_value> GetTangoProductFeatureValues(TangoClub cancion)
        {
            List<product_feature_value> result = new List<product_feature_value>();
            //Album
            if (cancion.Album != String.Empty)
            {
                product_feature_value pFValueAlbum = new product_feature_value();
                pFValueAlbum.id_feature = 8;
                pFValueAlbum.custom = 1;
                pFValueAlbum.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Album, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Album, id = 2}
                };
                result.Add(pFValueAlbum);
            }
            //Autor
            if (cancion.Autor != String.Empty)
            {
                product_feature_value pFValueAutor = new product_feature_value();
                pFValueAutor.id_feature = 9;
                pFValueAutor.custom = 1;
                pFValueAutor.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Autor, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Autor, id = 2}
                };
                result.Add(pFValueAutor);
            }
            //codigoAlbum
            if (cancion.CodigoAlbum != String.Empty)
            {
                product_feature_value pFValueCodAlbum = new product_feature_value();
                pFValueCodAlbum.id_feature = 10;
                pFValueCodAlbum.custom = 1;
                pFValueCodAlbum.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.CodigoAlbum, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.CodigoAlbum, id = 2}
                };
                result.Add(pFValueCodAlbum);
            }
            //Compositor
            if (cancion.Compositor != String.Empty)
            {
                product_feature_value pFValueCompositor = new product_feature_value();
                pFValueCompositor.id_feature = 11;
                pFValueCompositor.custom = 1;
                pFValueCompositor.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Compositor, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Compositor, id = 2}
                };
                result.Add(pFValueCompositor);
            }
            //Fecha
            if (cancion.Fecha != String.Empty)
            {
                product_feature_value pFValueFecha = new product_feature_value();
                pFValueFecha.id_feature = 12;
                pFValueFecha.custom = 1;
                pFValueFecha.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Fecha, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Fecha, id = 2}
                };
                result.Add(pFValueFecha);
            }
            //Genero
            if (cancion.Genero != String.Empty)
            {
                product_feature_value pFValueGenero = new product_feature_value();
                pFValueGenero.id_feature = 13;
                pFValueGenero.custom = 1;
                pFValueGenero.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Genero, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Genero, id = 2}
                };
                result.Add(pFValueGenero);
            }
            //Interprete
            if (cancion.Interprete != String.Empty)
            {
                product_feature_value pFValueInterprete = new product_feature_value();
                pFValueInterprete.id_feature = 14;
                pFValueInterprete.custom = 1;
                pFValueInterprete.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Interprete, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Interprete, id = 2}
                };
                result.Add(pFValueInterprete);
            }
            //Orquesta
            if (cancion.Orquesta != String.Empty)
            {
                product_feature_value pFValueOrquesta = new product_feature_value();
                pFValueOrquesta.id_feature = 15;
                pFValueOrquesta.custom = 1;
                pFValueOrquesta.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Orquesta, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Orquesta, id = 2}
                };
                result.Add(pFValueOrquesta);
            }
            //Sello
            if (cancion.Sello != String.Empty)
            {
                product_feature_value pFValueSello = new product_feature_value();
                pFValueSello.id_feature = 16;
                pFValueSello.custom = 1;
                pFValueSello.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Sello, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Sello, id = 2}
                };
                result.Add(pFValueSello);
            }
            //Track
            product_feature_value pFValueTrack = new product_feature_value();
            pFValueTrack.id_feature = 17;
            pFValueTrack.custom = 1;
            pFValueTrack.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Track.ToString(), id = 1},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Track.ToString(), id = 2}
            };
            result.Add(pFValueTrack);
            //Vocalista
            if (cancion.Vocalista != String.Empty)
            {
                product_feature_value pFValueVocalista = new product_feature_value();
                pFValueVocalista.id_feature = 18;
                pFValueVocalista.custom = 1;
                pFValueVocalista.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Vocalista, id = 1},
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Vocalista, id = 2}
                };
                result.Add(pFValueVocalista);
            }

            //return result;
           return this._pFValueFactory.AddList(result);
        }

        private product CargarTangoProductFeaturesAProducto(List<product_feature_value> lstFeaturesValues,product producto)
        {
            producto.associations.product_features = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.product_feature>();
            foreach (var f in lstFeaturesValues)
            {
                producto.associations.product_features.Add(new Bukimedia.PrestaSharp.Entities.AuxEntities.product_feature { id_feature_value = (long)f.id,id = (long)f.id_feature });
            }
            return producto;
        }

        public string GetNewFileName()
        {
            DateTime now = DateTime.Now;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = now - origin;
            string str = diff.TotalSeconds.ToString();

            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private string GetDescription(TangoClub cancion)
        {
            return String.Format("Interprete {0} - Album: {1} - Track: {2} - Tema: {3}", cancion.Interprete, cancion.Album, cancion.Track, cancion.Tema);
        }

        private List<TangoClub> getCancionesAAgregar()
        {
            List<TangoClub> lstCanciones = this._context.TangoClub.ToList();
            List<product> lstProductos = this._productFactory.GetAll();

            String shortDesc = String.Empty;
            List<TangoClub> lstProductosAAgregar = new List<TangoClub>();
            foreach (TangoClub c in lstCanciones)
            {
                shortDesc = this.GetDescription(c);

                if (lstProductos.Where(z => z.name[0].Value == c.Tema &&
                    z.description_short[0].Value == shortDesc).Count() == 0)
                {
                    lstProductosAAgregar.Add(c);
                }
            }
            return lstProductosAAgregar;
        }

        private bool CargarArchivoAFtp(string newName, string path)
        {
            ftp ftpRepo = new ftp("ftp://fs000512.ferozo.com/", "uploadmp3@prestashoptesting.com", "Batc2016");
            ftpRepo.upload(newName, path);

            return false;
        }
    }
}
