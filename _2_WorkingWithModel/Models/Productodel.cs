using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_WorkingWithModel.Models
{
    public class Productodel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}