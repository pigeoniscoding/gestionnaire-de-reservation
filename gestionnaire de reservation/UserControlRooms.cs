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
    public partial class UserControlRooms : UserControl
    {
        private readonly string apiUrl = "http://localhost:3000/cherchsalles";
        public UserControlRooms()
        {
            InitializeComponent();
            LoadRoomData();

        }
        public class RoomData
        {
            public int Id_Salles  { get; set; }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
