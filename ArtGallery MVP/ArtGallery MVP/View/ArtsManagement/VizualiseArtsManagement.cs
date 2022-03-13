using ArtGallery_MVP.Models;
using ArtGallery_MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery_MVP.View.ArtsManagement
{
    public partial class VizualiseArtsManagement : Form, IVizArtsManagement
    {
        public string Title { get => txtTitle.Text; set => txtTitle.Text = value; }
        public string ArtistName { get => txtArtistName.Text; set => txtArtistName.Text = value; }
        public string Technique { get => txtPaintingTechnique.Text; set => txtPaintingTechnique.Text = value; }
        public int Year { get => (int) nnumericYear.Value; set => nnumericYear.Text = value.ToString(); }
        public string Type { get => txtType.Text; set => txtType.Text = value; }
        public List<string[]> Paintings {
            set
            {
                if (value == null)
                {
                    MessageBox.Show("Something went wrong!");
                    return;
                }
                paintingListView.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem row = paintingListView.Items.Add(value[i][0]);
                    row.SubItems.Add(value[i][1]);
                    row.SubItems.Add(value[i][2]);
                    row.SubItems.Add(value[i][3]);
                }
            }
        }
        public List<string[]> Sculptures
        {
            set
            {
                if (value == null)
                {
                    MessageBox.Show("Something went wrong!");
                    return;
                }
                sculptureListView.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem row = sculptureListView.Items.Add(value[i][0]);
                    row.SubItems.Add(value[i][1]);
                    row.SubItems.Add(value[i][2]);
                    row.SubItems.Add(value[i][3]);
                }
            }
        }

        public string Selected => throw new NotImplementedException();

        public VizualiseArtsManagement()
        {
            InitializeComponent();
            paintingListView.View = System.Windows.Forms.View.Details;
            paintingListView.GridLines = true;
            paintingListView.FullRowSelect = true;
            paintingListView.Columns.Add("Title", 90);
            paintingListView.Columns.Add("Artist", 90);
            paintingListView.Columns.Add("Year", 90);
            paintingListView.Columns.Add("Painting type & technique", 165);

            sculptureListView.View = System.Windows.Forms.View.Details;
            sculptureListView.GridLines = true;
            sculptureListView.FullRowSelect = true;
            sculptureListView.Columns.Add("Title", 90);
            sculptureListView.Columns.Add("Artist", 90);
            sculptureListView.Columns.Add("Year", 90);
            sculptureListView.Columns.Add("Sculpture type", 165);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPainting_Click(object sender, EventArgs e)
        {
            if (isPainting.Checked)
            {
                Painting painting = new Painting(Title, ArtistName, Year, Type, Technique);
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                if(amp.GetPaintingsByTitle(painting.Title, true))
                {
                    MessageBox.Show("Painting with this title already exists!");
                    return;
                }
                amp.Add(painting);
            } else
            {
                Sculpture sculpture = new Sculpture(Title, ArtistName, Year, Type);
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                if (amp.GetSculpturesByTitle(sculpture.Title, true))
                {
                    MessageBox.Show("Sculpture with this title already exists!");
                    return;
                }
                amp.Add(sculpture);
            }
        }

        private void VizualiseArtsManagement_Load(object sender, EventArgs e)
        {
            ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
            amp.ListPaintings();
            amp.ListSculptures();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isPainting.Checked)
            {
                Painting painting = new Painting(Title, ArtistName, Year, Type, Technique);
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                if (amp.GetPaintingsByTitle(painting.Title, false))
                {
                    MessageBox.Show("Painting with this title does not exist!");
                    return;
                }
                amp.Update(painting);
            }
            else
            {
                Sculpture sculpture = new Sculpture(Title, ArtistName, Year, Type);
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                if (amp.GetSculpturesByTitle(sculpture.Title, false))
                {
                    MessageBox.Show("Sculpture with this title does not exist!");
                    return;
                }
                amp.Update(sculpture);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isPainting.Checked)
            {
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                Painting painting = new Painting(Title, ArtistName, Year, Type, Technique);
                amp.Delete(painting);
            }
            else
            {
                ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
                Sculpture sculpture = new Sculpture(Title, ArtistName, Year, Type);
                amp.Delete(sculpture);
            }
        }

        private void btnGetPaintings_Click(object sender, EventArgs e)
        {
            ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
            amp.ListPaintings();
        }

        private void btnGetByTitle_Click(object sender, EventArgs e)
        {
            ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
            if (isPainting.Checked)
            {
                amp.GetPaintingsByTitle(Title, true);
            } else {
                amp.GetSculpturesByTitle(Title, true);
            }
            
        }

        private void btngetSculptures_Click(object sender, EventArgs e)
        {
            ArtsManagementPresenter amp = new ArtsManagementPresenter(this);
            amp.ListSculptures();
        }
    }
}
