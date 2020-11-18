using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }

        public TacoBell(double lat, double lon, string loc)
        {
            this.Name = loc;
            Location = Location.Set(lat, lon);
            
        }
    }
}
