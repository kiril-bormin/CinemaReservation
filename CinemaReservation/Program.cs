using CinemaReservation.Classes;

namespace CinemaReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Film Odysee = new Film(1, "Odysse", "Nolan", "Action", TimeSpan.FromMinutes(243), 15);

            Console.WriteLine(Odysee.Duree);

            Console.ReadLine();
        }
    }
}
