using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSI_S5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string url = "http://172.28.112.1/ws_uisarel/post.php";
                var parametros =  new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApelldio.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues(url, "POST", parametros);
                DisplayAlert("Alerta", "ingreso corecto ", "cerar");



                Navigation.PushAsync(new Page1());
         

            }
            catch (Exception ex )
            {

                DisplayAlert("Alerta",ex.Message , "cerar");
            }
        }
    }
}