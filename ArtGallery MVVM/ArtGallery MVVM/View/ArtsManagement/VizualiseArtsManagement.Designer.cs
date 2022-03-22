namespace ArtGallery_MVP.View.ArtsManagement
{
    partial class VizualiseArtsManagement
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
            this.paintingListView = new System.Windows.Forms.ListView();
            this.sculptureListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetPaintings = new System.Windows.Forms.Button();
            this.btngetSculptures = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaintingTechnique = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetByTitle = new System.Windows.Forms.Button();
            this.btnSavePaintings = new System.Windows.Forms.Button();
            this.btnSaveSculptures = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nnumericYear = new System.Windows.Forms.NumericUpDown();
            this.isPainting = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nnumericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // paintingListView
            // 
            this.paintingListView.HideSelection = false;
            this.paintingListView.Location = new System.Drawing.Point(338, 27);
            this.paintingListView.Name = "paintingListView";
            this.paintingListView.Size = new System.Drawing.Size(450, 156);
            this.paintingListView.TabIndex = 0;
            this.paintingListView.UseCompatibleStateImageBehavior = false;
            // 
            // sculptureListView
            // 
            this.sculptureListView.HideSelection = false;
            this.sculptureListView.Location = new System.Drawing.Point(338, 232);
            this.sculptureListView.Name = "sculptureListView";
            this.sculptureListView.Size = new System.Drawing.Size(450, 176);
            this.sculptureListView.TabIndex = 1;
            this.sculptureListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paintings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sculptures";
            // 
            // btnGetPaintings
            // 
            this.btnGetPaintings.Location = new System.Drawing.Point(586, 189);
            this.btnGetPaintings.Name = "btnGetPaintings";
            this.btnGetPaintings.Size = new System.Drawing.Size(94, 23);
            this.btnGetPaintings.TabIndex = 5;
            this.btnGetPaintings.Text = "See painitngs";
            this.btnGetPaintings.UseVisualStyleBackColor = true;
            this.btnGetPaintings.Click += new System.EventHandler(this.btnGetPaintings_Click);
            // 
            // btngetSculptures
            // 
            this.btngetSculptures.Location = new System.Drawing.Point(588, 411);
            this.btngetSculptures.Name = "btngetSculptures";
            this.btngetSculptures.Size = new System.Drawing.Size(92, 23);
            this.btngetSculptures.TabIndex = 6;
            this.btngetSculptures.Text = "See sculptures";
            this.btngetSculptures.UseVisualStyleBackColor = true;
            this.btngetSculptures.Click += new System.EventHandler(this.btngetSculptures_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(20, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(184, 23);
            this.txtTitle.TabIndex = 7;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(20, 72);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(184, 23);
            this.txtArtistName.TabIndex = 8;
            this.txtArtistName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(20, 160);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(184, 23);
            this.txtType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Artist name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Painting technique";
            // 
            // txtPaintingTechnique
            // 
            this.txtPaintingTechnique.Location = new System.Drawing.Point(20, 214);
            this.txtPaintingTechnique.Name = "txtPaintingTechnique";
            this.txtPaintingTechnique.Size = new System.Drawing.Size(184, 23);
            this.txtPaintingTechnique.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddPainting_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetByTitle
            // 
            this.btnGetByTitle.Location = new System.Drawing.Point(210, 27);
            this.btnGetByTitle.Name = "btnGetByTitle";
            this.btnGetByTitle.Size = new System.Drawing.Size(42, 23);
            this.btnGetByTitle.TabIndex = 21;
            this.btnGetByTitle.Text = "🔍";
            this.btnGetByTitle.UseVisualStyleBackColor = true;
            this.btnGetByTitle.Click += new System.EventHandler(this.btnGetByTitle_Click);
            // 
            // btnSavePaintings
            // 
            this.btnSavePaintings.Location = new System.Drawing.Point(686, 189);
            this.btnSavePaintings.Name = "btnSavePaintings";
            this.btnSavePaintings.Size = new System.Drawing.Size(102, 23);
            this.btnSavePaintings.TabIndex = 22;
            this.btnSavePaintings.Text = "Save paintings";
            this.btnSavePaintings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSculptures
            // 
            this.btnSaveSculptures.Location = new System.Drawing.Point(686, 411);
            this.btnSaveSculptures.Name = "btnSaveSculptures";
            this.btnSaveSculptures.Size = new System.Drawing.Size(102, 23);
            this.btnSaveSculptures.TabIndex = 23;
            this.btnSaveSculptures.Text = "Save sculptures";
            this.btnSaveSculptures.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Year";
            // 
            // nnumericYear
            // 
            this.nnumericYear.Location = new System.Drawing.Point(22, 116);
            this.nnumericYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nnumericYear.Name = "nnumericYear";
            this.nnumericYear.Size = new System.Drawing.Size(182, 23);
            this.nnumericYear.TabIndex = 25;
            // 
            // isPainting
            // 
            this.isPainting.AutoSize = true;
            this.isPainting.Location = new System.Drawing.Point(133, 278);
            this.isPainting.Name = "isPainting";
            this.isPainting.Size = new System.Drawing.Size(70, 19);
            this.isPainting.TabIndex = 26;
            this.isPainting.Text = "painting";
            this.isPainting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "CSV";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Save raport as";
            // 
            // VizualiseArtsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isPainting);
            this.Controls.Add(this.nnumericYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveSculptures);
            this.Controls.Add(this.btnSavePaintings);
            this.Controls.Add(this.btnGetByTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPaintingTechnique);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btngetSculptures);
            this.Controls.Add(this.btnGetPaintings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sculptureListView);
            this.Controls.Add(this.paintingListView);
            this.Name = "VizualiseArtsManagement";
            this.Text = "Arts management";
            this.Load += new System.EventHandler(this.VizualiseArtsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nnumericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView paintingListView;
        private System.Windows.Forms.ListView sculptureListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetPaintings;
        private System.Windows.Forms.Button btngetSculptures;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaintingTechnique;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetByTitle;
        private System.Windows.Forms.Button btnSavePaintings;
        private System.Windows.Forms.Button btnSaveSculptures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nnumericYear;
        private System.Windows.Forms.CheckBox isPainting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}