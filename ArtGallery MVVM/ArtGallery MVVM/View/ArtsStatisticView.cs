﻿using ArtGallery_MVP.Models.Persistance;
using ArtGallery_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVVM.View
{
    public partial class ArtsStatisticView : Form
    {
        public ArtGalleryStatisticViewModel viewModel;
        public ArtsStatisticView()
        {
            InitializeComponent();
            this.viewModel = new ArtGalleryStatisticViewModel();
            this.viewModel.arts = this.artsChart;
            this.viewModel.institution = this.institutionChart;
        }

        private void ArtsStatisticView_Load(object sender, EventArgs e)
        {
            this.viewModel.ConfigureChartCommand.Execute();
            this.buttonGenerateInstitutionChart.Click += delegate { viewModel.ConfigureInstitutionChartCommand.Execute(); };
            this.numericUpDownInstitutionId.DataBindings.Add("Text", this.viewModel, "InstitutionId", false, DataSourceUpdateMode.OnValidation);
        }
    }
}
