using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSignalR
{
    public class MapHub : Hub
    {
        public async Task Test()
        {
            await Clients.All.test();
        }
        public async Task LoadLayer(Layer layer)
        {
            await Clients.All.loadLayer(layer); 
        }
    }
}
