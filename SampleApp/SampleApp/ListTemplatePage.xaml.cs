using SampleApp.Models;
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
    public partial class ListTemplatePage : ContentPage
    {
        public ListTemplatePage()
        {
            InitializeComponent();
            var lstMhs = new List<Mahasiswa>
            {
                new Mahasiswa {Nim="22002321",Nama="Erick",IPK=3.2,ImageUrl="gambar.png"},
                new Mahasiswa{Nim="22002322",Nama="Andi",IPK=3.3,ImageUrl="gambar.png"}
            };
            lvMahasiswa.ItemsSource = lstMhs;
        }
    }
}