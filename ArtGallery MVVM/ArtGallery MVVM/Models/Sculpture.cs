using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    public class Sculpture : Art
    {
        public string Type { get; set; } = "unknown";

        public Sculpture()
        {
            this.Type = "unknown";
        }  

        public Sculpture(String title, String artistName, int year, string type) : base(title, artistName, year)
        {
            this.Type = type;
        }

        public override string[] Convert()
        {
            string[] result = new string[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year < 0 ? (-this.Year).ToString() + " BC" : this.Year.ToString();
            result[3] = this.Type;
            return result;
        }
    }
}
