using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace ArtGallery_MVP.Models
{
    [Table("painting")]
    public class Painting : Art
    {
        public string Type { get; set;  } = "Unknown";
        public string Technique { get; set; } = "Unknown";

        public Painting() : base()
        {
            this.Technique = "Unknown";
            this.Type = "Unknown";
        }

        public Painting(string title, string artistName, int year, string type, string technique) : base(title,artistName,year)
        { 
            this.Type = type;
            this.Technique = technique;
        }

        public override string[] Convert()
        {
            string[] result = new string[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year  < 0 ? (-this.Year).ToString() + " BC" : this.Year.ToString();
            result[3] = this.Type.ToString() + " - " + this.Technique.ToString();
            return result;
        }
    }
}
