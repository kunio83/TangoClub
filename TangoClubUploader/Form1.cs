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
using TangoCommon;

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

            //Obtengo cualquier cancion
            TangoClub cancion = tangoRepo._context.TangoClub.FirstOrDefault(z => z.CodigTrack == "eu18009-7");

            //Nuevo nombre para mp3 y subo a ftp
            String newFileName = tangoRepo.GetNewFileName();
            VBRepository.SubirAftp(cancion.Path, newFileName);

            //Cargo el producto virtual
            product nuevoProduct = tangoRepo.CargarCancionProducto(cancion);

            //Genero el registro en tabla de download

            //tangoRepo._productDownloadFactory.Add()


        }
    }
}
