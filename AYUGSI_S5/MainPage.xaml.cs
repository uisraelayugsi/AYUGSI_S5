using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AYUGSI_S5
{
    public partial class MainPage : ContentPage
    {
        private const string url = "http://172.28.112.1/ws_uisarel/post.php";
        private readonly HttpClient client = new HttpClient();

        private ObservableCollection<AYUGSI_S5.Datos> post;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {

            var  contenido  = await client.GetStringAsync(url);
            List<AYUGSI_S5.Datos> listapost = JsonConvert.DeserializeObject<List<AYUGSI_S5.Datos>>(contenido);
            post = new ObservableCollection<Datos>(listapost);

            ListaEstudiantes.ItemsSource= post;
        }
    }
}
