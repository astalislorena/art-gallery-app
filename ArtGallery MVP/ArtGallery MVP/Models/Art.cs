using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    public abstract class Art
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


        public abstract string[] Convert();
    }
}
