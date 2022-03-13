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
    internal class StaffPersistance
    {
        private List<User> Staff;

        public StaffPersistance()
        {
            this.ReadFromXMLFile();
        }

        public void ReadFromXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Staff.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                    var cast = xs.Deserialize(fs);
                    this.Staff = (List<User>)cast;
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

        public void SaveToXMLFile()
        {
            try
            {
                FileStream fs = new FileStream("../../../Staff.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                    xs.Serialize(fs, this.Staff);
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

        public List<User> GetStaff()
        {
            return this.Staff;
        }

        public void AddUser(User user)
        {
            this.Staff.Add(user);
        }

        public void UpdateUser(User user)
        {
            foreach(var item in this.Staff)
            {
                if (item.Email == user.Email)
                {
                    item.LastName = user.LastName;
                    item.FirstName = user.FirstName;
                    item.Password = user.Password;
                }
            }
        }
        public void DeleteUser(User user)
        {
            User? toDelete = null;
            foreach (var item in this.Staff)
            {
                if (item.Email == user.Email)
                {
                    toDelete = item;
                }
            }
            if (toDelete != null)
            {
                this.Staff.Remove(toDelete);
            }
        }
    }
}
