using finalProPType.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalProPType.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        SQLiteConnection con;
        public Registration()
        {
            InitializeComponent();
        }

        private void RegBtn_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            con = new SQLiteConnection(databasePath);
            con.CreateTable<RegUserTable>();
            var item = new RegUserTable
            {
                UserName = unEntry.Text,
                password = pwEntry.Text,
                confirmPw = rePwEntry.Text,
                phoneNumber = phoneEntry.Text
            };
            con.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
              var res = await DisplayAlert("Gongrats !", unEntry.Text +" you have successfully completed the registration process", "ok" ,"cancel");
                if (res)
                    await Navigation.PushAsync(new Login());
            });
        }
    }
}