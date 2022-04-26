using ArtGallery_MVC.Model;
using ArtGallery_MVC.View;
using ArtGallery_MVC.Model;
using ArtGallery_MVC.Model.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArtGallery_MVC.Controller
{
    public class ArtsController : Observer
    {
        public ArtsModel arts;
        public ArtGalleryManagementView view { get; set; }

        public ArtsController(ArtGalleryManagementView view)
        {
            this.view = view;
            arts = view.arts;
            HandleEvents();
        }

        public void HandleEvents()
        {
            view.GetLoginButton().Click += new EventHandler(Login);
            view.GetSaveButton().Click += new EventHandler(SaveArts);
            view.GetSearchPaintingsButton().Click += new EventHandler(SearchPaintings);
            view.GetSearchSculpturesButton().Click += new EventHandler(SearchSculptures);
            view.GetShowAllPaintingsButton().Click += new EventHandler(ShowAllPaintings);
            view.GetShowAllSculpturesButton().Click += new EventHandler(ShowAllSculptures);
            view.GetShowStatisticButton().Click += new EventHandler(ShowStatistics);
            view.GetAddPaintingToInstitutionButton().Click += new EventHandler(AddPaintingToInstitution);
            view.GetAddSculptureToInstitutionButton().Click += new EventHandler(AddSculptureToInstitution);
            view.GetInstitutionStatisticButton().Click += new EventHandler(ShowInstitutionStatistics);
        }

        void AddPaintingToInstitution(object sender, EventArgs e)
        {
            int idIns = int.Parse(this.view.InstitutionId);
            Institution inst = ArtGalleryDbContext.instance.Institutions.SingleOrDefault(prop => prop.Id == idIns);
            int idPain = int.Parse(this.view.PaintingId);
            Painting paint = ArtGalleryDbContext.instance.Paintings.SingleOrDefault(prop => prop.Id == idPain);
            if (paint != null && inst != null)
            {
                inst.Paintings.Add(paint);
                ArtGalleryDbContext.instance.SaveChanges();
            }
        }
        void AddSculptureToInstitution(object sender, EventArgs e)
        {
            int idIns = int.Parse(this.view.InstitutionId);
            Institution inst = ArtGalleryDbContext.instance.Institutions.SingleOrDefault(prop => prop.Id == idIns);
            int idPain = int.Parse(this.view.SculptureId);
            Sculpture sculpture = ArtGalleryDbContext.instance.Sculptures.SingleOrDefault(prop => prop.Id == idPain);
            if (sculpture != null && inst != null)
            {
                inst.Sculptures.Add(sculpture);
                ArtGalleryDbContext.instance.SaveChanges();
            }
        }

        void SearchPaintings(object sender, EventArgs e)
        {
            List<Painting> paintings = new List<Painting>();
            foreach (var painting in ArtGalleryDbContext.instance.Paintings.ToList())
            {
                if (painting.Title.Contains(view.SearchPaintings) || painting.ArtistName.Contains(view.SearchPaintings))
                    paintings.Add(painting);
            }
            view.GetPaintingBindingSearch().DataSource = paintings;
            this.view.GetPaintingDataGridView().Refresh();
        }
        void SearchSculptures(object sender, EventArgs e)
        {
            List<Sculpture> sculptures = new List<Sculpture>();
            foreach (var sculpture in ArtGalleryDbContext.instance.Sculptures.ToList())
            {
                if (sculpture.Title.Contains(view.SearchSculptures) || sculpture.ArtistName.Contains(view.SearchSculptures))
                    sculptures.Add(sculpture);
            }
            view.GetSculptureBindingSource().DataSource = sculptures;
            this.view.GetSculptureDataGridView().Refresh();
        }

        void ShowAllPaintings(object sender, EventArgs e)
        {
            view.GetPaintingBindingSearch().DataSource = ArtGalleryDbContext.instance.Paintings.Local.ToBindingList();
        }

        void ShowAllSculptures(object sender, EventArgs e)
        {
            view.GetSculptureBindingSource().DataSource = ArtGalleryDbContext.instance.Sculptures.Local.ToBindingList();
        }

        void Login(object sender, EventArgs e)
        {
            try
            {
                User user = ArtGalleryDbContext.instance.Users.SingleOrDefault(p => p.Email == this.view.Email && p.Password == this.view.Password);
                if (user == null)
                {
                    MessageBox.Show("This user data is not correct!");
                    return;
                }
                if (this.view.Email.Contains("organiser"))
                {
                    this.view.GetSculptureDataGridView().ReadOnly = false;
                    this.view.GetPaintingDataGridView().ReadOnly = false;
                    this.view.GetInstitutionDataGridView().Enabled = true;
                    this.view.GetSaveButton().Enabled = true;
                    this.view.GetAddPaintingToInstitutionButton().Enabled = true;
                    this.view.GetAddSculptureToInstitutionButton().Enabled = true;
                    this.view.GetShowStatisticButton().Enabled = true;
                }
                if (this.view.Email.Contains("admin"))
                {
                    UsersModel usersModel = new UsersModel();
                    StaffManagementView staffManagementView = new StaffManagementView(usersModel);
                    StaffController controller = staffManagementView.controller;
                    controller.view.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This user data is not correct!");
            }
        }

        void SaveArts(object sender, EventArgs e)
        {
            ArtGalleryDbContext.instance.SaveChanges();
            this.view.GetPaintingDataGridView().Refresh();
            this.view.GetSculptureDataGridView().Refresh();
        }

        void ShowStatistics(object sender, EventArgs e)
        {
            //Add a new chart-series
            string seriesname = "MySeriesName";
            view.GetChart().Series.Add(seriesname);
            view.GetInstitutionChart().Series.Add("Institution");
            //set the chart-type to "Pie"
            view.GetChart().Series[seriesname].ChartType = SeriesChartType.Pie;

            int paintings = 0, sculptures = 0;
            foreach (var inst in ArtGalleryDbContext.instance.Institutions)
            {
                paintings = inst.Paintings.Count;
                sculptures = inst.Sculptures.Count;
            }
            //Add some datapoints so the series. in this case you can pass the values to this method
            view.GetChart().Series[seriesname].Points.AddXY("Paintings in Institutions", paintings);
            view.GetChart().Series[seriesname].Points.AddXY("Sculptures in Institutions", sculptures);
        }

        public void ShowInstitutionStatistics(object sender, EventArgs e)
        {
            //Add a new chart-series
            string seriesname = "Institution";
            view.GetInstitutionChart().Series[seriesname].Points.Clear();
            //set the chart-type to "Pie"
            view.GetInstitutionChart().Series[seriesname].ChartType = SeriesChartType.Pie;

            int idIns = int.Parse(this.view.InstitutionId);
            int paintings = 0, sculptures = 0;
            foreach (var inst in ArtGalleryDbContext.instance.Institutions)
            {
                if (inst.Id == idIns)
                {
                    paintings = inst.Paintings.Count;
                    sculptures = inst.Sculptures.Count;
                }
            }
            //Add some datapoints so the series. in this case you can pass the values to this method
            view.GetInstitutionChart().Series[seriesname].Points.AddXY("Paintings in Institutions", paintings);
            view.GetInstitutionChart().Series[seriesname].Points.AddXY("Sculptures in Institutions", sculptures);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
