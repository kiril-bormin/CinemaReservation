using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes
{
    internal class Salle
    {
        private int _compteur = 0;
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public Salle(string nom)
        {
            Id = _compteur++;
            Nom = nom;
        }
    }
}
