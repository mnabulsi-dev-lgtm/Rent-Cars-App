using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace finalProPType
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        List<MDContent> contents = new List<MDContent>
        {
            new MDContent{desc="Available Cars",Mdimg="ac.png"},
            new MDContent{desc="Weeding Cars",Mdimg="w.png"},
            new MDContent{desc="Car Pricing", Mdimg="p.png"},
            new MDContent{desc="Shopping Cart", Mdimg="c.png"},
            new MDContent{desc="Privacy",Mdimg="h.png"},
            new MDContent{desc="Add Car" , Mdimg="adm.png"},
            new MDContent{desc="Update Car"  , Mdimg="adm.png"},
            new MDContent{desc="Delete Car"  , Mdimg="adm.png"},
            

        };
        public MainPage()
        {
            InitializeComponent();
            myListView.ItemsSource = contents;
            //myListView.BindingContext = contents;
            Detail = new NavigationPage(new AvailableCars());
            
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var o = e.SelectedItem as MDContent;
            string page = o.desc;
            if (page.Equals("Available Cars"))
                Detail = new NavigationPage(new AvailableCars());
            else if (page.Equals("Weeding Cars"))
                Detail = new NavigationPage(new WeedingCars());
            else if (page.Equals("Car Pricing"))
                Detail = new NavigationPage(new carPricing());
            else if (page.Equals("Shopping Cart"))
                Detail = new NavigationPage(new ShoppingCart());
            else if (page.Equals("Privacy"))
                Detail = new NavigationPage(new Help());

            else if (page.Equals("Add Car"))
                Detail = new NavigationPage(new Help());
            else if(page.Equals("Delete Car"))
                Detail = new NavigationPage(new Help());

            else Detail = Detail = new NavigationPage(new Help());
            IsPresented = false;
        }
    }
}
