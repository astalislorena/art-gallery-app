using ArtGallery_MVC.Controller;
using ArtGallery_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ArtsModel artsModel = new ArtsModel();
            ArtGalleryManagementView artsView = new ArtGalleryManagementView(artsModel);
            ArtsController controller = artsView.controller;
            Application.Run(controller.view);  
        }
    }
}
