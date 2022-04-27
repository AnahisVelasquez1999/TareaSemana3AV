using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2AV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarea_Semana2 : ContentPage
    {
        public Tarea_Semana2(String User)
        {
            InitializeComponent();
            lblUser.Text = User;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);
                double examen2= Convert.ToDouble(txtExamen2.Text);

                double parcial1 = (nota1 * 0.3) + (examen1 * 0.2);
                double parcial2 = (nota2 * 0.3) + (examen2 * 0.2);

                txtParcial1.Text = parcial1.ToString();
                txtParcial2.Text = parcial2.ToString();

                double notafinal = parcial1 + parcial2;

                txtNotaFinal.Text = notafinal.ToString();

                if (Convert.ToDouble(txtNotaFinal.Text) >= 7)
                {
                    DisplayAlert("Mensaje de alerta", "Aprobado", "Cerrar");
                }

                if (Convert.ToDouble(txtNotaFinal.Text) >= 5 && Convert.ToDouble(txtNotaFinal.Text) <= 6.9)
                {
                    DisplayAlert("Mensaje de alerta", "Complementario", "Cerrar");
                }
                if (Convert.ToDouble(txtNotaFinal.Text) <5)
                {
                    DisplayAlert("Mensaje de alerta", "Reprobado", "Cerrar");
                }
            }
            catch(Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar");

            }
        }
    }
}