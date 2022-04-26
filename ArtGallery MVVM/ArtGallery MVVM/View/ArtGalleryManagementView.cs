using ArtGallery_MVC.Model.Persistance;
using ArtGallery_MVC.Controller;
using ArtGallery_MVC.Model;
using ArtGallery_MVC.View;
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
using System.Windows.Forms.DataVisualization.Charting;
using ArtGallery_MVC.Model;

namespace ArtGallery_MVC
{
    public partial class ArtGalleryManagementView : Form, Observer
    {
        public ArtsModel arts { get; set; }
        public ArtsController controller { get; set; }
        public ArtGalleryManagementView(ArtsModel arts)
        {
            InitializeComponent();
            this.arts = arts;
            this.controller = new ArtsController(this);
            this.arts.Add(this);
            this.arts.Add(this.controller);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ArtGalleryDbContext.instance.Paintings.Load();
            ArtGalleryDbContext.instance.Sculptures.Load();
            ArtGalleryDbContext.instance.Institutions.Load();
            this.paintingBindingSource.DataSource = ArtGalleryDbContext.instance.Paintings.Local.ToBindingList();
            this.sculptureBindingSource.DataSource = ArtGalleryDbContext.instance.Sculptures.Local.ToBindingList();
            this.institutionBindingSource.DataSource = ArtGalleryDbContext.instance.Institutions.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ArtGalleryDbContext.instance.Dispose();
        }

        public BindingSource GetPaintingBindingSearch()
        {
            return this.paintingBindingSource;
        }

        public BindingSource GetSculptureBindingSource()
        {
            return this.sculptureBindingSource;
        }

        public BindingSource GetInstitutionBindingSource()
        {
            return this.institutionBindingSource;
        }

        public Button GetSaveButton()
        {
            return this.saveButton;
        }

        public Button GetShowAllPaintingsButton()
        {
            return this.showAllPaintingsButton;
        }

        public Button GetShowAllSculpturesButton()
        {
            return this.showAllSculpturesButton;
        }

        public Button GetLoginButton()
        {
            return this.loginButton;
        }

        public Button GetSearchPaintingsButton()
        {
            return this.searchPaintingsButton;
        }

        public Button GetSearchSculpturesButton()
        {
            return this.searchSculpturesButton;
        }

        public Button GetAddPaintingToInstitutionButton()
        {
            return this.addPaintingButton;
        }

        public Button GetAddSculptureToInstitutionButton()
        {
            return this.addSculptureButton;
        }

        public Button GetShowStatisticButton()
        {
            return this.showStatisticButton;
        }

        public Button GetInstitutionStatisticButton()
        {
            return this.buttonGenerateInstitutionChart;
        }

        public DataGridView GetPaintingDataGridView()
        {
            return this.paintingDataGridView;
        }

        public DataGridView GetSculptureDataGridView()
        {
            return this.sculptureDataGridView;
        }

        public DataGridView GetInstitutionDataGridView()
        {
            return this.institutionDataGridView;
        }

        public Chart GetChart()
        {
            return this.artsChart;
        }

        public Chart GetInstitutionChart()
        {
            return this.institutionChart;
        }

        public string SearchPaintings 
        {   get
            {
                return searchPaintingsTextField.Text;
            }
        }

        public string SearchSculptures
        {
            get
            {
                return searchSculpturesTextField.Text;
            }
        }

        public string InstitutionId
        {
            get
            {
                return numericUpDownInstututionId.Text;
            }
        }

        public string PaintingId
        {
            get
            {
                return numericUpDownPaintingId.Text;
            }
        }

        public string SculptureId
        {
            get
            {
                return numericUpDownSculptureId.Text;
            }
        }

        public string Email
        {
            get
            {
                return emailTextField.Text;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextField.Text;
            }
        }
        public string InstitutionIdChart
        {
            get
            {
                return numericUpDownInstitutionIdChart.Text;
            }
        }
    }
}
