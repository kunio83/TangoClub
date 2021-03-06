﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TangoClubUploader
{
    public class FileManager
    {
        private string _pathRootFolder;
        public string _pathArchivo;
        FileStream _fileStreamDelete;
        FileStream _fileStreamWrite;
        FileStream _fileStreamRead;
        public FileManager()
        {
            string pathApp = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(pathApp);
            this._pathRootFolder = directory;
            _pathArchivo = directory + @"\" + Properties.Settings.Default.FileName;
        }

        public void EscribirCancion(String texto)
        {
            try
            {
                //this code segment write data to file.
                FileStream fs1 = new FileStream(this._pathArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs1);
                writer.WriteLine(texto);
                writer.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error de escritura: " + ex.Message);
            }
        }

        public void BorrarCancion(String cancion)
        {

            var file = new List<string>(System.IO.File.ReadAllLines(this._pathArchivo));
            int indexLinea = file.IndexOf(cancion);
            if (indexLinea != 0)
            {
                file.RemoveAt(indexLinea);
                File.WriteAllLines(this._pathArchivo, file.ToArray());
            }
        }

        public Boolean ExisteCancion(String cancion)
        {
            //this code segment read data from the file.
            FileStream fs2 = new FileStream(this._pathArchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fs2);
            var texto = reader.ReadToEnd();
            reader.Close();
            if (texto.Contains(cancion))
                return true;
            return false;
            
        }

        public void BlanquearArchivo()
        {
            try
            {
                if (File.Exists(this._pathArchivo))
                {
                    if (this._fileStreamDelete == null)
                        this._fileStreamDelete = new FileStream(this._pathArchivo, FileMode.Truncate);

                    this._fileStreamDelete.Dispose();
                    File.Delete(this._pathArchivo);
                }

                //if (File.Exists(this._pathArchivo))
                //{
                //    File.Delete(this._pathArchivo);
                //}
                //File.Create(this._pathArchivo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Blanquear: " + ex.Message);
            }
        }

        public void Dispose()
        {
            if (this._fileStreamDelete != null)
                this._fileStreamDelete.Dispose();
            if (this._fileStreamWrite != null)
                this._fileStreamWrite.Dispose();
            if (this._fileStreamRead != null)
                this._fileStreamRead.Dispose();
        }


    }
}
 