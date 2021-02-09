using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace finalProPType
{
    public class Car
    {
        [PrimaryKey,AutoIncrement]
        public int CarID { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string price { get; set; }
        public string expDate { get; set; }
       
    }
}
