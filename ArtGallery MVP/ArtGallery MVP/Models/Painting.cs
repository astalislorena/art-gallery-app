using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    internal class Painting : Art
    {
        private PaintingType Type { get; set;  } = PaintingType.Unknown;
        private TechniqueType Technique { get; set; } = TechniqueType.Unknown;

        public Painting(String title, String artistName, int year, PaintingType type, TechniqueType technique):base(title,artistName,year)
        {
            this.Title = title;
            this.ArtistName = artistName;
            this.Year = year;
            this.Type = type;
            this.Technique = technique;
        }

        public String[] Convert()
        {
            String[] result = new String[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year.ToString();
            result[3] = this.Type.ToString() + " " + this.Technique.ToString();
            return result;
        }
    }
}
