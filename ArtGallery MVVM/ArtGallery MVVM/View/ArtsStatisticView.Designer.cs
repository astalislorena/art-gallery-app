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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.artsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.institutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownInstitutionId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateInstitutionChart = new System.Windows.Forms.Button();
            this.paintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.artsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInstitutionId)).BeginInit();
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
            // institutionChart
            // 
            chartArea2.Name = "ChartArea1";
            this.institutionChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.institutionChart.Legends.Add(legend2);
            this.institutionChart.Location = new System.Drawing.Point(390, 12);
            this.institutionChart.Name = "institutionChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.institutionChart.Series.Add(series2);
            this.institutionChart.Size = new System.Drawing.Size(450, 426);
            this.institutionChart.TabIndex = 1;
            this.institutionChart.Text = "chart1";
            // 
            // numericUpDownInstitutionId
            // 
            this.numericUpDownInstitutionId.Location = new System.Drawing.Point(879, 23);
            this.numericUpDownInstitutionId.Name = "numericUpDownInstitutionId";
            this.numericUpDownInstitutionId.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInstitutionId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Institution id";
            // 
            // buttonGenerateInstitutionChart
            // 
            this.buttonGenerateInstitutionChart.Location = new System.Drawing.Point(900, 49);
            this.buttonGenerateInstitutionChart.Name = "buttonGenerateInstitutionChart";
            this.buttonGenerateInstitutionChart.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateInstitutionChart.TabIndex = 4;
            this.buttonGenerateInstitutionChart.Text = "See statistic";
            this.buttonGenerateInstitutionChart.UseVisualStyleBackColor = true;
            // 
            // paintingBindingSource
            // 
            this.paintingBindingSource.DataSource = typeof(ArtGallery_MVP.Models.Painting);
            // 
            // ArtsStatisticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.buttonGenerateInstitutionChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownInstitutionId);
            this.Controls.Add(this.institutionChart);
            this.Controls.Add(this.artsChart);
            this.Name = "ArtsStatisticView";
            this.Text = "ArtsStatisticView";
            this.Load += new System.EventHandler(this.ArtsStatisticView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInstitutionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart artsChart;
        private System.Windows.Forms.BindingSource paintingBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart institutionChart;
        private System.Windows.Forms.NumericUpDown numericUpDownInstitutionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateInstitutionChart;
    }
}