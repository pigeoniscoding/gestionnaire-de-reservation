﻿using Newtonsoft.Json;
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
using static gestionnaire_de_reservation.UserControlSalle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace gestionnaire_de_reservation
{
    public partial class UserControlUserTests : UserControl
    {
        private readonly string apiUrl = "http://localhost:3000/afficherReservation";
        private int selectedID;
        private string selectedDate;
        private string selectedTime;
        public UserControlUserTests()
        {
            InitializeComponent();
            LoadReservationData();
        }

        //classReservationData
        public class ReservationData
        {
            public int Id_Reservation { get; set; }
            public string Details { get; set; }
            public DateTime? Date { get; set; }
            public string Time { get; set; }
            public int Id_Salles { get; set; }
            public string Materiel { get; set; }
            public DateTime? Date_de_reservation { get; set; }

        }

        //afficher les reservations
        private async void LoadReservationData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var reservationData = await response.Content.ReadAsAsync<ReservationData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewReservation.DataSource = reservationData;
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données des reservations.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Task pour rechercher une salle
        // Task pour rechercher une salle
        private async Task SearchReservation(int Id_Salles, DateTime Date, TimeSpan Time)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new { Id_Salles = Id_Salles, Date = Date.ToString("yyyy-MM-dd"), Time = Time.ToString(@"hh\:mm\:ss") }; // Créez un objet JSON avec les données
                    var json = JsonConvert.SerializeObject(data); // Convertissez l'objet en JSON

                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://localhost:3000/chercherRservation", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var reservationData = await response.Content.ReadAsAsync<ReservationData[]>(); // UserData représente la structure de vos données utilisateur
                        dataGridViewReservation.DataSource = reservationData;
                    }
                    else
                    {
                        MessageBox.Show("Aucune reservation trouvée avec ces données.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSearchReservation_Click(object sender, EventArgs e)
        {
            int Id_Salles = int.Parse(textBoxSearchIDRoom.Text.Trim());
            DateTime Date = dateTimePicker1.Value.Date; // Obtenez uniquement la date sans l'heure
            TimeSpan Time = TimeSpan.Parse(textBoxSearchHour.Text.Trim()); // Convertissez la chaîne d'heure en TimeSpan

            if (!string.IsNullOrWhiteSpace(textBoxSearchIDRoom.Text) && dateTimePicker1.Value != null && !string.IsNullOrWhiteSpace(textBoxSearchHour.Text))
            {
                await SearchReservation(Id_Salles, Date, Time);
            }
            else
            {
                LoadReservationData();
            }
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridViewReservation_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];

                // Stocker la valeur de la colonne 3 (Index 2) dans textBoxDeleteHour
                textBoxDeleteHour.Text = row.Cells[3].Value.ToString();
                selectedTime = row.Cells[3].Value.ToString();

                Console.WriteLine(textBoxDeleteHour.Text);

                // Stocker la valeur de la colonne 4 (Index 3) dans textBoxDeleteIDRoom
                textBoxDeleteIDRoom.Text = row.Cells[4].Value.ToString();
                selectedID = int.Parse(row.Cells[4].Value.ToString());
                Console.WriteLine(textBoxDeleteIDRoom.Text);

                // Stocker la valeur de la colonne 6 (Index 5) dans dateTimePickerDeleteDate
                textBoxDeleteDate.Text = row.Cells[6].Value.ToString();
                selectedDate = row.Cells[6].Value.ToString();
                Console.WriteLine(textBoxDeleteDate.Text);
            }
        }

        private async void buttonDeleteReservation_Click(object sender, EventArgs e)
        {
            // Convertir la chaîne de date en DateTime
            DateTime selectedDateTime = Convert.ToDateTime(selectedDate);

            // Extraire uniquement la date sans l'heure
            DateTime selectedDateOnly = selectedDateTime.Date;
            var Deletedata = new DeleteReservationData
            {
                Date = selectedDateOnly.ToString("yyyy-MM-dd"),
                Time = selectedTime,
                Id_Salles = selectedID,
            };
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            var json = JsonConvert.SerializeObject(Deletedata);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("deleteReservation", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private async void buttonAddReservation_Click(object sender, EventArgs e)
        {
            bool isRoomReserved = await CheckRoomReservation(int.Parse(textBoxAddID.Text), textBoxAddDate.Text, textBoxAddTime.Text);

            if (isRoomReserved)
            {
                MessageBox.Show("La salle est déjà réservée pour cette date et heure.", "Salle Réservée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Sortir de la méthode sans ajouter une nouvelle réservation
            }
            var Adddata = new AddReservationData
            {
                Details = textBoxAddDetails.Text,
                Date = textBoxAddDate.Text,
                Time = textBoxAddTime.Text,
                Id_Salles = int.Parse(textBoxAddID.Text),
                Materiel = GetSelectedMaterial(),
                
            };

            string GetSelectedMaterial()
            {
                // Vérifier s'il y a un élément sélectionné
                if (checkedListBoxChoseMaterial.CheckedItems.Count > 0)
                {
                    // Récupérer et retourner la première valeur cochée
                    return checkedListBoxChoseMaterial.CheckedItems[0].ToString();
                }
                else
                {
                    // Si aucun élément n'est sélectionné, retourner une chaîne vide ou une valeur par défaut
                    return ""; // Ou vous pouvez retourner null ou une autre valeur par défaut selon votre logique
                }
            }

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            var json = JsonConvert.SerializeObject(Adddata);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("addReservation", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("finally");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private async Task<bool> CheckRoomReservation(int roomId, string date, string time)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = new { Id_Salles = roomId, Date = date, Time = time };
                client.BaseAddress = new Uri("http://localhost:3000/");
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("chercherRservation", content);

                if (response.IsSuccessStatusCode)
                {
                    // Si la salle est déjà réservée, retourner true
                    return true;
                }
                else
                {
                    // Si la salle n'est pas réservée, retourner false
                    return false;
                }
            }
        }

    }
    
}