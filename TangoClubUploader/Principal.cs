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
        Verificador _frmVerificador;
        ProductTangoRepository _tangoRepo;
        //FileManager _fileManager;

        public Principal()
        {
            InitializeComponent();
            //this._fileManager = new FileManager();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.RefrescarInfoLabel();
            String msj = String.Format("Total canciones en la Tienda: {0}\r\nTotal canciones en Base Local: {1}\r\nCanciones a Cargar: {2}\r\n¿Desea Continuar?",
                                        this._tangoRepo.totalEnTienda.ToString(), this._tangoRepo.totalLocal.ToString(), this._tangoRepo.totalASubir.ToString());
            if (this._tangoRepo.totalASubir > 0)
            {
                if (((DialogResult)MessageBox.Show(msj, "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.OK)
                {
                    this.Sincronizar();
                    this._tangoRepo.isUpdated = false;
                    this.RefrescarInfoLabel();
                }
            }
        }

        private void Sincronizar()
        {
            int Numactual = 0;
            string newFileName;
            string cancionesNoExisten = String.Empty;
            progressBar1.Maximum = this._tangoRepo.totalASubir;
            lblTips.Text = "Publicando Articulos...";
            lblEstado.Visible = true;
            Application.DoEvents();
            foreach (TangoClub cancion in this._tangoRepo._cancionesAAgregar)
            {
                try
                {
                    if (File.Exists(cancion.path))
                    {
                        lblEstado.Text = "Procesando: " + Path.GetFileName(cancion.path) + "(" + cancion.Tema + ")";
                        newFileName = this._tangoRepo.GetNewFileName();

                        //Creamos el Producto y lo traigo por si hay que borrarlo
                        int idNuevoProducto = this._tangoRepo.CargarCancionProducto(cancion, newFileName);
                        if (idNuevoProducto != 0)
                        {
                            

                            //VBRepository.SubirAftp(cancion.path, newFileName, ftpHost, ftpUser, ftpPass, int.Parse(Properties.Settings.Default.FtpTimeOut)))

                            if (SubirAFtp(cancion.path, newFileName))
                            {
                                Numactual++;
                                lblCantidad.Text = String.Format("{0} / {1}", Numactual, this._tangoRepo.totalASubir);
                                progressBar1.Value = Numactual;
                            }
                            else
                            {
                                this._tangoRepo._productFactory.Delete(idNuevoProducto);
                                lblEstado.Visible = false;
                                progressBar1.Value = 0;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    lblEstado.Visible = false;
                    Clipboard.SetText(ex.Message);
                    MessageBox.Show("Error: " + ex.Message);
                    progressBar1.Maximum = this._tangoRepo.totalASubir;
                    break;
                }
                
            }
            System.Windows.Forms.MessageBox.Show("Fin de Publicación");
            //System.Windows.Forms.MessageBox.Show(this, "no existen:" + cancionesNoExisten, "Fin de Publicación");
            //mbox.Text = "Fin de Publicación" + nl + "no existen:" + cancionesNoExisten;
            //mbox.Show(this, "no existen:" + cancionesNoExisten, "Fin de Publicación");
            lblEstado.Visible = false;
        }

        private Boolean SubirAFtp(string path, string fileName)
        {
            //Subimos a FTP
            String ftpHost = Properties.Settings.Default.FtpHost;
            String ftpUser = Properties.Settings.Default.FtpUser;
            String ftpPass = Properties.Settings.Default.FtpPass;
            int ftpRetries = int.Parse(Properties.Settings.Default.FtpCantidadReintentos);
            int ftpTimeout = int.Parse(Properties.Settings.Default.FtpCantidadReintentos);
            int ftpIntento = 0;
            bool result = false;

            try
            {
                while (!result && ftpIntento < ftpRetries)
                {
                    ftpIntento++;
                    result = VBRepository.SubirAftp(path, fileName, ftpHost, ftpUser, ftpPass, ftpTimeout);
                }

                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Instancio repo tango con datos del properties
            String BaseUrl = Properties.Settings.Default.ApiUrl;
            String Account = Properties.Settings.Default.ApiAccount;
            String Password = Properties.Settings.Default.ApiPass;
            this._tangoRepo = new ProductTangoRepository(BaseUrl, Account, Password);

            //this.RefrescarInfoLabel();
        }

        private void RefrescarInfoLabel()
        {
            try
            {
                //Mostrando info de carga
                lblTips.Text = "Cargando Informacion de Subida...";
                Application.DoEvents();
                this._tangoRepo.RefreshInfoCarga();
                lblTips.Text = String.Format("Total canciones en la Tienda: {0}\r\nTotal canciones en Base Local: {1}\r\nCanciones a Cargar: {2}",
                                            this._tangoRepo.totalEnTienda.ToString(), this._tangoRepo.totalLocal.ToString(), this._tangoRepo.totalASubir.ToString());
                lblCantidad.Text = String.Format("{0} / {1}", 0, this._tangoRepo.totalASubir);
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefrescarInfoLabel();

            if (this._frmVerificador == null)
                this._frmVerificador = new Verificador(this._tangoRepo);

            this._frmVerificador.ShowDialog();
        }
    }
}
