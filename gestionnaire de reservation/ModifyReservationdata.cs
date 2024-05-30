using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionnaire_de_reservation
{
    internal class ModifyReservationdata
    {
        public int Id_Reservation { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Id_Salles { get; set; }
    }
}
