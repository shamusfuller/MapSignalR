using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSignalR
{
    public class Map
    {
        public Extent Extents { get; set; }
        public IEnumerable<Layer> Layers { get; set; }
        public string Name { get; set; }
    }
}
