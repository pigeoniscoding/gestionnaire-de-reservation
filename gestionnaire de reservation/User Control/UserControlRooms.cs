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
using static gestionnaire_de_reservation.User_Control.UserControlClient;

namespace gestionnaire_de_reservation
{
    public partial class Rooms1 : UserControl
    {
        private readonly string apiUrl = "http://localhost:3000/recupsalles";

        public Rooms1()
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
                        var userData = await response.Content.ReadAsAsync<RoomData[]>(); // UserData représente la structure de vos données utilisateur
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

        private async Task SearchRoomByID(int ID)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:3000/cherchsalles={ID}");
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


        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string IDstr = textBoxSearchroom.Text.Trim();
            if (!string.IsNullOrEmpty(IDstr))
            {
                var ID = int.Parse(IDstr);
                await SearchRoomByID(ID);
            }
            else
            {
                LoadRoomData(); // Si aucun texte n'est saisi, rechargez tous les utilisateurs
            }
        }

        private void Rooms1_Load(object sender, EventArgs e)
        {

        }
    }
}
