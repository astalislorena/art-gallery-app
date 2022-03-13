using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVP.View.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVP.Presenter
{
    internal class StaffPresenter
    {
        IVizStaff viz;
        StaffPersistance pers;

        public StaffPresenter(IVizStaff viz)
        {
            this.viz = viz;
            this.pers = new StaffPersistance();
        }

        public void List()
        {
            if (pers.GetStaff() == null)
            {
                MessageBox.Show("Couldn't load staff.");
                return;
            }
            List<string[]> staff = new List<string[]>();
            foreach (var item in pers.GetStaff())
            {
                staff.Add(item.Convert());
            }
            this.viz.Staff = staff;
        }

        public void Save()
        {
            pers.SaveToXMLFile();
        }

        public void GetByName(string firstName, string lastName)
        {
            if (pers.GetStaff() == null)
            {
                MessageBox.Show("Couldn't load staff.");
                return;
            }
            List<string[]> staff = new List<string[]>();
            foreach (var item in pers.GetStaff())
            {
                if ((firstName != "" && item.FirstName.Contains(firstName)) || (lastName != "" && item.LastName.Contains(lastName)))
                {
                    staff.Add(item.Convert());
                }
            }
            this.viz.Staff = staff;
        }

        public bool GetByEmail(string email, bool populate)
        {
            if (pers.GetStaff() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return false;
            }
            List<string[]> staff = new List<string[]>();
            foreach (var item in pers.GetStaff())
            {
                if (item.Email == email)
                {
                    staff.Add(item.Convert());
                    if(populate)
                    {
                        this.viz.FirstName = item.FirstName;
                        this.viz.LastName = item.LastName;
                        this.viz.Email = item.Email;
                        this.viz.Password = item.Password;
                    }
                    this.viz.Staff = staff;
                    return true;
                }
            }
            return false;

        }


        public bool GetUser(string email, string password)
        {
            if (pers.GetStaff() == null)
            {
                MessageBox.Show("Couldn't load arts.");
                return false;
            }
            foreach (var item in pers.GetStaff())
            {
                if (item.Email == email && item.Password == password)
                {
                    return true;
                }
            }
            MessageBox.Show("This user does not exists.");
            return false;
        }

        public void AddUser(User user)
        {
            pers.AddUser(user);
            pers.SaveToXMLFile();
        }

        public void UpdateUser(User user)
        {
            pers.UpdateUser(user);
            pers.SaveToXMLFile();
        }

        public void DeleteUser(User user)
        {
            pers.DeleteUser(user);
            pers.SaveToXMLFile();
        }

    }
}
