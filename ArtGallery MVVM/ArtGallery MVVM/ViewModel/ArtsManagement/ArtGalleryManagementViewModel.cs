using ArtGallery_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.ViewModel
{
    public class ArtGalleryManagementViewModel
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string InstitutionId { get; set; }
        public string PaintingId { get; set; }
        public string SculptureId { get; set; }
        public string SearchPaintings { get; set; }
        public string SearchSculptures  { get; set; }

        public BindingSource paintingBindingSource;
        public BindingSource sculptureBindingSource;
        public BindingSource institutionBindingSource;
        public DataGridView paintingDataGridView;
        public DataGridView sculptureDataGridView;
        public DataGridView institutionDataGridView;
        public Button saveButton;
        public Button loginButton;
        public Button showAllPaintingsButton;
        public Button showAllSculpturesButton;
        public Button searchPaintingsButton;
        public Button searchSculpturesButton;
        public Button addPaintingToInstitutionButton;
        public Button addSculptureToInstitutionButton;
        public Button showStatisticButton;


        public ICommand SaveCommand;
        public ICommand LoginCommand;
        public ICommand SearchPaintingsCommand;
        public ICommand SearchSculpturessCommand;
        public ICommand AddPaintingToInstitutionCommand;
        public ICommand AddSculptureToInstitutionCommand;
        public ICommand ShowStatisticsCommand;
        public ICommand ShowAllArtsCommand;

        public ArtGalleryManagementViewModel()
        {
            UserEmail = "";
            UserPassword = "";
            SearchPaintings = "";
            this.SaveCommand = new SaveArtsCommand(this);
            this.LoginCommand = new LoginCommand(this);
            this.SearchPaintingsCommand = new SearchPaintingsCommand(this);
            this.SearchSculpturessCommand = new SearchSculpturesCommand(this);
            this.AddPaintingToInstitutionCommand = new AddPaitingToInstitutionCommand(this);
            this.AddSculptureToInstitutionCommand = new AddSculptureToInstitutionCommand(this);
            this.ShowStatisticsCommand = new ShowStatisticsCommand(this);
            this.ShowAllArtsCommand = new ShowAllArtsCommand(this);
        }
    }
}
