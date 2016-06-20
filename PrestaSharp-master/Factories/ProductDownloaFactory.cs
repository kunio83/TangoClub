using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Factories
{
    public class ProductDownloadFactory : RestSharpFactory
    {
        public ProductDownloadFactory(string BaseUrl, string Account, string SecretKey)
            : base(BaseUrl, Account, SecretKey)
        {
        }

        public Entities.product_download Get(long ProductDownloadId)
        {
            RestRequest request = this.RequestForGet("product_downloads", ProductDownloadId, "product_download");
            return this.Execute<Entities.product_download>(request);
        }

        public Entities.product_download Add(Entities.product_download Product_download)
        {
            long? idAux = Product_download.id;

            Product_download.id = null;
            List<PrestaSharp.Entities.PrestaShopEntity> Entities = new List<PrestaSharp.Entities.PrestaShopEntity>();
            Entities.Add(Product_download);
            RestRequest request = this.RequestForAdd("product_downloads", Entities);
            Entities.product_download aux = this.Execute<Entities.product_download>(request);
            Product_download.id = idAux;
            return this.Get((long)aux.id);
        }

        public void Update(Entities.product_download Product_download)
        {
            RestRequest request = this.RequestForUpdate("product_downloads", Product_download.id, Product_download);
            this.Execute<Entities.product_download>(request);
        }

        public void Delete(long ProductDownloadId)
        {
            RestRequest request = this.RequestForDelete("product_downloads", ProductDownloadId);
            this.Execute<Entities.product_download>(request);
        }

        public void Delete(Entities.product_download Product_download)
        {
            this.Delete((long)Product_download.id);
        }

        public List<long> GetIds()
        {
            RestRequest request = this.RequestForGet("product_downloads", null, "prestashop");
            return this.ExecuteForGetIds<List<long>>(request, "product_download");
        }

        /// <summary>
        /// More information about filtering: http://doc.prestashop.com/display/PS14/Chapter+8+-+Advanced+Use
        /// </summary>
        /// <param name="Filter">Example: key:name value:Apple</param>
        /// <param name="Sort">Field_ASC or Field_DESC. Example: name_ASC or name_DESC</param>
        /// <param name="Limit">Example: 5 limit to 5. 9,5 Only include the first 5 elements starting from the 10th element.</param>
        /// <returns></returns>
        public List<Entities.product_download> GetByFilter(Dictionary<string, string> Filter, string Sort, string Limit)
        {
            RestRequest request = this.RequestForFilter("product_downloads", "full", Filter, Sort, Limit, "product_downloads");
            return this.ExecuteForFilter<List<Entities.product_download>>(request);
        }

        /// <summary>
        /// More information about filtering: http://doc.prestashop.com/display/PS14/Chapter+8+-+Advanced+Use
        /// </summary>
        /// <param name="Filter">Example: key:name value:Apple</param>
        /// <param name="Sort">Field_ASC or Field_DESC. Example: name_ASC or name_DESC</param>
        /// <param name="Limit">Example: 5 limit to 5. 9,5 Only include the first 5 elements starting from the 10th element.</param>
        /// <returns></returns>
        public List<long> GetIdsByFilter(Dictionary<string, string> Filter, string Sort, string Limit)
        {
            RestRequest request = this.RequestForFilter("product_downloads", "[id]", Filter, Sort, Limit, "product_downloads");
            List<PrestaSharp.Entities.FilterEntities.product_download> aux = this.Execute<List<PrestaSharp.Entities.FilterEntities.product_download>>(request);
            return (List<long>)(from t in aux select t.id).ToList<long>();
        }

        /// <summary>
        /// Get all product_downloads.
        /// </summary>
        /// <returns>A list of product_downloads</returns>
        public List<Entities.product_download> GetAll()
        {
            return this.GetByFilter(null, null, null);
        }

        /// <summary>
        /// Add a list of product_downloads.
        /// </summary>
        /// <param name="Product_downloads"></param>
        /// <returns></returns>
        public List<Entities.product_download> AddList(List<Entities.product_download> Product_downloads)
        {
            List<PrestaSharp.Entities.PrestaShopEntity> Entities = new List<PrestaSharp.Entities.PrestaShopEntity>();
            foreach (Entities.product_download Product_download in Product_downloads)
            {
                Product_download.id = null;
                Entities.Add(Product_download);
            }
            RestRequest request = this.RequestForAdd("Product_downloads", Entities);
            return this.Execute<List<Entities.product_download>>(request);
        }
    }
}