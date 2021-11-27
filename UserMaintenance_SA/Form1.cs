using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance_SA.Entities;

namespace UserMaintenance_SA
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();


        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName;
            btnToFile.Text = Resource1.FajlbaIras;

            btnAdd.Text = Resource1.Add;

            listbUsers.DataSource = users;
            listbUsers.ValueMember = "ID";
            listbUsers.DisplayMember = "FullName";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User u = new User();
            //u.LastName = txtLastName.Text;
            //u.FirstName = txtFirstName.Text;
            u.FullName = txtFullName.Text;
            users.Add(u);
        }

        private void btnToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show("itt");
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (User item in users)
                    {
                        sw.WriteLine(item.ID + ";" + item.FullName);
                    }
                }


            }
        }
    }
}
