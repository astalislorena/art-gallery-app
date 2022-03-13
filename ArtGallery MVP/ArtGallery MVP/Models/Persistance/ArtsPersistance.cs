using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ArtGallery_MVP.Models.Persistance
{
    internal class ArtsPersistance
    {
        private List<Art> arts;

        public ArtsPersistance()
        {
            this.ReadFromXMLFile();
        }

        public void ReadFromXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Arts.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Art>));
                    var cast = xs.Deserialize(fs);
                    this.arts = (List<Art>) cast;
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void SaveArtsToXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Arts.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Art>));
                    xs.Serialize(fs, this.arts);
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

        public List<Art> GetArts()
        {
            return this.arts;
        }
    }
}
