using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSignalR
{
    public class Layer
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public string Format { get; set; }
        public string TileMatrixSetID { get; set; }
        public string[] TileMatrixLabels { get; set; }
        public string MaximumLevel { get; set; }
        public string Credit { get; set; }
    }
}
