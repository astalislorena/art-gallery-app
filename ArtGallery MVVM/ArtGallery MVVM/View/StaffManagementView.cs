using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.ViewModel.StaffManagement;
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

namespace ArtGallery_MVVM.View
{
    public partial class StaffManagementView : Form
    {
        readonly StaffManagementViewModel _viewModel;
        public StaffManagementView()
        {
            InitializeComponent();
            _viewModel = new StaffManagementViewModel();
            _viewModel.staffDataGridView = this.staffDataGridView;
            this.saveButton.Click += delegate { _viewModel.Save.Execute(); };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ArtGalleryDbContext.instance.Users.Load();
            this.userBindingSource.DataSource = ArtGalleryDbContext.instance.Users.Local.ToBindingList();
        }
    }
}
