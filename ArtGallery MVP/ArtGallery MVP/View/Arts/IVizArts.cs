using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.View
{
    internal interface IVizArts
    {
        string Title { get; set; }
        string ArtistName { get; set; }

        int Year { get; set; }
        List<string[]> Arts { set; }
        string Selected { get; }
    }
}
