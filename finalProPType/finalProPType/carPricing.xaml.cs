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
    public partial class carPricing : ContentPage
    {
        List<string> carMake = new List<string>
        {
            "Hyndai","Mercseds"
        };
        List<string> carModel = new List<string>
        {
            "Xd","Sonata","Mini","E200","E150","E250"
        };
        List<string> durations = new List<string>
        {
            "For a day" , "For a week" , "For a month"
        };
        public carPricing()
        {
            InitializeComponent();
            makePicker.ItemsSource = carMake;
            modelPicker.ItemsSource = carModel;
            durationPicker.ItemsSource = durations;
           

        }

        private void showRes_Clicked(object sender, EventArgs e)
        {
            string m = makePicker.SelectedItem as string;
            string d = modelPicker.SelectedItem as string;
            string t = durationPicker.SelectedItem as string;

            if (m == "Hyndai" && d == "Sonata")
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "30 JD for a day";
                if (t.Equals("For a week"))
                    weeklylbl.Text = "180 JD for a week";
                if (t.Equals("For a month"))
                    monthlylbl.Text = "750 JD for a month";
            }
            else if (m == "Hyndai" && d == "Xd")
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "15 JD for a day";
                else if (t.Equals("For a week"))
                    weeklylbl.Text = "90 JD for a week";
                else if (t.Equals("For a month"))
                    monthlylbl.Text = "350 JD for a month";
            }
            else if (m == "Hyndai" && d == "Mini")
                
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "10 JD for a day";
                else if (t.Equals("For a week"))
                    weeklylbl.Text = "60 JD for a week";
                else if (t.Equals("For a month"))
                    monthlylbl.Text = "270 JD for a month";
            }
            //else nilbl.Text = "Hmm.. it seems no Car with these details !";
           else if (m == "Mercseds" && d == "E250")
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "250 JD for a day";
                else if (t.Equals("For a week"))
                    weeklylbl.Text = "1500 JD for a week";
                else if (t.Equals("For a month"))
                    monthlylbl.Text = "go and buy a one :')";
            }
            else if (m == "Mercseds" && d == "E200")
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "200 JD for a day";
                else if (t.Equals("For a week"))
                    weeklylbl.Text = "1300 JD for a week";
                else if (t.Equals("For a month"))
                    monthlylbl.Text = "go and buy a one :')";
            }
            else if (m == "Mercseds" && d == "E150")
            {
                if (t.Equals("For a day"))
                    dailylbl.Text = "150 JD for a day";
                else if (t.Equals("For a week"))
                    weeklylbl.Text = "900 JD for a week";
                else if (t.Equals("For a month"))
                    monthlylbl.Text = "go and buy a one :')";
            }

            else   nilbl.Text = "Hmm.. it seems no Car with these details !"; 
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            dailylbl.Text = "";
            weeklylbl.Text = "";
            monthlylbl.Text = "";
        }
    }
}