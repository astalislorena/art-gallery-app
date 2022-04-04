using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class SearchPaintingsCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;
        public SearchPaintingsCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            List<Painting> paintings = new List<Painting>();
            foreach(var painting in ArtGalleryDbContext.instance.Paintings.ToList())
            {
                if(painting.Title.Contains(_viewModel.SearchSculptures) || painting.ArtistName.Contains(_viewModel.SearchSculptures))
                    paintings.Add(painting);
            }
            _viewModel.paintingBindingSource.DataSource = paintings;

        }
    }
}
