using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.View
{
    internal interface IVizArts
    {
        String Title { get; set; }
        String ArtistName { get; set; }
        List<String[]> Arts { set; }
        String Selected { get; }
    }
}
