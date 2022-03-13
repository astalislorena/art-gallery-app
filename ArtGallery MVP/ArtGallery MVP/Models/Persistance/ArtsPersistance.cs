using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                FileStream fs1 = new FileStream("../../../Paintings.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                FileStream fs2 = new FileStream("../../../Sculptures.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs1 = new XmlSerializer(typeof(List<Painting>));
                    var cast1 = xs1.Deserialize(fs1);
                    List<Art> a = ((List<Painting>) cast1).Cast<Art>().ToList();
                    XmlSerializer xs2 = new XmlSerializer(typeof(List<Sculpture>));
                    var cast2 = xs2.Deserialize(fs2);
                    List<Art> b = ((List<Sculpture>) cast2).Cast<Art>().ToList();
                    a.AddRange(b);
                    this.arts = a;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                finally
                {
                    fs1.Close();
                    fs2.Close();
                }
            } 
            catch(Exception ex)
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
