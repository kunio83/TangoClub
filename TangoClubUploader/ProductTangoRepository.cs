using Bukimedia.PrestaSharp.Entities;
using Bukimedia.PrestaSharp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangoClubUploader.Modelo;

namespace TangoClubUploader
{
    class ProductTangoRepository
    {
        TangoClubCatalogoEntities _context = new TangoClubCatalogoEntities();
        ProductFactory _productFactory;
        ProductFeatureFactory _pFeatureFactory;
        ProductFeatureValueFactory _pFValueFactory;

        public ProductTangoRepository(String BaseUrl, String Account, String Password)
        {
            TangoClubCatalogoEntities context = new TangoClubCatalogoEntities();
            _productFactory = new ProductFactory(BaseUrl, Account, Password);
            _pFeatureFactory = new ProductFeatureFactory(BaseUrl, Account, Password);
            _pFValueFactory = new ProductFeatureValueFactory(BaseUrl, Account, Password);
        }

        public void CargarCancionProducto(TangoClub cancion)
        {
            product productBase = this._productFactory.Get(25);
            productBase.active = 1;

            //Album
            product_feature_value pFValueAlbum = new product_feature_value();
            pFValueAlbum.id_feature = 8;
            pFValueAlbum.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Album},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Album}
            };
            //Autor
            product_feature_value pFValueAutor = new product_feature_value();
            pFValueAutor.id_feature = 9;
            pFValueAutor.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Autor},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Autor}
            };
            //codigoAlbum
            product_feature_value pFValueCodAlbum = new product_feature_value();
            pFValueCodAlbum.id_feature = 10;
            pFValueCodAlbum.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.CodigoAlbum},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.CodigoAlbum}
            };
            //Compositor
            product_feature_value pFValueCompositor = new product_feature_value();
            pFValueCompositor.id_feature = 11;
            pFValueCompositor.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Compositor},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Compositor}
            };
            //Fecha
            product_feature_value pFValueFecha = new product_feature_value();
            pFValueFecha.id_feature = 12;
            pFValueFecha.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Fecha},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Fecha}
            };
            //Genero
            product_feature_value pFValueGenero = new product_feature_value();
            pFValueGenero.id_feature = 13;
            pFValueGenero.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Genero},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Genero}
            };
            //Interprete
            product_feature_value pFValueInterprete = new product_feature_value();
            pFValueInterprete.id_feature = 14;
            pFValueInterprete.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Interprete},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Interprete}
            };
            //Orquesta
            product_feature_value pFValueOrquesta = new product_feature_value();
            pFValueOrquesta.id_feature = 15;
            pFValueOrquesta.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Orquesta},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Orquesta}
            };
            //Sello
            product_feature_value pFValueSello = new product_feature_value();
            pFValueSello.id_feature = 16;
            pFValueSello.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Sello},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Sello}
            };
            //Track
            product_feature_value pFValueTrack = new product_feature_value();
            pFValueTrack.id_feature = 17;
            pFValueTrack.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Track.ToString()},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Track.ToString()}
            };
            //Vocalista
            product_feature_value pFValueVocalista = new product_feature_value();
            pFValueVocalista.id_feature = 18;
            pFValueVocalista.value = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Vocalista},
                new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { Value = cancion.Vocalista}
            };

            productBase.associations.product_features = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.product_feature>()
            {
                new Bukimedia.PrestaSharp.Entities.AuxEntities.product_feature()
                {
                    //id_feature_value = new 
                }
            };
            /*
             * creo que tengo que ir cargandop los feature_value de a uno, obtener el id y asignarlo al producto
             * 
             * 
             * 
             */
        }

        public void Sincronizar()
        {
            List<TangoClub> lstCanciones = this._context.TangoClub.ToList();
            List<product> lstProductos = this._productFactory.GetAll();
            List<product_feature> lstFeature = this._pFeatureFactory.GetAll();
            List<product_feature_value> lstFeatureValue = this._pFValueFactory.GetAll();

            Boolean existeEnTienda = true;
            String shortDesc = String.Empty;
            List<TangoClub> lstProductosAAgregar = new List<TangoClub>();
            foreach (TangoClub c in lstCanciones)
            {
                shortDesc = String.Format("Interprete {0} - Album: {1} - Track: {2} - Tema: {3}", c.Interprete, c.Album, c.Track, c.Tema);

                if (lstProductos.Where(z => z.name[0].Value == c.Tema &&
                    z.description_short[0].Value == shortDesc).Count() > 0)
                {
                    continue;
                }
                else
                {
                    lstProductosAAgregar.Add(c);
                }

            }



        }
    }
}
