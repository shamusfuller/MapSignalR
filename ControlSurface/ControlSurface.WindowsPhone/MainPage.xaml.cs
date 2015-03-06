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

            this.NavigationCacheMode = NavigationCacheMode.Required;

            hubProxy = hubConnection.CreateHubProxy("MapHub");
            hubConnection.Start().Wait();
            viewer.Navigate(new Uri("http://localhost:3443/cesium.html"));

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
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
