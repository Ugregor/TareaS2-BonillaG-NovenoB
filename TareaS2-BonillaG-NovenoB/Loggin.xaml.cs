using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS2_BonillaG_NovenoB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Loggin : ContentPage
{
    public Loggin()
    {
        InitializeComponent();
    }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
        try
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            if(usuario == "GregoryB" && password == "uisrael2022")
            {
                await Navigation.PushAsync(new MainPage(usuario, password));
            }
            else if(String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(password))
            {
                await DisplayAlert("Alerta", "Complete los campos", "Cerrar");
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o Contraseña incorrecto", "Cerrar");
            }
        }catch(Exception ex){
                await DisplayAlert("ERROR", ex.Message, "Cerrar");
        }
}
    }
}