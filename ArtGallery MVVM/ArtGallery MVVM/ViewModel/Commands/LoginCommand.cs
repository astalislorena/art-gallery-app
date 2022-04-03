using ArtGallery_MVP.Models;
using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly ArtGalleryManagementViewModel _viewModel;

        public LoginCommand(ArtGalleryManagementViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public void Execute()
        {
            try
            {
                User user = ArtGalleryDbContext.instance.Users.SingleOrDefault(p => p.Email == this._viewModel.UserEmail && p.Password == this._viewModel.UserPassword);
                if (user == null)
                {
                    MessageBox.Show("This user data is not correct!");
                    return;
                }
                if(this._viewModel.UserEmail.Contains("organiser"))
                {
                    this._viewModel.sculptureDataGridView.ReadOnly = false;
                    this._viewModel.paintingDataGridView.ReadOnly = false;
                    this._viewModel.institutionDataGridView.Enabled = true;
                    this._viewModel.saveButton.Enabled = true;
                    this._viewModel.addPaintingToInstitutionButton.Enabled = true;
                    this._viewModel.addSculptureToInstitutionButton.Enabled = true;
                    this._viewModel.showStatisticButton.Enabled = true;
                }
                if(this._viewModel.UserEmail.Contains("admin"))
                {
                    var form = new StaffManagementView();
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This user data is not correct!");
            }
        }
    }
}
