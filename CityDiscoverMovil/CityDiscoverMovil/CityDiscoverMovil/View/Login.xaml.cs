using CityDiscoverMovil.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityDiscoverMovil.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Realizar la solicitud a la API para obtener el token JWT
            string token = await clsAutenticacionServ.GetAuthToken(username, password);

            if (!string.IsNullOrEmpty(token))
            {
                // Almacenar el token JWT en la aplicación
                App.Current.Properties["Token"] = token;
                await App.Current.SavePropertiesAsync();

                // Redirigir al usuario a la página principal
                await Navigation.PushAsync(new Map());
            }
            else
            {
                // Mostrar un mensaje de error
                await DisplayAlert("Error", "Inicio de sesión fallido. Verifique sus credenciales.", "OK");
            }
        }

    }
}