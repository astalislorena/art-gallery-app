using ArtGallery_MVC.Controller;
using ArtGallery_MVC.Model;
using ArtGallery_MVC.Model.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVC.View
{
    public partial class StaffManagementView : Form, Observer
    {

        public UsersModel users { get; set; }
        public StaffController controller { get; set; }

        public StaffManagementView(UsersModel users)
        {
            InitializeComponent();
            this.users = users;
            this.controller = new StaffController(this);
            this.users.Add(this);
            this.users.Add(this.controller);
        }

        public Button GetSaveButton()
        {
            return this.saveButton;
        }

        public DataGridView GetUsersDataGrid()
        {
            return this.staffDataGridView;
        }

        public BindingSource GetUsersBindingSource()
        {
            return this.userBindingSource;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ArtGalleryDbContext.instance.Users.Load();
            this.userBindingSource.DataSource = ArtGalleryDbContext.instance.Users.Local.ToBindingList();
        }
    }
}
