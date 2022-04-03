using ArtGallery_MVP.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class SaveArtsCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;
        public SaveArtsCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            ArtGalleryDbContext.instance.SaveChanges();
            this._viewModel.paintingDataGridView.Refresh();
            this._viewModel.sculptureDataGridView.Refresh();
        }
    }
}
