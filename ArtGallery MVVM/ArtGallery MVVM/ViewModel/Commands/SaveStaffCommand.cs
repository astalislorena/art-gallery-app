using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.ViewModel.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class SaveStaffCommand : ICommand
    {
        private readonly StaffManagementViewModel _viewModel;

        public SaveStaffCommand(StaffManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }
        public void Execute()
        {
            ArtGalleryDbContext.instance.SaveChanges();
            this._viewModel.staffDataGridView.Refresh();
        }
    }
}
