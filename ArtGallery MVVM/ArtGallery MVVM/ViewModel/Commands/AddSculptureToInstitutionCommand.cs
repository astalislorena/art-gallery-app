using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class AddSculptureToInstitutionCommand : ICommand
    {

        private readonly ArtGalleryManagementViewModel _viewModel;
        public AddSculptureToInstitutionCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            int idIns = int.Parse(this._viewModel.InstitutionId);
            Institution inst = ArtGalleryDbContext.instance.Institutions.SingleOrDefault(prop => prop.Id == idIns);
            int idPain = int.Parse(this._viewModel.SculptureId);
            Sculpture sculpture = ArtGalleryDbContext.instance.Sculptures.SingleOrDefault(prop => prop.Id == idPain);
            if (sculpture != null && inst != null)
            {
                inst.Sculptures.Add(sculpture);
                ArtGalleryDbContext.instance.SaveChanges();
            }

        }
    }
}
