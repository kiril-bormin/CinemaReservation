using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation
{
    internal class Seance
    {
        public int Id { get; private set; }
        public TimeOnly Heure { get; private set; }
        public DateOnly Date { get; private set; }

        public Seance(int id, TimeOnly heure, DateOnly date)
        {
            Id = id;
            Heure = heure;
            Date = date;
        }
    }
}
