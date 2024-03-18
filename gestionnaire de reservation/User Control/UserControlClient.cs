using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json; 
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gestionnaire_de_reservation.User_Control
{
    public partial class UserControlClient : UserControl
    {
       
        private readonly string apiUrl = "http://localhost:3000/utilisateurs";
        private string selectedEmail = "";
        private string selectedlastname = "";
        private string selectedfirstname = "";
        private string selecteddate = "";
        public UserControlClient()
        {
            InitializeComponent();
            LoadUserData(); // Charger les données des utilisateurs lors du chargement du UserControl
        }

        public class UserData
        {
            public int Id_Personnes { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Adress_mail { get; set; }
            public long? Numero_de_telephone { get; set; }
            public DateTime? Date_de_naissance { get; set; }
            

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
                        dataGridViewClient.DataSource = userData;
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

        private async void textBoxSearchEmail_TextChanged(object sender, EventArgs e)
        {
           
        }
        private async Task SearchUserByEmail(string email)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:3000/recherche?email={email}");
                    if (response.IsSuccessStatusCode)
                    {
                        var userData = await response.Content.ReadAsAsync<UserData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewClient.DataSource = userData;
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

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                selectedEmail = row.Cells["Column4"].Value.ToString(); // Sauvegarder la valeur de l'email sélectionné
                textBoxEmail1.Text = selectedEmail; // Mettre à jour le contenu de textBoxEmail1 avec l'email sélectionné
                //selectedlastname = row.Cells["Column2"].Value.ToString();
                //selectedfirstname = row.Cells["Column3"].Value.ToString();
               // selecteddate = row.Cells["Column6"].Value.ToString();
            }
        }


        private async void buttonDelete_Click_1(object sender, EventArgs e)
        {
            var postdata = new PostData
            {
                email = selectedEmail
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/") ;
            var json = JsonSerializer.Serialize(postdata);
            var content = new StringContent(json,Encoding.UTF8, "application/json");
            var response = client.PostAsync("delete",content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxBirthDay.Text.Trim()== string.Empty || textBoxPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez remplir toutes les cases", "Cases obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                var modify = new ModifierClient
                {
                    Email = selectedEmail,
                    Prenom = textBoxFirstName1.Text,
                    Nom = textBoxLastName1.Text,
                    Numero_de_telephone = textBoxPhone.Text,
                    Date_de_naissance = textBoxBirthDay.Text

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

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       // private void buttonAjouterAdmin_Click(object sender, EventArgs e)
       // {
          //  var UserData = new UserData
         //   {
           //     Nom = selectedlastname,
           //     Prenom = selectedfirstname,
           //     Date_de_naissance = selecteddate,
            //    Adress_mail = selectedEmail,
            //    mdp = textBoxMdp.Text


           // };
          //  var client = new HttpClient();
           // client.BaseAddress = new Uri("http://localhost:3000/");
           // var json = JsonSerializer.Serialize(UserData);
           // var content = new StringContent(json, Encoding.UTF8, "application/json");
           // var response = client.PostAsync("AddAdmin", content).Result;

           // if (response.IsSuccessStatusCode)
           // {
           //     Console.WriteLine("finally");
           // }
           // else
           // {
           //     Console.WriteLine("error");
           // }
       // }
    }
}
