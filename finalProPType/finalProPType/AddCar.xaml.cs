using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace finalProPType
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCar : ContentPage
    {
        List<string> carMake = new List<string>
        {
            "Hyndai","Mercseds"
        };
        List<string> carModel = new List<string>
        {
            "Xd","Sonata","Mini","E200","E150","E250"
        };

        SQLiteConnection conn;

        public AddCar()
        {
            InitializeComponent();

            makePicker.ItemsSource = carMake;
            modelPicker.ItemsSource = carModel;

        }

        private void SubmitBttn_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            conn = new SQLiteConnection(databasePath);
            conn.CreateTable<Car>();
          
          
            Car c = new Car
            {
                carMake = makePicker.SelectedItem.ToString(),
                carModel = modelPicker.SelectedItem.ToString(),
                price = carPrice.Text,
                expDate = dofrent.Text,
                
        };
           // Application.Current.Properties["data"] = carMake;
            conn.Insert(c);
           


        }
    }
}