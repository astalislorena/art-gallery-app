using ArtGallery_MVVM.View;
using ArtGallery_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.ViewModel
{
    public class ShowStatisticsCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;
        public ShowStatisticsCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            Form statisticView = new ArtsStatisticView();
            statisticView.Show();
        }
    }
}
