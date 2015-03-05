using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSignalR
{
    public class Layer
    {
                //    var shadedRelief1 = new Cesium.WebMapTileServiceImageryProvider({
                //url: 'http://basemap.nationalmap.gov/arcgis/rest/services/USGSImageryOnly/MapServer/WMTS/',
                //layer: 'USGSShadedReliefOnly',
                //style: 'default',
                //format: 'image/jpeg',
                //tileMatrixSetID: 'default028mm',
                //// tileMatrixLabels : ['default028mm:0', 'default028mm:1', 'default028mm:2' ...],
                //maximumLevel: 19,
                //credit: new Cesium.Credit('U. S. Geological Survey')
        public string Url { get; set; }
        public string LayerName { get; set; }
        public string Style { get; set; }
        public string Format { get; set; }
        public string TileMatrixSetID { get; set; }
        //public string[] TileMatrixLabels { get; set; }
        public string MaximumLevel { get; set; }
        public string Credit { get; set; }
        

    }
}
