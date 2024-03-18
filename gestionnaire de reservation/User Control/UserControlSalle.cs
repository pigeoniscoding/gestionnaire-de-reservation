using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Text.Json; //ajouté
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gestionnaire_de_reservation
{
    public partial class UserControlSalle : UserControl
    {
        private readonly string apiUrl = "http://localhost:3000/recupsalles";
        private int selectedID = 0;
        private string selectedIDstr = "";
        public UserControlSalle()
        {
            InitializeComponent();
            LoadRoomData();
        }
        public class RoomData
        {
            public int Id_Salles { get; set; }
            public int Numero_de_la_salle { get; set; }
            public int Capacite { get; set; }
            public string Description { get; set; }
            

        }

        private async void LoadRoomData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var roomData = await response.Content.ReadAsAsync<RoomData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewClient.DataSource = roomData;
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

  
        private async Task SearchUserByID(int Id_salles)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new { Id_Salles = Id_salles }; // Créez un objet JSON avec l'ID
                    var json = JsonConvert.SerializeObject(data); // Convertissez l'objet en JSON

                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://localhost:3000/cherchsalles", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var roomData = await response.Content.ReadAsAsync<RoomData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewClient.DataSource = roomData;
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
        private async void buttonSearchID_Click(object sender, EventArgs e)
        {
            string IDstr = textBoxSearchID.Text.Trim();
            if (!string.IsNullOrEmpty(IDstr))
            {
                Console.WriteLine(IDstr);
                int ID = int.Parse(IDstr);
                Console.WriteLine(ID);

                await SearchUserByID(ID);
            }
            else
            {
                LoadRoomData(); // Si aucun texte n'est saisi, rechargez tous les utilisateurs
            }
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                selectedIDstr = row.Cells["Column1"].Value.ToString(); // Sauvegarder la valeur de l'email sélectionné
                textBoxID1.Text = selectedIDstr; // Mettre à jour le contenu de textBoxEmail1 avec l'email sélectionné

            }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedID = int.Parse(selectedIDstr);
            var RoomData = new RoomData
            {
                Id_Salles = selectedID
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            var json = JsonConvert.SerializeObject(RoomData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("deleteRoom", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string numerosallestr = textBoxNumerodelasalle.Text;
            string capacitestr = textBoxCapacite.Text;
            var RoomData = new RoomData
            {
                Numero_de_la_salle = int.Parse(numerosallestr),
                Capacite = int.Parse(capacitestr),
                Description = textBoxDescription.Text,

            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            var json = JsonConvert.SerializeObject(RoomData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("AddRoom", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
                MessageBox.Show("la salle a ete ajoutée .", "Salle Ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
