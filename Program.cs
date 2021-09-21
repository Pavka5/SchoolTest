using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int FrogHealth = rd.Next(1, 10);

            Prvocisla prvocisla = new Prvocisla();
            Console.Write("Zadej délku pole: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            prvocisla.NajdiPrvocislo(Length);
            Console.WriteLine();
            Console.WriteLine();

            PoleMinMax pole = new PoleMinMax();
            pole.MinMax(Length);
            Console.WriteLine();

            Avenger.Smallfrog smallfrog = new Avenger.Smallfrog("Karel", FrogHealth);
            Avenger avenger = new Avenger("Iron Man", 8, 150, 15, false);
            avenger.Defend();
            avenger.Attack(smallfrog);
            avenger.Run();
            avenger.Greetings();
        }
    }
}
