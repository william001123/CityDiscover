using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace CityDiscoverMovil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicación",
                Address = "Prueba",
                Position = new Position(6.25184, -75.56359),
                Tag = "id_miubi"
            };

            map.Pins.Add(MiUbi);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(500)));

        }

        async void Adicionar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Detalle());
        }
    }
}