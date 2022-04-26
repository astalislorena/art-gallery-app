using ArtGallery_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model
{
    public class UsersModel : Users
    {

        public Users User { get; set; }

        public UsersModel()
        {
            this.observedList = new List<Observer>();
        }
    }
}
