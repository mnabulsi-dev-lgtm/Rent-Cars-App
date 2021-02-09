using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalProPType
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Help : ContentPage
    {
        public Help()
        {
            InitializeComponent();
        }

        private void bttns_Clicked(object sender, EventArgs e)
        {
            if (IdInput.Text == "123add")
                Navigation.PushAsync(new AddCar());

            else if (IdInput.Text == "123up")
                Navigation.PushAsync(new updateCar());
            else if (IdInput.Text == "123del")
                Navigation.PushAsync(new DeleteCar());
            else DisplayAlert("wrong ID", "the submited ID is not found !", "ok", "cancel");

        }
    }
}