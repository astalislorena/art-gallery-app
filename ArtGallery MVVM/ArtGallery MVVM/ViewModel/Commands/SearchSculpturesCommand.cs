using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class SearchSculpturesCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;
        public SearchSculpturesCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            List<Sculpture> sculptures = new List<Sculpture>();
            foreach (var sculpture in ArtGalleryDbContext.instance.Sculptures.ToList())
            {
                if (sculpture.Title.Contains(_viewModel.SearchPaintings) || sculpture.ArtistName.Contains(_viewModel.SearchPaintings))
                    sculptures.Add(sculpture);
            }
            _viewModel.sculptureBindingSource.DataSource = sculptures;

        }
    }
}
