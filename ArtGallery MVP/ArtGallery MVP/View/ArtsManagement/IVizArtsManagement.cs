using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.View.ArtsManagement
{
    internal interface IVizArtsManagement
    {
        string Title { get; set; }
        string ArtistName { get; set; }
        string Technique { get; set; }
        int Year { get; set; }
        string Type { get; set; }
        List<string[]> Paintings { set; }
        List<string[]> Sculptures { set; }
        string Selected { get; }

    }
}
