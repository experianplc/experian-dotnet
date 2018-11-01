namespace Experian.Api.Client.Bis
{
    public sealed class BusinessGeocodeResult
    {
        public string LatitudeLongitudeLevel { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public string MsaCode { get; set; }

        public string CensusBlkGrpCode { get; set; }

        public string CensusTractCode { get; set; }

        public bool CottageIndicator { get; set; }

        public string CongressionalDistrictCode { get; set; }

        public string DateLastReported { get; set; }
    }
}
