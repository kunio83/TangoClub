using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bukimedia.PrestaSharp.Lib;

namespace Bukimedia.PrestaSharp.Entities
{
    [XmlType(Namespace = "Bukimedia/PrestaSharp/Entities")]
    public class product_download : PrestaShopEntity
    {
        public long? id_product_download { get; set; }
        public long? id_product { get; set; }
        public string display_filename { get; set; }
        public string filename { get; set; }
        public string date_add { get; set; }
        public string date_expiration { get; set; }
        public long? nb_days_accessible { get; set; }
        public int active { get; set; }
        public int is_shareable { get; set; }
    }
}
