using ArtGallery_MVVM.View;
using ArtGallery_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArtGallery_MVVM.ViewModel
{
    public class ArtGalleryStatisticViewModel
    {
        public Chart arts;
        public Chart institution;
        public string InstitutionId { get; set; }
        public ICommand ConfigureChartCommand;
        public ICommand ConfigureInstitutionChartCommand;

        public ArtGalleryStatisticViewModel()
        {
            this.ConfigureChartCommand = new ConfigureChartCommand(this);
            this.ConfigureInstitutionChartCommand = new GenerateInstitutionStatisticCommand(this);
        }
    }
}
