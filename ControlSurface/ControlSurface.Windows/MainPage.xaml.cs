using MapSignalR;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlSurface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        HubConnection hubConnection = new HubConnection("http://localhost:3443/");
        IHubProxy hubProxy;

        public MainPage()
        {
            this.InitializeComponent();
            hubProxy = hubConnection.CreateHubProxy("MapHub");
            hubConnection.Start().Wait();
            viewer.Navigate(new Uri("http://localhost:3443/cesium.html"));
        }

        private async void load_Click(object sender, RoutedEventArgs e)
        {
            Layer layer = new Layer
            {
                Credit = "U. S. Geological Survey",
                Format = "image/jpeg",
                MaximumLevel = "19",
                Name = "USGSShadedReliefOnly",
                Style = "default",
                TileMatrixLabels = null,
                TileMatrixSetID = "default028mm",
                Url = "http://basemap.nationalmap.gov/arcgis/rest/services/USGSImageryOnly/MapServer/WMTS/"
            };
            await hubProxy.Invoke("LoadLayer", layer);
        }
    }
}
