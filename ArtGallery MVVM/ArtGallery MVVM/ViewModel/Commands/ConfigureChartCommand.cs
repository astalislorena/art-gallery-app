using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArtGallery_MVVM.ViewModel
{
    public class ConfigureChartCommand : ICommand
    {
        private readonly ArtGalleryStatisticViewModel _viewModel;

        public ConfigureChartCommand(ArtGalleryStatisticViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            //Add a new chart-series
            string seriesname = "MySeriesName";
            _viewModel.arts.Series.Add(seriesname);
            //set the chart-type to "Pie"
            _viewModel.arts.Series[seriesname].ChartType = SeriesChartType.Pie;

            int paintings = 0, sculptures = 0;
            foreach(var inst in ArtGalleryDbContext.instance.Institutions)
            {
                paintings = inst.Paintings.Count;
                sculptures = inst.Sculptures.Count;
            }
            //Add some datapoints so the series. in this case you can pass the values to this method
            _viewModel.arts.Series[seriesname].Points.AddXY("Paintings in Institutions", paintings);
            _viewModel.arts.Series[seriesname].Points.AddXY("Sculptures in Institutions", sculptures);
        }
    }
}
