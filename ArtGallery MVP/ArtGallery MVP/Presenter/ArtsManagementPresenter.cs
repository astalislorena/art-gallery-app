using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVP.View.ArtsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVP.Presenter
{
    internal class ArtsManagementPresenter
    {
        IVizArtsManagement Viz;
        PaintingPersistance PaintingPers;
        SculpturePersistance SculpturePers;

        public ArtsManagementPresenter(IVizArtsManagement viz)
        {
            this.Viz = viz;
            this.PaintingPers = new PaintingPersistance();
            this.SculpturePers = new SculpturePersistance();
        }

        public void ListPaintings()
        {
            if (PaintingPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load paintings.");
                return;
            }
            List<string[]> arts = new List<string[]>();
            foreach (var item in PaintingPers.GetArts())
            {
                arts.Add(item.Convert());
            }
            this.Viz.Paintings = arts;
        }

        public void ListSculptures()
        {
            if (PaintingPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load sculptures.");
                return;
            }
            List<string[]> arts = new List<string[]>();
            foreach (var item in SculpturePers.GetArts())
            {
                arts.Add(item.Convert());
            }
            this.Viz.Sculptures = arts;
        }

        public void SavePaintings()
        {
            PaintingPers.SaveArtsToXMLFile();
        }

        public void SaveSculptures()
        {
            SculpturePers.SaveArtsToXMLFile();
        }

        public bool GetPaintingsByTitle(string title, bool populate)
        {
            if (PaintingPers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load paitings.");
                return false;
            }
            List<String[]> arts = new List<String[]>();
            foreach (var item in PaintingPers.GetArts())
            {
                if (item.Title.Contains(title))
                {
                    arts.Add(item.Convert());
                    if (populate)
                    {
                        Viz.Title = item.Title;
                        Viz.ArtistName = item.ArtistName;
                        Viz.Year = item.Year;
                        Viz.Type = item.Type;
                        Viz.Technique = item.Technique;
                        this.Viz.Paintings = arts;
                        return true;
                    }
                }
            }
            this.Viz.Paintings = arts;
            return false;
        }

        public bool GetSculpturesByTitle(string title, bool populate)
        {
            if (SculpturePers.GetArts() == null)
            {
                MessageBox.Show("Couldn't load sculptures.");
                return false;
            }
            List<string[]> arts = new List<string[]>();
            foreach (var item in SculpturePers.GetArts())
            {
                if (item.Title.Contains(title))
                {
                    arts.Add(item.Convert());
                    if(populate)
                    {
                        Viz.Title = item.Title;
                        Viz.ArtistName = item.ArtistName;
                        Viz.Year = item.Year;
                        Viz.Type = item.Type;
                        this.Viz.Sculptures = arts;
                        return true;
                    }
                }
            }
            this.Viz.Sculptures = arts;
            return false;
        }

        public void Add(Painting painting)
        {
            PaintingPers.AddPainting(painting);
            PaintingPers.SaveArtsToXMLFile();
        }

        public void Add(Sculpture sculpture)
        {
            SculpturePers.AddSculpture(sculpture);
            SculpturePers.SaveArtsToXMLFile();
        }

        public void Update(Painting painting)
        {
            PaintingPers.UpdatePainting(painting);
            PaintingPers.SaveArtsToXMLFile();
        }

        public void Update(Sculpture sculpture)
        {
            SculpturePers.UpdateSculpture(sculpture);
            SculpturePers.SaveArtsToXMLFile();
        }

        public void Delete(Painting painting)
        {
            PaintingPers.DeletePainting(painting);
            PaintingPers.SaveArtsToXMLFile();
        }

        public void Delete(Sculpture sculpture)
        {
            SculpturePers.DeleteSculpture(sculpture);
            SculpturePers.SaveArtsToXMLFile();
        }

    }
}
