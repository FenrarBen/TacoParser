namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Point Set(double lat, double lon)
        {
            this.Longitude = lon;
            this.Latitude = lat;

            return this;
        }
    }
}