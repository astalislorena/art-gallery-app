using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    public class Painting : Art
    {
        public string Type { get; set;  } = "unknown";
        public string Technique { get; set; } = "unknown";

        public Painting()
        {
            this.Technique = "unknown";
            this.Type = "unknown"; 
        }

        public Painting(String title, String artistName, int year, string type, string technique):base(title,artistName,year)
        {
            this.Title = title;
            this.ArtistName = artistName;
            this.Year = year;
            this.Type = type;
            this.Technique = technique;
        }

        public override String[] Convert()
        {
            String[] result = new String[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year  < 0 ? (-this.Year).ToString() + " BC" : this.Year.ToString();
            result[3] = this.Type + " - " + this.Technique;
            return result;
        }
    }
}
