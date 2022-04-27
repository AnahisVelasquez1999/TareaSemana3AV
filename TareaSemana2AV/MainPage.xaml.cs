using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana2AV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if ((user == "estudiante2021") && (pass == "uisrael2021")){
                await Navigation.PushAsync(new Tarea_Semana2(user));
            }
            else
            {
                await DisplayAlert("Mensaje de Alerta","El usuario o password son incorrectos","Cerrar");
            }
           
        }
    }
}
