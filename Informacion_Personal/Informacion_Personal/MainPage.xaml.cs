using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Informacion_Personal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviarInformacion_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Informacion
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Correo = txtcorreo.Text
            };
            var page = new Views.InfoPersonal();
            page.BindingContext = emple;
            await Navigation.PushModalAsync(page);
        }
    }
}
