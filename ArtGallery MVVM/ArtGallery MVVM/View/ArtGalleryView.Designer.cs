namespace ArtGallery_MVVM
{
    partial class ArtGalleryView
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
            this.paintingDataGridView = new System.Windows.Forms.DataGridView();
            this.sculptureDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveSculptures = new System.Windows.Forms.Button();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sculptureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techniqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paintingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sculptureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sculptureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paintingDataGridView
            // 
            this.paintingDataGridView.AutoGenerateColumns = false;
            this.paintingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paintingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.techniqueDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.paintingDataGridView.DataSource = this.paintingBindingSource;
            this.paintingDataGridView.Location = new System.Drawing.Point(15, 171);
            this.paintingDataGridView.Name = "paintingDataGridView";
            this.paintingDataGridView.Size = new System.Drawing.Size(644, 289);
            this.paintingDataGridView.TabIndex = 0;
            this.paintingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paintingDataGridView_CellContentClick);
            // 
            // sculptureDataGridView
            // 
            this.sculptureDataGridView.AutoGenerateColumns = false;
            this.sculptureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sculptureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.artistNameDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1});
            this.sculptureDataGridView.DataSource = this.sculptureBindingSource;
            this.sculptureDataGridView.Location = new System.Drawing.Point(679, 171);
            this.sculptureDataGridView.Name = "sculptureDataGridView";
            this.sculptureDataGridView.Size = new System.Drawing.Size(543, 289);
            this.sculptureDataGridView.TabIndex = 1;
            this.sculptureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sculptureDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paintings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sculptures";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveSculptures
            // 
            this.saveSculptures.Location = new System.Drawing.Point(1147, 466);
            this.saveSculptures.Name = "saveSculptures";
            this.saveSculptures.Size = new System.Drawing.Size(75, 23);
            this.saveSculptures.TabIndex = 5;
            this.saveSculptures.Text = "Save";
            this.saveSculptures.UseVisualStyleBackColor = true;
            this.saveSculptures.Click += new System.EventHandler(this.saveSculptures_Click);
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // artistNameDataGridViewTextBoxColumn1
            // 
            this.artistNameDataGridViewTextBoxColumn1.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn1.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn1.Name = "artistNameDataGridViewTextBoxColumn1";
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            // 
            // sculptureBindingSource
            // 
            this.sculptureBindingSource.DataSource = typeof(ArtGallery_MVP.Models.Sculpture);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // techniqueDataGridViewTextBoxColumn
            // 
            this.techniqueDataGridViewTextBoxColumn.DataPropertyName = "Technique";
            this.techniqueDataGridViewTextBoxColumn.HeaderText = "Technique";
            this.techniqueDataGridViewTextBoxColumn.Name = "techniqueDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // paintingBindingSource
            // 
            this.paintingBindingSource.DataSource = typeof(ArtGallery_MVP.Models.Painting);
            // 
            // artBindingSource
            // 
            this.artBindingSource.DataSource = typeof(ArtGallery_MVP.Models.Art);
            // 
            // ArtGalleryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 506);
            this.Controls.Add(this.saveSculptures);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sculptureDataGridView);
            this.Controls.Add(this.paintingDataGridView);
            this.Name = "ArtGalleryView";
            this.Text = "Art Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.paintingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sculptureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sculptureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource artBindingSource;
        private System.Windows.Forms.DataGridView paintingDataGridView;
        private System.Windows.Forms.BindingSource paintingBindingSource;
        private System.Windows.Forms.DataGridView sculptureDataGridView;
        private System.Windows.Forms.BindingSource sculptureBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveSculptures;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techniqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
    }
}

