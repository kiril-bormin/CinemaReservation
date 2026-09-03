using CinemaReservation.Classes;
using CinemaReservation.Classes.Reservations;

namespace CinemaReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Salle SalleA1 = new Salle("Grande Salle étage 1");

            Siege SiegeA1 = new Siege("première", 01, "Standard", 16);

            Film Odysee = new Film(1, "Odysse", "Nolan", "Action", TimeSpan.FromMinutes(243), 15);

            DateTime horaire = new DateTime(2026, 9, 15, 20, 30, 0);
            Seance Avatar_03092026_1200 = new Seance(horaire, Odysee, SalleA1);

            Client clientAlice = new Client("Alice", "Wonderfull", 23, "alicewonderfull@etml.net", "076 454 32 33" );


            var maReservation = new ReservationStandard(1, DateTime.Now, clientAlice, Avatar_03092026_1200, SiegeA1);

            Console.WriteLine(maReservation.DateAchat);

            Console.ReadLine();
        }
    }
}
