using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_WorkingWithModel.Models
{
    public class ProductViewModel
    {
        public List<Products> Plist { get; set; }
        public List<Categories> Clist { get; set; }
    }
}