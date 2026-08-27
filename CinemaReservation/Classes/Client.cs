using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes
{
    internal class Client
    {
        public int Id { get; private set; }
        public string Prenom { get; private set; }
        public string Nom { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        public string NumeroTelephone { get; private set; }

        public Client(int id, string prenom, string nom, int age, string email, string numeroTelephone)
        {
            Id = id;
            Prenom = prenom;
            Nom = nom;
            Age = age;
            Email = email;
            NumeroTelephone = numeroTelephone;
        }

    }
}
