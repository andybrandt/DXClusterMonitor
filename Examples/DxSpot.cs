namespace Examples

// gdybys potrzebowa³ wygenerowaæ obiekty do jsona to to mo¿e byæ przyadatne
// http://json2csharp.com/
// wklejasz jsona i generuje ci odpowiedni¹ klasê w c#
{
    public class DxSpot
    {
        public string nr { get; set; }
        public string call { get; set; }
        public string freq { get; set; }
        public string dxcall { get; set; }
        public string comment { get; set; }
        public string time { get; set; }
        public string band { get; set; }
        public string dx_prefix { get; set; }
        public string dx_name { get; set; }
        public string dx_cqz { get; set; }
        public string dx_ituz { get; set; }
        public string dx_cont { get; set; }
        public string dx_long { get; set; }
        public string dx_lat { get; set; }
        public string spotter_prefix { get; set; }
        public string spotter_name { get; set; }
        public string spotter_cqz { get; set; }
        public string spotter_ituz { get; set; }
        public string spotter_cont { get; set; }
        public string spotter_long { get; set; }
        public string spotter_lat { get; set; }
        public string mytime { get; set; }
    }
}