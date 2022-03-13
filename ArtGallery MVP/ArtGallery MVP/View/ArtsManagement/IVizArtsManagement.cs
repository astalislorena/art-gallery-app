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
        List<string[]> Arts { set; }
        string Selected { get; }

    }
}
