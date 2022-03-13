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

namespace ArtGallery_MVP.View.Staff
{
    public partial class AdminForm : Form, IVizStaff
    {
        public List<string[]> Staff
        {
            set
            {
                if(value == null)
                {
                    MessageBox.Show("Something went wrong!");
                    return;
                }
                listView.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem row = listView.Items.Add(value[i][0]);
                    row.SubItems.Add(value[i][1]);
                    row.SubItems.Add(value[i][2]);
                    row.SubItems.Add(value[i][3]);
                }
            }
        }
        public string FirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string LastName { get => txtLastName.Text; set => txtLastName.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public string? Selected
        {
            get
            {
                if (listView.SelectedItems.Count > 0)
                {
                    return listView.SelectedItems[0].Text;
                }
                return null;
            }
        }

        public AdminForm()
        {
            InitializeComponent();
            listView.View = System.Windows.Forms.View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("First name", 90);
            listView.Columns.Add("Last name", 90);
            listView.Columns.Add("Email", 90);
            listView.Columns.Add("Password", 90);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSrachByName_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            sp.GetByName(txtFirstName.Text, txtLastName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            sp.List();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            if(sp.GetByEmail(txtEmail.Text, false))
            {
                MessageBox.Show("This user already exists!");
                return;
            }
            User user = new User(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);
            sp.AddUser(user);
        }

        private void btnSearchByEmail_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            sp.GetByEmail(txtEmail.Text, true);
        }

        private void btnGetSelectedRow_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show("Please select a row first!");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            if (!sp.GetByEmail(txtEmail.Text, false))
            {
                MessageBox.Show("User with this email does not exist!");
                return;
            }
            User user = new User(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);
            sp.UpdateUser(user);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            if (!sp.GetByEmail(txtEmail.Text, false))
            {
                MessageBox.Show("User with this email does not exist!");
                return;
            }
            User user = new User(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);
            sp.DeleteUser(user);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            StaffPresenter sp = new StaffPresenter(this);
            sp.List();
        }
    }
}
