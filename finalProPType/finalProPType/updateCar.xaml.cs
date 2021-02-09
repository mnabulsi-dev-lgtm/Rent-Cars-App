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
    public partial class updateCar : ContentPage
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
        public updateCar()
        {
            InitializeComponent(); 
            makePicker.ItemsSource = carMake;
            modelPicker.ItemsSource = carModel;
        }

        private void upBttn_Clicked(object sender, EventArgs e)
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
           
            conn.Update(c);
        }
    }
}