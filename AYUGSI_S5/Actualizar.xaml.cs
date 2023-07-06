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
    public partial class Actualizar : ContentPage
    {
        public Actualizar(Datos datos)
        {
            InitializeComponent();
            txtCodigo.Text = datos.codigo.ToString();
            txtNombre.Text = datos.nombre.ToString();
            txtApelldio.Text = datos.apellido.ToString();
            txtEdad.Text = datos.edad.ToString(); 


        }

        private void btnActualizarId_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string url = "http://172.28.112.1/ws_uisarel/post.php";
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApelldio.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues(url + "?codigo=" + txtCodigo.Text + "?nombre=" + txtNombre.Text + "?apellido=" + txtApelldio.Text + "?edad=" + txtEdad.Text, "PUT", parametros);
               // DisplayAlert("Alerta", "Registro ACTUALIZADO correctamente", "Cerrar");

                var mensaje = "REGISTRO  MODIFICADO CORRECTAMENTE";

                DependencyService.Get<mensaje>().LongAlert(mensaje);

                Navigation.PushAsync(new Page1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

        }

        private void btnBorrarId_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string url = "http://172.28.112.1/ws_uisarel/post.php";
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);

                client.UploadValues(url + "?codigo=" + txtCodigo.Text, "DELETE", parametros);
                //DisplayAlert("Alerta", "Registro borrado correctamente", "Cerrar");



                var mensaje = "REGISTRO  ELIMINADO CORRECTAMENTE";

                DependencyService.Get<mensaje>().LongAlert(mensaje);

                Navigation.PushAsync(new Page1());
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }


        }
    }
}