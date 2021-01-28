using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLaptopApp.Models
{
    public class Laptop
    {
        [PrimaryKey]
        public string MALT { get; set; }
        public string MANSX { get; set; }
        public string TEN { get; set; }
        public string HINH { get; set; }
        public string MOTA { get; set; }
        public string GIA { get; set; }
    }
}
