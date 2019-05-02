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
    public partial class SampleListPage : ContentPage
    {
        public SampleListPage()
        {
            InitializeComponent();

            List<string> lstNama = new List<string>
            {
                "Erick","Budi","Bambang","Argo","Halim"
            };
            listNama.ItemsSource = lstNama;
        }
    }
}