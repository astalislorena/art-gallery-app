using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    public class Art
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }

        public Art()
        {
            Title = "";
            ArtistName = "";
            Year = 0;
        }

        public Art(string title, string artistName, int year)
        {
            this.Title = title;
            this.ArtistName = artistName;
            this.Year = year;
        }


        public string[] Convert()
        {
            string[] result = new string[4];
            result[0] = this.Title;
            result[1] = this.ArtistName;
            result[2] = this.Year.ToString();
            result[3] = "-";
            return result;
        }
    }
}
