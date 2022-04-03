using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.ViewModel.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVVM.ViewModel
{
    public class ShowAllArtsCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;
        public ShowAllArtsCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            ArtGalleryDbContext.instance.Paintings.Load();
            ArtGalleryDbContext.instance.Sculptures.Load();
            ArtGalleryDbContext.instance.Institutions.Load();
            _viewModel.paintingBindingSource.DataSource = ArtGalleryDbContext.instance.Paintings.Local.ToBindingList();
            _viewModel.sculptureBindingSource.DataSource = ArtGalleryDbContext.instance.Sculptures.Local.ToBindingList();
            _viewModel.institutionBindingSource.DataSource = ArtGalleryDbContext.instance.Institutions.Local.ToBindingList();

        }
    }
}
