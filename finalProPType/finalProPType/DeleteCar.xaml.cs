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
    public partial class DeleteCar : ContentPage
    {
        SQLiteConnection conn;
        public DeleteCar()
        {
            InitializeComponent();
        }

        private void dBtn_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            conn = new SQLiteConnection(databasePath);
            conn.Query<Car>("DELETE FROM Car WHERE CarID=" +id.Text );
            id.Text = "";
            allIDS.Text = "";
        }

        private void showBtn_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            conn = new SQLiteConnection(databasePath);
            var lst = conn.Query<Car>("select * from Car ");
            foreach (Car c in lst)
            {
                
                allIDS.Text += "ID="+ c.CarID.ToString() +"\t ";
            }

        }
    }
}