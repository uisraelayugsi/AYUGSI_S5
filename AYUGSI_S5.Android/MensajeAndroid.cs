using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AYUGSI_S5.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly:Xamarin.Forms.Dependency(typeof(MensajeAndroid))]
namespace AYUGSI_S5.Droid
{
    public  class MensajeAndroid : mensaje
    {
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context,mensaje,ToastLength.Long).Show();
        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}