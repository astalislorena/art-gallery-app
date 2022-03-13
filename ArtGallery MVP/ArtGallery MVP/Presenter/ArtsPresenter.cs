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
        IVizArts viz;
        ArtsPersistance pers;

        public ArtsPresenter(IVizArts viz)
        {
            this.viz = viz;
            this.pers = new ArtsPersistance();
        }

        public void List()
        {
            if (pers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in pers.GetArts())
            {
                arts.Add(item.Convert());
            }
            this.viz.Arts = arts;
        }

        public void Save()
        {
            pers.SaveArtsToXMLFile();
        }

        public void GetByTitle(string title)
        {
            if (pers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in pers.GetArts())
            {
                if(item.Title.Contains(title))
                {
                    arts.Add(item.Convert());
                }
            }
            this.viz.Arts = arts;
        }

        public void GetByArtist(string artistName)
        {
            if (pers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in pers.GetArts())
            {
                if (item.ArtistName.Contains(artistName))
                {
                    arts.Add(item.Convert());
                }
            }
            this.viz.Arts = arts;
        }


        public void GetByYear(int year)
        {
            if (pers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return;
            }
            List<string[]> arts = new List<string[]>();
            foreach (var item in pers.GetArts())
            {
                if (item.Year == year)
                {
                    arts.Add(item.Convert());
                }
            }
            this.viz.Arts = arts;
        }

    }
}
