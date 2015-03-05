using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSignalR
{
    public class MapHub: Hub
    {
        public async Task Test()
        {
            //await Task.Delay(0);
            await Clients.All.test(); // this call has different signature than this.Test
        }
    }
}
