using System;
using JogoRPG.Entities;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 462, 749, 72, 72);
            Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 325, 601, 474, 482);
            Wizard topapa = new Wizard("Topapa", 77, "Black Wizard", 106, 801, 611, 1542);
            Ninja wedge = new Ninja("Wedge", 51, "Ninja", 292, 574, 89, 89);
            Console.WriteLine("Let it go!");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica.Attack(300));
            Console.WriteLine(topapa.Attack(100));  
            Console.WriteLine(wedge.Attack());          
        }
    }
}
