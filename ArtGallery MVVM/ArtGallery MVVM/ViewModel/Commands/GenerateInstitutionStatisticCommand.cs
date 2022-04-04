using ArtGallery_MVP.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class GenerateInstitutionStatisticCommand : ICommand
    {
        private readonly ArtGalleryStatisticViewModel _viewModel;

        public GenerateInstitutionStatisticCommand(ArtGalleryStatisticViewModel viewModel) {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            //Add a new chart-series
            string seriesname = "Institution";
            _viewModel.institution.Series.Add(seriesname);
            //set the chart-type to "Pie"
            _viewModel.institution.Series[seriesname].ChartType = SeriesChartType.Pie;

            int idIns = int.Parse(this._viewModel.InstitutionId);
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
            _viewModel.institution.Series[seriesname].Points.AddXY("Paintings in Institutions", paintings);
            _viewModel.institution.Series[seriesname].Points.AddXY("Sculptures in Institutions", sculptures);
        }
    }
}
