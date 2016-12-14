using System;

namespace DXClusterMonitor
{
    public class Spot
    {
        public int?    spotUniqueNumber { get; set; }
        public string  reportedBy { get; set; }
        public float?   dxFrequency { get; set; }
        public class singleDXCallsign
        {
            public string dxCallsign { get; set; }
            public string dxPrefix { get; set; }
            public string dxCountryName { get; set; }
            public string dxCQZone { get; set; }
            public string dxITUZone { get; set; }
            public string dxContinent { get; set; }
            public string dxLattitude { get; set; }
            public string dxLongitude { get; set; }
        }
        
        public string   reporterComment { get; set; }
        

        //  Example spot from JSON https://www.dxcluster.co.uk/index.php?/api/all  
        //  {"nr":"16862518","call":"N7EKD","freq":"7165","dxcall":"YC3DY","comment":"= CQ DX = strong w cost",
        //  "time":"2016-12-14 14:38:00","band":"40","dx_prefix":"YC","dx_name":"INDONESIA","dx_cqz":"28","dx_ituz":"0",
        //  "dx_cont":"OC","dx_long":"106.8","dx_lat":"-6.2","spotter_prefix":"N",
        //  "spotter_name":"UNITED STATES OF AMERICA","spotter_cqz":"5","spotter_ituz":"0",
        //  "spotter_cont":"NA","spotter_long":"-87.9","spotter_lat":"43","mytime":"14\/12\/16 at 14:38"}

    }
}