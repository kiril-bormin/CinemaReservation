using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes
{
    internal class Siege
    {

        public int Id { get; private set; }
        public string Rangee { get; private set; }
        public int Numero { get; private set; }
        public string Classe { get; private set; }
        public int Prix { get; private set; }
        public Siege(int id, string rangee, int numero, string classe, int prix)
        {
            Id = id;
            Rangee = rangee;
            Numero = numero;
            Classe = classe;
            Prix = prix;
        }

    }
}
