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
using Newtonsoft.Json;


namespace gestionnaire_de_reservation
{
    public partial class Formlogin : Form
    {
        private string apiUrl = "http://localhost:3000/loginAdminTest";
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar=true;
            pictureBoxShow.Show();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez remplir toutes les cases", "Cases obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer un objet HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Préparer les données à envoyer
                    var data = new
                    {
                        email = textBoxUsername.Text.Trim(),
                        mdp = textBoxPassword.Text.Trim()
                    };

                    try
                    {
                        // Convertir les données en format JSON
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        // Envoyer la requête POST à votre API
                        var response = await client.PostAsync(apiUrl, content);

                        // Vérifier si la requête a réussi
                        if (response.IsSuccessStatusCode)
                        {
                            // Récupérer la réponse de l'API
                            var responseContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseContent, "Réponse de l'API", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Rediriger vers votre tableau de bord si l'authentification est réussie
                            FormDashboard fd = new FormDashboard();
                            fd.Show();
                        }
                        else
                        {
                            // Afficher un message d'erreur si la requête échoue
                            MessageBox.Show("Erreur lors de la requête à l'API", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Gérer les erreurs potentielles
                        MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

