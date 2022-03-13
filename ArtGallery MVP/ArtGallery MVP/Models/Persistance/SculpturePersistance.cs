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
    internal class SculpturePersistance
    {
        private List<Sculpture> Arts;

        public SculpturePersistance()
        {
            this.ReadFromXMLFile();
        }

        public void ReadFromXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Sculptures.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Sculpture>));
                    var cast = xs.Deserialize(fs);
                    this.Arts = (List<Sculpture>)cast;
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
                FileStream fs = new FileStream("../../../Sculptures.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Sculpture>));
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

        public List<Sculpture> GetArts()
        {
            return this.Arts;
        }

        public void AddSculpture(Sculpture sculpture)
        {
            this.Arts.Add(sculpture);
        }

        public void DeleteSculpture(Sculpture sculpture)
        {
            Sculpture? toDelete = null;
            foreach (var item in this.Arts)
            {
                if (item.Title == sculpture.Title)
                {
                    toDelete = item;
                }
            }
            if (toDelete != null)
            {
                this.Arts.Remove(toDelete);
            }
        }


        public void UpdateSculpture(Sculpture sculpture)
        {
            foreach (var item in this.Arts)
            {
                if (item.Title == sculpture.Title)
                {
                    item.ArtistName = sculpture.ArtistName;
                    item.Year = sculpture.Year;
                    item.Type = sculpture.Type;
                }
            }
        }
    }
}
