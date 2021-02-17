using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIproject.Models.User
{
    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }


        public List<Root> roots { get; set; }
        
    }
}