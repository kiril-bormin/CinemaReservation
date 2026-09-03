using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes.Reservations
{
    internal class ReservationEnfant : Reservation
    {
        public ReservationEnfant(int id, DateTime dateAchat, Client client, Seance seance, Siege siege)
        : base(id, 8.00m, dateAchat, client, seance, siege)
        {
        }
        protected override decimal CalculerPrix()
        {
            return Tarif;
        }
    }
}

