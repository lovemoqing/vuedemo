using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webForm.Models
{
    public class CateGoryType
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Href { set; get; }
    }


    public class Product
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Href { set; get; }
        public string Image { set; get; }
        public string ImageUrl { set; get; }
        
    }
}