using AYUGSI_S5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace AYUGSI_S5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage

    {
        private const string url = "http://172.28.112.1/ws_uisarel/post.php";
        private readonly HttpClient client = new HttpClient();

        private ObservableCollection<AYUGSI_S5.Datos> post;
        public Page1()
        {
            InitializeComponent();

            mostrar();
        }

        public   async   void mostrar() {

            var contenido = await client.GetStringAsync(url);
            List<AYUGSI_S5.Datos> listapost = JsonConvert.DeserializeObject<List<AYUGSI_S5.Datos>>(contenido);
            post = new ObservableCollection<Datos>(listapost);

            ListaEstudiantes.ItemsSource = post;



        }

        private void btnIr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Insertar());
        }

        private void ListaEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var objetoestudiante = (Datos)e.SelectedItem;
            /*int codigo  = Convert.ToInt32(objetoestudiante.codigo.ToString());  
            string nombre  =objetoestudiante.nombre.ToString();
            string apellido = objetoestudiante.apellido .ToString();
            int edad = Convert.ToInt32(objetoestudiante.edad.ToString());*/

            Navigation.PushAsync(new Actualizar(objetoestudiante));


        }
    }
}


