using ArtGallery_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model
{
    public class ArtsModel : Arts
    {
        public Art Art { get; set; }
        public string SearchInfo { get; set; }

        public ArtsModel()
        {
            this.observedList = new List<Observer>();
        }
    }
}
