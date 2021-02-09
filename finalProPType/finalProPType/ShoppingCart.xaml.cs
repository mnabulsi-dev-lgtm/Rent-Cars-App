using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalProPType
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingCart : ContentPage
    {
       
        List<Car> cartlist = new List<Car> { Application.Current.Properties["data"] as Car } ;
        public ShoppingCart()
        {
            InitializeComponent();
           
            carListView.ItemsSource = cartlist;
            carListView.BindingContext = cartlist;
            
        }

       
    }
}