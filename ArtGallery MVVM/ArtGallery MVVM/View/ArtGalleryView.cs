using ArtGallery_MVP.Models.Persistance;
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

namespace ArtGallery_MVVM
{
    public partial class ArtGalleryView : Form
    {
        ArtGalleryDbContext dbContext;
        
        public ArtGalleryView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new ArtGalleryDbContext();
            dbContext.Paintings.Load();
            dbContext.Sculptures.Load();
            this.paintingBindingSource.DataSource = dbContext.Paintings.Local.ToBindingList();
            this.sculptureBindingSource.DataSource = dbContext.Sculptures.Local.ToBindingList();
        }

        private void paintingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.dbContext.SaveChanges();
            this.paintingDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.dbContext.SaveChanges();
            this.paintingDataGridView.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            this.paintingDataGridView.Refresh();
        }

        private void saveSculptures_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            this.sculptureDataGridView.Refresh();
        }

        private void sculptureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.dbContext.SaveChanges();
            this.sculptureDataGridView.Refresh();
        }
    }
}
