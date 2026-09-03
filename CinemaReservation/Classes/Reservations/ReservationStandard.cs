using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes.Reservations
{
    internal class ReservationStandard : Reservation
    {
        public ReservationStandard(int id, DateTime dateAchat, Client client, Seance seance, Siege siege)
            : base(id, 16.00m, dateAchat, client, seance, siege)
        {
        }
        protected override decimal CalculerPrix()
        {
            return Tarif;
        }
    }
}
