using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaire_de_reservation
{
    public partial class UserControlTableauBoard : UserControl
    {
        public UserControlTableauBoard()
        {
            InitializeComponent();
            ReadClientNumber();
            ReadAdminNumber();
            ReadRoomNumber();
            ReadReservationNumber();
        }

        private async void UserControlTableauBoard_Load(object sender, EventArgs e)
        {
       

        }
        private async Task ReadClientNumber()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/afficherNbClient");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic responseData = JsonConvert.DeserializeObject(jsonString);

                        // Vérifier si la réponse contient des données
                        if (responseData != null)
                        {
                            int numberOfUsers = responseData[0]["COUNT(*)"];
                            label2.Text= numberOfUsers.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée récupérée de la route.", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }


        private async Task ReadRoomNumber()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/afficherNbRooms");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic responseData = JsonConvert.DeserializeObject(jsonString);

                        // Vérifier si la réponse contient des données
                        if (responseData != null)
                        {
                            int numberOfUsers = responseData[0]["COUNT(*)"];
                            label3.Text = numberOfUsers.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée récupérée de la route.", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private async Task ReadAdminNumber()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/afficherNbAdmins");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic responseData = JsonConvert.DeserializeObject(jsonString);

                        // Vérifier si la réponse contient des données
                        if (responseData != null)
                        {
                            int numberOfUsers = responseData[0]["COUNT(*)"];
                            label4.Text = numberOfUsers.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée récupérée de la route.", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private async Task ReadReservationNumber()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:3000/afficherNbReservation");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic responseData = JsonConvert.DeserializeObject(jsonString);

                        // Vérifier si la réponse contient des données
                        if (responseData != null)
                        {
                            int numberOfUsers = responseData[0]["COUNT(*)"];
                            label1.Text = numberOfUsers.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée récupérée de la route.", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
