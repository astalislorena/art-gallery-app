using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    internal class Sculpture : Art
    {
        private SculptureType type;

        public Sculpture(String title, String artistName, int year, SculptureType type) : base(title, artistName, year)
        {
            this.type = type;
        }

        public SculptureType GetType()
        {
            return this.type;
        }

        public void SetType(SculptureType type)
        {
            this.type = type;
        }

        public String[] Convert()
        {
            String[] result = new String[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year.ToString();
            result[3] = this.type.ToString();
            return result;
        }
    }
}
