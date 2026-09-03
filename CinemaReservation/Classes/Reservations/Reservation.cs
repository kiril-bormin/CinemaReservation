using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Classes.Reservations
{
    internal abstract class Reservation
    {

        public int Id {  get; private set; }
        public decimal Tarif {  get; private set; }
        public Siege Siege { get; private set; }
        public Client Client { get; private set; }
        public Seance Seance { get; private set; }
        public DateTime DateAchat { get; private set; }
        public Reservation(int id, decimal tarif, DateTime dateAchat, Client client, Seance seance, Siege siege)
        {
            Id = id;
            Tarif = tarif;
            DateAchat = dateAchat;
            Client = client;
            Siege = siege;
            Seance = seance;
        }
    protected abstract decimal CalculerPrix();

    }
}
