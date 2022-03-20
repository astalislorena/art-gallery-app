using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVP.Presenter
{
    internal class ArtsPresenter
    {
        IVizArts Viz;
        ArtsPersistance ArtsPers;
        StaffPersistance StaffPers;

        public ArtsPresenter(IVizArts viz)
        {
            this.Viz = viz;
            this.ArtsPers = new ArtsPersistance();
            this.StaffPers = new StaffPersistance();
        }

        public void List()
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                arts.Add(item.Convert());
            }
            this.Viz.Arts = arts;
        }

        public void GetByTitle(string title)
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                if(item.Title.Contains(title))
                {
                    arts.Add(item.Convert());
                }
            }
            this.Viz.Arts = arts;
        }

        public void GetByArtist(string artistName)
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                if (item.ArtistName.Contains(artistName))
                {
                    arts.Add(item.Convert());
                }
            }
            this.Viz.Arts = arts;
        }


        public void GetByYear(int year)
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<string[]> arts = new List<string[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                if (item.Year == year)
                {
                    arts.Add(item.Convert());
                }
            }
            this.Viz.Arts = arts;
        }

        public bool GetUser(string email, string password)
        {
            if (StaffPers.GetStaff() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return false;
            }
            foreach (var item in StaffPers.GetStaff())
            {
                if (item.Email == email && item.Password == password)
                {
                    return true;
                }
            }
            MessageBox.Show("This user does not exists.");
            return false;
        }

        public void ListPaintings()
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                if(item.GetType() == typeof(Painting))
                {
                    arts.Add(item.Convert());
                }
                
            }
            this.Viz.Arts = arts;
        }

        public void ListSculptures()
        {
            if (ArtsPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in ArtsPers.GetArts())
            {
                if (item.GetType() == typeof(Sculpture))
                {
                    arts.Add(item.Convert());
                }

            }
            this.Viz.Arts = arts;
        }

    }
}
