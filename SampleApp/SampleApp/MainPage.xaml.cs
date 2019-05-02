using SampleApp.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnTambah.Clicked += BtnTambah_Clicked;
            btnSegi.Clicked += BtnSegi_Clicked;
            btnAbout.Clicked += BtnAbout_Clicked;
        }

        private void BtnAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void BtnSegi_Clicked(object sender, EventArgs e)
        {
            Kalkulator myKal = new Kalkulator();
            double luas = myKal.LuasSegitiga(12, 34);
            DisplayAlert("Hasil", $"Luas Segitiga: {luas}", "OK");
        }

        private void BtnTambah_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 + bil2;
            txtHasil.Text = hasil.ToString();
        }
    }
}
