using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation
{
    internal class Reservation
    {

        public int Id {  get; private set; }
        public int Tarif {  get; private set; }
        public int PrixPayee { get; private set; }
        public DateTime DateAchat { get; private set; }
        public Reservation(int id, int tarif, int prixPayee, DateTime dateAchat)
        {
            Id = id;
            Tarif = tarif;
            PrixPayee = prixPayee;
            DateAchat = dateAchat;
        }
    }
}
