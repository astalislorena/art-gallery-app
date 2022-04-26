using ArtGallery_MVC.Model;
using ArtGallery_MVC.Model.Persistance;
using ArtGallery_MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Controller
{
    public class StaffController : Observer
    {
        public UsersModel users;
        public StaffManagementView view { get; set; }

        public StaffController(StaffManagementView view)
        {
            this.view = view;
            users = view.users;
            this.HandleEvents();
        }

        public void HandleEvents()
        {
            view.GetSaveButton().Click += new EventHandler(SaveUsers);
        }

        void SaveUsers(object sender, EventArgs e)
        {
            ArtGalleryDbContext.instance.SaveChanges();
            this.view.GetUsersDataGrid().Refresh();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
