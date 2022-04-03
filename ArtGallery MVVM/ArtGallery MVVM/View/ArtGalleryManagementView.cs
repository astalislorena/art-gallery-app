using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.View;
using ArtGallery_MVVM.ViewModel;
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
    public partial class ArtGalleryManagementView : Form
    {
        private ArtGalleryManagementViewModel viewModel;
        public ArtGalleryManagementView()
        {
            InitializeComponent();
            this.viewModel = new ArtGalleryManagementViewModel();
            this.AddViewComponentsToViewModel();
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

        private void AddViewComponentsToViewModel()
        {
            this.viewModel.paintingBindingSource = this.paintingBindingSource;
            this.viewModel.sculptureBindingSource = this.sculptureBindingSource;
            this.viewModel.institutionBindingSource = this.institutionBindingSource;
            this.saveButton.Click += delegate { viewModel.SaveCommand.Execute(); };
            this.viewModel.saveButton = this.saveButton;
            this.loginButton.Click += delegate { viewModel.LoginCommand.Execute(); };
            this.viewModel.loginButton = this.loginButton;
            this.searchPaintingsButton.Click += delegate { viewModel.SearchPaintingsCommand.Execute(); };
            this.searchSculpturesButton.Click += delegate {  viewModel.SearchSculpturessCommand.Execute(); };
            this.addPaintingButton.Click += delegate {  viewModel.AddPaintingToInstitutionCommand.Execute(); };
            this.viewModel.addPaintingToInstitutionButton = this.addPaintingButton;
            this.addSculptureButton.Click += delegate { viewModel.AddSculptureToInstitutionCommand.Execute(); };
            this.viewModel.addSculptureToInstitutionButton = this.addSculptureButton;
            this.viewModel.sculptureDataGridView = this.sculptureDataGridView;
            this.viewModel.paintingDataGridView = this.paintingDataGridView;
            this.viewModel.institutionDataGridView = this.institutionDataGridView;
            this.showStatisticButton.Click += delegate { viewModel.ShowStatisticsCommand.Execute(); };
            this.showAllPaintingsButton.Click += delegate { viewModel.ShowAllArtsCommand.Execute(); };
            this.showAllSculpturesButton.Click += delegate { viewModel.ShowAllArtsCommand.Execute(); };
            this.viewModel.showStatisticButton = this.showStatisticButton;
            this.emailTextField.DataBindings.Add("Text", this.viewModel, "UserEmail", false, DataSourceUpdateMode.OnValidation);
            this.passwordTextField.DataBindings.Add("Text", this.viewModel, "UserPassword", false, DataSourceUpdateMode.OnValidation);
            this.searchPaintingsTextField.DataBindings.Add("Text", this.viewModel, "SearchPaintings", false, DataSourceUpdateMode.OnValidation);
            this.searchSculpturesTextField.DataBindings.Add("Text", this.viewModel, "SearchSculptures", false, DataSourceUpdateMode.OnValidation);
            this.numericUpDownInstututionId.DataBindings.Add("Text", this.viewModel, "InstitutionId", false, DataSourceUpdateMode.OnValidation);
            this.numericUpDownPaintingId.DataBindings.Add("Text", this.viewModel, "PaintingId", false, DataSourceUpdateMode.OnValidation);
            this.numericUpDownSculptureId.DataBindings.Add("Text", this.viewModel, "SculptureId", false, DataSourceUpdateMode.OnValidation);
        }

    }
}
