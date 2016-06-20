using Bukimedia.PrestaSharp.Entities;
using Bukimedia.PrestaSharp.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TangoClubUploader.Modelo;

namespace TangoClubUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BaseUrl = "http://fs000512.ferozo.com/api";
            string Account = "Q46L3LAFZZGKPBH6DAEMHWVR2BVV1U47";
            string Password = "";
            ProductTangoRepository tangoRepo = new ProductTangoRepository(BaseUrl, Account, Password);

            TangoClub cancion = tangoRepo._context.TangoClub.FirstOrDefault(z => z.CodigTrack == "eu18009-7");

            //tangoRepo.Sincronizar();
            product nuevoProduct = tangoRepo.CargarCancionProducto(cancion);

            nuevoProduct.cache_has_attachments = 1;
            
            //string BaseUrl = "http://fs000512.ferozo.com/api";
            //string Account = "Q46L3LAFZZGKPBH6DAEMHWVR2BVV1U47";
            //string Password = "";
            //ProductFactory productFactory = new ProductFactory(BaseUrl, Account, Password);
            //ProductFeatureFactory pFeatureFactory = new ProductFeatureFactory(BaseUrl, Account, Password);
            //ProductFeatureValueFactory pFValueFactory = new ProductFeatureValueFactory(BaseUrl, Account, Password);

            //product producto = productFactory.Get(24);

            //List<product_feature> lstpfeature =   pFeatureFactory.GetAll();
            //List<product_feature_value> lstpfvalue = pFValueFactory.GetAll();

            //algunos cambios para nuevo producto
            //producto.id = 0;
            //producto.associations.product_bundle = null;
            //producto.name = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
            //{
            //    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() {id = 1,Value = "Nuevo producto" },
            //    new Bukimedia.PrestaSharp.Entities.AuxEntities.language() { id = 2,Value = "Nuevo Producto" }
            //};
            //product productoNuevo = producto;
            //productFactory.Add(productoNuevo);

            //product productoResult = productFactory.Add(producto);



            //List<product> producto = productFactory.GetAll();
        }
    }
}
