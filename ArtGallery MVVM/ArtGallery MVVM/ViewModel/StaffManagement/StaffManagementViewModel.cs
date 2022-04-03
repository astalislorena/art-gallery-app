using ArtGallery_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.ViewModel.StaffManagement
{
    public class StaffManagementViewModel
    {
        public DataGridView staffDataGridView;
        public Button saveButton;

        public ICommand Save;

        public StaffManagementViewModel()
        {
            this.Save = new SaveStaffCommand(this);
        }
    }
}
