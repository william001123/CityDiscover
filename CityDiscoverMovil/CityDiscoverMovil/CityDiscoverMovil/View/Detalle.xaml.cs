using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityDiscoverMovil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle : ContentPage
    {

        public string FileName { get; set; }

        public Detalle()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void OnSelectFileButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Utilizar Xamarin.Essentials para seleccionar un archivo
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    FileTypes = FilePickerFileType.Images, // Puedes ajustar los tipos de archivo permitidos
                });

                if (result != null)
                {
                    // Obtener el nombre del archivo seleccionado
                    FileName = Path.GetFileName(result.FileName);

                    // Puedes realizar acciones adicionales, como subir el archivo a un servidor
                    // Puedes utilizar 'result.OpenReadAsync()' para acceder a los datos del archivo

                    // Actualizar la interfaz de usuario para mostrar el nombre del archivo
                    OnPropertyChanged(nameof(FileName));
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la selección del archivo
                Console.WriteLine($"Error al seleccionar el archivo: {ex.Message}");
            }
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}