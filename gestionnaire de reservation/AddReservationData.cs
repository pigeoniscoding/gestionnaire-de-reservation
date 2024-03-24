using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionnaire_de_reservation
{
    internal class AddReservationData
    {
        public string Details { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Id_Salles { get; set; }
        public string Materiel { get; set; }
        
    }
}
