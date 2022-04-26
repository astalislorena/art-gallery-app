using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model
{
    [Table("sculpture")]
    public class Sculpture : Art
    {
        public string Type { get; set; } = "Unknown";

        public Sculpture() : base()
        {
            this.Type = "Unknown";
        }

        public Sculpture(string title, string artistName, int year, string type) : base(title, artistName, year)
        {
            this.Type = type;
        }

        public override string[] Convert()
        {
            string[] result = new string[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year < 0 ? (-this.Year).ToString() + " BC" : this.Year.ToString();
            result[3] = this.Type.ToString();
            return result;
        }
    }
}
