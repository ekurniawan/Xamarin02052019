using SampleApp.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            btnSegi.Clicked += BtnSegi_Clicked;
        }

        private void BtnSegi_Clicked(object sender, EventArgs e)
        {
            Kalkulator myKal = new Kalkulator();
            double hasil = myKal.LuasSegitiga(11, 12);
            DisplayAlert("Hasil", $"Luas: {hasil}", "OK");
        }
    }
}