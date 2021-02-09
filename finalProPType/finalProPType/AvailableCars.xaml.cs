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
    public partial class AvailableCars : ContentPage
    {
        SQLiteConnection conn;
        public AvailableCars()
        {
            InitializeComponent();
            
            //BindingImg s = new BindingImg();
            // s.AvailableImg = "logo.jpg";
            //imagView.ItemsSource = s.AvailableImg.ToString();
            //imagView.BindingContext =s.AvailableImg ;

        }

        private  void show_Clicked(object sender, EventArgs e)
        {
          
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            conn = new SQLiteConnection(databasePath);
            var lst = conn.Query<Car>("select * from Car where carMake= Hyndai");
           
            contentView.ItemsSource = lst;
            contentView.BindingContext = lst;

        }

        private  void  contentView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           

            Device.BeginInvokeOnMainThread(async () =>
            {
                var res = await DisplayAlert("Alert", "Are you sure you want to add this item to the Shopping cart ?", "ok","cancel");
                if (res == true)
                {
                    Application.Current.Properties["data"] = e.SelectedItem as Car;
                    await Navigation.PushAsync(new ShoppingCart());
                }
                   
                else
                {
                    await Navigation.PushAsync(new AvailableCars());
                }
            });
        }
    }
}