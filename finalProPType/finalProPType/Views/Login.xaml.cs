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
    public partial class Login : ContentPage
    {
        SQLiteConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private void RegBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Registration());
        }

        private void loginBtn_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            con = new SQLiteConnection(databasePath);
            var Qury = con.Table<RegUserTable>().Where(u => u.UserName.Equals(unEntry.Text) && u.password.Equals(pwEntry.Text)).FirstOrDefault();
            if (Qury != null)
            {
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var res = await DisplayAlert("Failed !", "You have entered Wrong Username or Password", "ReTry", "Registration");
                    if (res)
                        Application.Current.MainPage = new NavigationPage(new Login());
                    else
                    {
                        await Navigation.PushAsync(new Registration());
                    }
                });

            }
        }
    }
}