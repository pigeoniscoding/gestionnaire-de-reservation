using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaire_de_reservation
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

        }

        private void movePanel (Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            movePanel(buttonDashboard);
            userControlClient1.Hide();
            userControlSalle1.Hide();
            userControlUserTests1.Hide();
           
          
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            movePanel(buttonClient);
            userControlClient1.Show();
            userControlSalle1.Hide();
            userControlAdmins1.Hide();
            userControlUserTests1.Hide();

        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            movePanel(buttonRoom);
            userControlClient1.Hide();
            userControlSalle1.Show();
            userControlAdmins1.Hide();
            userControlUserTests1.Hide();

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            movePanel(buttonReservation);
            userControlClient1.Hide();
            userControlSalle1.Hide();
            userControlAdmins1.Hide();
            userControlUserTests1.Show();

        }

        private void userControlSalles1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdmins_Click(object sender, EventArgs e)
        {
            movePanel(buttonAdmins);
            userControlClient1.Hide();
            userControlSalle1.Hide();
            userControlAdmins1.Show();
            userControlUserTests1.Hide();

        }

        private void userControlAdmins1_Load(object sender, EventArgs e)
        {

        }
    }
}
