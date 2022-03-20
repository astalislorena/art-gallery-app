using ArtGallery_MVP.Presenter;
using ArtGallery_MVP.View;
using ArtGallery_MVP.View.ArtsManagement;
using ArtGallery_MVP.View.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVP
{
    public partial class VizualizeArts : Form, IVizArts
    {
        public string Title { 
            get {
                return this.txtTitle.Text;
            } set
            {
                this.txtTitle.Text = value; 
            }
        }
        public string ArtistName
        {
            get
            {
                return this.txtArtist.Text;
            }
            set
            {
                this.txtArtist.Text = value;
            }
        }
        public List<string[]> Arts { 
            set
            {
                listView.Items.Clear();
                for(int i = 0; i < value.Count; i++)
                {
                    ListViewItem row = listView.Items.Add(value[i][0]);
                    row.SubItems.Add(value[i][1]);
                    row.SubItems.Add(value[i][2]);
                    row.SubItems.Add(value[i][3]);
                }
            }
        }

        public string Selected
        {
            get
            {
                if(listView.SelectedItems.Count > 0)
                {
                    return listView.SelectedItems[0].Text;
                }
                return null;
            }
        }

        public int Year { get => (int) txtYear.Value; set => txtYear.Value = value; }

        public VizualizeArts()
        {
            InitializeComponent();
            listView.View = System.Windows.Forms.View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("Title", 150);
            listView.Columns.Add("Artist", 90);
            listView.Columns.Add("Year", 90);
            listView.Columns.Add("Painting type & technique/Sculpture type", 200);

        }

        private void VizualizeArts_Load(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.List();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // seach by year
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.GetByYear((int) txtYear.Value);
        }

        private void btnSearchBytitle_Click(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.GetByTitle(txtTitle.Text);
        }

        private void btnSearchByArtist_Click(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.GetByArtist(txtArtist.Text);
        }

        private void btnVizAllArts_Click(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.List();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            if(txtEmail.Text.Contains("admin") && pp.GetUser(txtEmail.Text, txtPassword.Text))
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            } else
            {
                if (txtEmail.Text.Contains("organiser") && pp.GetUser(txtEmail.Text, txtPassword.Text))
                {
                    VizualiseArtsManagement artsManagement = new VizualiseArtsManagement();
                    artsManagement.Show();
                    
                } else
                {
                    MessageBox.Show("Failed to login!");
                }
            }
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.ListPaintings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArtsPresenter pp = new ArtsPresenter(this);
            pp.ListSculptures();
        }
    }
}
