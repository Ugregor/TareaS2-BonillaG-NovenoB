using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS2_BonillaG_NovenoB
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string password)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
            double notaSegP1 = Convert.ToDouble(txtNotaSegP1.Text);
            double notaExaP1 = Convert.ToDouble(txtNotaExaP1.Text);
            double notaSegP2 = Convert.ToDouble(txtNotaSegP2.Text);
            double notaExaP2 = Convert.ToDouble(txtNotaExaP2.Text);

            double notaP1 = (notaSegP1 * 0.30) + (notaExaP1 * 0.20);
            double notaP2 = (notaSegP2 * 0.30) + (notaExaP2 * 0.20);
            double notaF = notaP1 + notaP2;

            txtNotaP1.Text = notaP1.ToString();
            txtNotaP2.Text = notaP2.ToString();
            txtNotaF.Text = notaF.ToString();

            if (notaF >= 7)
            {
                DisplayAlert("Notificación", "Aprobado la Materia, su Nota Final es: " + notaF, "Cerrar");
            }
            else if (notaF <= 7 && notaF >= 5)
            {
                DisplayAlert("Notificación", "Su Nota Final es " + notaF + " debe rendir el exámen complementario", "Cerrar");
            }
            else
            {
                DisplayAlert("Notificación", "Reprobo la Materia, su Nota Final es: " + notaF, "Cerrar");
            }
            }catch(Exception ex){
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }
    }
}
