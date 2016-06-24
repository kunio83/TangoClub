using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TangoClubUploader.Modelo;
using TangoCommon;

namespace TangoClubUploader
{
    public partial class Principal : Form
    {
        ProductTangoRepository _tangoRepo;


        public Principal()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.RefrescarInfoLabel();
            String msj = String.Format("Total canciones en la Tienda: {0}\r\nTotal canciones en Base Local: {1}\r\nCanciones a Cargar: {2}\r\n¿Desea Continuar?",
                                        this._tangoRepo.totalEnTienda.ToString(), this._tangoRepo.totalLocal.ToString(), this._tangoRepo.totalASubir.ToString());

            if (((DialogResult)MessageBox.Show(msj, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.OK)
            {
                this.Sincronizar();
            }
        }

        private void Sincronizar()
        {
            int Numactual = 0;
            string newFileName;
            progressBar1.Maximum = this._tangoRepo.totalASubir;

            foreach (TangoClub cancion in this._tangoRepo._cancionesAAgregar)
            {

                //TangoClub cancion = this._tangoRepo._cancionesAAgregar[0];

                lblEstado.Text = "Procesando: " + Path.GetFileName(cancion.Path);
                newFileName = this._tangoRepo.GetNewFileName();
                //Creamos el Producto
                this._tangoRepo.CargarCancionProducto(cancion, newFileName);

                //Subimos a FTP
                String ftpHost = Properties.Settings.Default.FtpHost;
                String ftpUser = Properties.Settings.Default.FtpUser;
                String ftpPass = Properties.Settings.Default.FtpPass;

                VBRepository.SubirAftp(@"C:\Users\ThinkPadW7\Music\index.mp3"/*cancion.Path*/, newFileName, ftpHost, ftpUser, ftpPass);

                Numactual++;
                lblCantidad.Text = String.Format("{0} / {1}", Numactual, this._tangoRepo.totalASubir);
                progressBar1.Value = Numactual;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Instancio repo tango con datos del properties
            String BaseUrl = Properties.Settings.Default.ApiUrl;
            String Account = Properties.Settings.Default.ApiAccount;
            String Password = Properties.Settings.Default.ApiPass;
            this._tangoRepo = new ProductTangoRepository(BaseUrl, Account, Password);

            this.RefrescarInfoLabel();


        }

        private void RefrescarInfoLabel()
        {
            //Mostrando info de carga
            lblTips.Text = "Cargando Informacion de Subida...";
            Application.DoEvents();
            this._tangoRepo.RefreshInfoCarga();
            lblTips.Text = String.Format("Total canciones en la Tienda: {0}\r\nTotal canciones en Base Local: {1}\r\nCanciones a Cargar: {2}",
                                        this._tangoRepo.totalEnTienda.ToString(), this._tangoRepo.totalLocal.ToString(), this._tangoRepo.totalASubir.ToString());
            lblCantidad.Text = String.Format("{0} / {1}", 0, this._tangoRepo.totalASubir);
        }
    }
}
