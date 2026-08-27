using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes
{
    internal class Salle
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public Salle(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
