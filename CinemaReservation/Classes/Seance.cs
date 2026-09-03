using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes
{
    internal class Seance
    {
        private static int _compteur = 0;

        public int Id { get; private set; }
        public DateTime DateHeure { get; private set; }
        public Film Film { get; private set; }
        public Salle Salle { get; private set; }
        public Seance(DateTime dateHeure, Film film, Salle salle)
        {
            Id = ++_compteur;
            DateHeure = dateHeure;
            Film = film;
            Salle = salle;
        }
    }
}
