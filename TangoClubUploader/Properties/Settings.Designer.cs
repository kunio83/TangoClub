﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TangoClubUploader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ftp://buenosairestangoclub.com/")]
        public string FtpHost {
            get {
                return ((string)(this["FtpHost"]));
            }
            set {
                this["FtpHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mp3@buenosairestangoclub.com")]
        public string FtpUser {
            get {
                return ((string)(this["FtpUser"]));
            }
            set {
                this["FtpUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("batc2016")]
        public string FtpPass {
            get {
                return ((string)(this["FtpPass"]));
            }
            set {
                this["FtpPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://buenosairestangoclub.com/api")]
        public string ApiUrl {
            get {
                return ((string)(this["ApiUrl"]));
            }
            set {
                this["ApiUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Q46L3LAFZZGKPBH6DAEMHWVR2BVV1U47")]
        public string ApiAccount {
            get {
                return ((string)(this["ApiAccount"]));
            }
            set {
                this["ApiAccount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApiPass {
            get {
                return ((string)(this["ApiPass"]));
            }
            set {
                this["ApiPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public string DiasDisponible {
            get {
                return ((string)(this["DiasDisponible"]));
            }
            set {
                this["DiasDisponible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public string CantidadDescargas {
            get {
                return ((string)(this["CantidadDescargas"]));
            }
            set {
                this["CantidadDescargas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string Precio {
            get {
                return ((string)(this["Precio"]));
            }
            set {
                this["Precio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public string IdProductoBase {
            get {
                return ((string)(this["IdProductoBase"]));
            }
            set {
                this["IdProductoBase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CancionesInexistentes.csv")]
        public string FileName {
            get {
                return ((string)(this["FileName"]));
            }
            set {
                this["FileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public string FtpTimeOut {
            get {
                return ((string)(this["FtpTimeOut"]));
            }
            set {
                this["FtpTimeOut"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string FtpCantidadReintentos {
            get {
                return ((string)(this["FtpCantidadReintentos"]));
            }
            set {
                this["FtpCantidadReintentos"] = value;
            }
        }
    }
}
