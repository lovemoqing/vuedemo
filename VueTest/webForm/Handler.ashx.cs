using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using webForm.Models;
namespace webForm
{
    /// <summary>
    /// Handler 的摘要说明
    /// </summary>
    public class Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string type = context.Request["type"] ?? "";
            int typeid = 0;
            int.TryParse(context.Request["typeid"], out typeid);
            int orderid = 0;
            int.TryParse(context.Request["orderid"], out orderid);
            switch (type)
            {
                case "type":
                    context.Response.Write(JsonConvert.SerializeObject(GetTypeList()));
                    break;
                case "prodlist":
                    context.Response.Write(JsonConvert.SerializeObject(GetProductList(typeid, orderid)));
                    break;
                default:
                    break;
            }
        }
        public List<CateGoryType> GetTypeList()
        {
            List<CateGoryType> list = new List<CateGoryType>() { 
                new CateGoryType { ID = 1, Name = "Finished Fabric", Href = "http://localhost:8107/Home.html" }, 
                new CateGoryType { ID = 2, Name = "Elastic Woven Satin", Href = "http://localhost:8107/Home.html" }, 
                new CateGoryType { ID = 3, Name = "Ice Tulle", Href = "http://localhost:8107/Home.html" },
                new CateGoryType { ID = 4, Name = "Matte Satin", Href = "http://localhost:8107/Home.html" },
                new CateGoryType { ID = 5, Name = "Organza", Href = "http://localhost:8107/Home.html" }
            };
            return list;
        }

        public List<Product> GetProductList(int typeid, int orderid)
        {
            List<Product> list = new List<Product>() { 
                new Product { ID = 1, Title = typeid+"Casual Plain Soft PU Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/1.png" }, 
                new Product { ID = 2, Title = typeid+"Versatile Canvas Zipper Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/2.png" }, 
                new Product { ID = 3, Title = typeid+"Casual Plain Canvas Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/3.png" }, 
                new Product { ID = 4, Title = typeid+"Concise Sewing Thread Plain Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/1.png" }, 
                new Product { ID = 5, Title = typeid+"Casual Plain Nylon Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/2.png" }, 
                new Product { ID = 6, Title = typeid+"Huge Space Plain Zipper Men's Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/3.png" }, 
                new Product { ID = 7, Title = typeid+"Casual Tassel Thread Women Satchel"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/1.png" }, 
                new Product { ID = 8, Title = typeid+"Concise Short Type Women Purse"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/2.png" }, 
                new Product { ID = 9, Title = typeid+"Fashion Plain Women PU Tote Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/3.png" }, 
                new Product { ID = 10, Title = typeid+"Casual Rivet Thread Women Tote Bag"+orderid, Href = "http://localhost:8107/Home.html",ImageUrl="/Images/1.png" }, 
            };
            return list;
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}