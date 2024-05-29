using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gestionnaire_de_reservation.User_Control.UserControlClient;

namespace gestionnaire_de_reservation
{
    public partial class UserControlAdmins : UserControl
    {
        private readonly string apiUrl = "http://localhost:3000/afficherAdmin";
        private readonly string apiUrlutilisateur = "http://localhost:3000/utilisateurs";
        private string selectedEmail = "";
        private string selectedEmailAdd = "";
        public UserControlAdmins()
        {
            InitializeComponent();
            LoadUserData();
            

        }
        public class UserData
        {
            public int Id_Personnes { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Adress_mail { get; set; }
            public long? Numero_de_telephone { get; set; }
            public string Date_de_naissance { get; set; }


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxSearchEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                await SearchUserByEmail(email);
            }
            else
            {
                LoadUserData(); // Si aucun texte n'est saisi, rechargez tous les utilisateurs
            }
        }
        private async Task SearchUserByEmail(string email)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:3000/chercherAdmin?email={email}");
                    if (response.IsSuccessStatusCode)
                    {
                        var userData = await response.Content.ReadAsAsync<UserData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewAdmin.DataSource = userData;
                    }
                    else
                    {
                        MessageBox.Show("Aucun utilisateur trouvé avec cette adresse e-mail.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadUserData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var userData = await response.Content.ReadAsAsync<UserData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewAdmin.DataSource = userData;
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewAdmin.Rows[e.RowIndex];
                selectedEmail = row.Cells["Column4"].Value.ToString(); // Sauvegarder la valeur de l'email sélectionné
                textBoxEmailAdmin.Text = selectedEmail; // Mettre à jour le contenu de textBoxEmail1 avec l'email sélectionné


            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNameAdmin.Text.Trim() == string.Empty || textBoxLastNameAdmin.Text.Trim() == string.Empty || textBoxBirthDayAdmin.Text.Trim() == string.Empty || textBoxPhoneAdmin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez remplir toutes les cases", "Cases obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                var modify = new ModifierClient
                {
                    Email = selectedEmail,
                    Prenom = textBoxFirstNameAdmin.Text,
                    Nom = textBoxLastNameAdmin.Text,
                    Numero_de_telephone = textBoxPhoneAdmin.Text,
                    Date_de_naissance = textBoxBirthDayAdmin.Text

                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                var json = JsonSerializer.Serialize(modify);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync("modifier", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("finally");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var postdata = new PostData
            {
                email = selectedEmail
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            var json = JsonSerializer.Serialize(postdata);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("delete", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private async void buttonChercheNouvAdmin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmailNovAdmin.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                await SearchUtilisateurByEmail(email);
            }
            else
            {
                LoadUtilisateurData(); // Si aucun texte n'est saisi, rechargez tous les utilisateurs
            }
        }

        //loaduserpourutilisateur
        private async void LoadUtilisateurData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrlutilisateur);
                    if (response.IsSuccessStatusCode)
                    {
                        var userData = await response.Content.ReadAsAsync<UserData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewAdminAdd.DataSource = userData;
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des utilisateurs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //chercher les utilisateurs
        private async Task SearchUtilisateurByEmail(string emailutilisateur)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:3000/recherche?email={emailutilisateur}");
                    if (response.IsSuccessStatusCode)
                    {
                        var userData = await response.Content.ReadAsAsync<UserData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewAdminAdd.DataSource = userData;
                    }
                    else
                    {
                        MessageBox.Show("Aucun utilisateur trouvé avec cette adresse e-mail.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAdminAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewAdminAdd.Rows[e.RowIndex];
                selectedEmailAdd = row.Cells["ColumnAdd4"].Value.ToString(); // Sauvegarder la valeur de l'email sélectionné
                textBoxEmailNovAdmin.Text = selectedEmailAdd; // Mettre à jour le contenu de textBoxEmail1 avec l'email sélectionné


            }

        }

        private async void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            string emailAdd = textBoxEmailNovAdmin.Text.Trim();
            if (!string.IsNullOrEmpty(emailAdd))
            {
                await addAdmin(emailAdd);
            }
            else
            {
                Console.WriteLine("ajouter un mail");
            }
        }

        //ajouter un Admin
        private async Task addAdmin(string emailAdd)
        {
            if (textBoxEmailNovAdmin.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Veuillez remplir toutes les cases", "Cases obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                var modify = new ModifierClient
                {
                    Email = emailAdd

                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000/");
                var json = JsonSerializer.Serialize(modify);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync("AddAdmin", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("finally");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
