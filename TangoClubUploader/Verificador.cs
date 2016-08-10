using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TangoClubUploader.Modelo;

namespace TangoClubUploader
{
    public partial class Verificador : Form
    {
        FileManager _fileManager;
        ProductTangoRepository _tangoRepo;
        bool _tuvoActividad = false;

        public Verificador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            Application.DoEvents();

            try
            {
                if (this._fileManager == null)
                    this._fileManager = new FileManager();

                this._fileManager.BlanquearArchivo();

                Iterar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            label1.Visible = false;
            Application.DoEvents();
        }

        private void Iterar()
        {
            String totalCanciones = String.Empty;
            String tab = "\t";
            String newLine = "\r\n";

            foreach (TangoClub cancion in this._tangoRepo._cancionesAAgregar)
            {
                try
                {
                    if (!File.Exists(cancion.path) && !this._fileManager.ExisteCancion(cancion.path))
                    {
                        totalCanciones += cancion.path + tab + cancion.Interprete + tab + cancion.Album + tab + cancion.Tema + newLine;

                        
                        this._tuvoActividad = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

            if (this._tuvoActividad)
            {
                this._fileManager.EscribirCancion(totalCanciones);


                if (this._tuvoActividad && ((DialogResult)MessageBox.Show("Fin de Verificacion, Desea Abrir el Resultado?", "Verificacion", MessageBoxButtons.OKCancel)) == DialogResult.OK)
                {
                    Process.Start(this._fileManager._pathArchivo);
                }
            }
            this._fileManager.Dispose();
        }

        private void Verificador_Load(object sender, EventArgs e)
        {
            //Instancio repo tango con datos del properties
            String BaseUrl = Properties.Settings.Default.ApiUrl;
            String Account = Properties.Settings.Default.ApiAccount;
            String Password = Properties.Settings.Default.ApiPass;
            this._tangoRepo = new ProductTangoRepository(BaseUrl, Account, Password);
            this._tangoRepo.RefreshInfoCarga();

        }
    }
}
