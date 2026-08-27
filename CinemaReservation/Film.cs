using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation
{
    internal class Film
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Realisateur { get; private set; }
        public string Genre { get; private set; }
        public TimeSpan Duree { get; private set; }
        public int AgeLegal { get; private set; }

        public Film(int id, string nom, string realisateur, string genre, TimeSpan duree, int age_legal)
        {
            this.Id = id;
            this.Nom = nom;
            this.Realisateur = realisateur;
            this.Genre = genre;
            this.Duree = duree;
            this.AgeLegal = age_legal;
        }
    }
}
