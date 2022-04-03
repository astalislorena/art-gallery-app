namespace ArtGallery_MVVM.View
{
    partial class ArtsStatisticView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.artsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.artsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.artsChart.ChartAreas.Add(chartArea1);
            this.artsChart.DataSource = this.paintingBindingSource;
            legend1.Name = "Legend1";
            this.artsChart.Legends.Add(legend1);
            this.artsChart.Location = new System.Drawing.Point(12, 12);
            this.artsChart.Name = "artsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.artsChart.Series.Add(series1);
            this.artsChart.Size = new System.Drawing.Size(372, 426);
            this.artsChart.TabIndex = 0;
            this.artsChart.Text = "chart1";
            // 
            // paintingBindingSource
            // 
            this.paintingBindingSource.DataSource = typeof(ArtGallery_MVP.Models.Painting);
            // 
            // ArtsStatisticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.artsChart);
            this.Name = "ArtsStatisticView";
            this.Text = "ArtsStatisticView";
            this.Load += new System.EventHandler(this.ArtsStatisticView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart artsChart;
        private System.Windows.Forms.BindingSource paintingBindingSource;
    }
}