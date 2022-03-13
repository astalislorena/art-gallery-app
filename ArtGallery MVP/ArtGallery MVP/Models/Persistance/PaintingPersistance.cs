using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ArtGallery_MVP.Models.Persistance
{
    internal class PaintingPersistance
    {

        private List<Painting> Arts;

        public PaintingPersistance()
        {
            this.ReadFromXMLFile();
        }

        public void ReadFromXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Paintings.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Painting>));
                    var cast = xs.Deserialize(fs);
                    this.Arts = (List<Painting>)cast;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void SaveArtsToXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Paintings.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Painting>));
                    xs.Serialize(fs, this.Arts);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public List<Painting> GetArts()
        {
            return this.Arts;
        }

        public void AddPainting(Painting painting)
        {
            this.Arts.Add(painting);
        }

        public void DeletePainting(Painting painting)
        {
            Painting? toDelete = null;
            foreach (var item in this.Arts)
            {
                if (item.Title == painting.Title)
                {
                    toDelete = item;
                }
            }
            if (toDelete != null)
            {
                this.Arts.Remove(toDelete);
            }
        }


        public void UpdatePainting(Painting painting)
        {
            foreach (var item in this.Arts)
            {
                if (item.Title == painting.Title)
                {
                    item.ArtistName = painting.ArtistName;
                    item.Year = painting.Year;
                    item.Type = painting.Type;
                    item.Technique = painting.Technique;
                }
            }
        }
    }
}
