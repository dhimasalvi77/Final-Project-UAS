
using System;

namespace Abstraction
{
    class game
    {
        private int number = 13;  //private member:
        public int attempt;

        public void guess() //public method :
        {
            Console.WriteLine("Masukin Tebakan Mu: ");
            do //repeat this statement:
            {
                attempt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coba Lagi: ");
            }
            while (attempt != number);  //until user enter 13;
            Console.WriteLine("Yeay Benar Kamu Dapet Iphone11:");
        }
    }


    class Program    //our Main class:
    {
        static void Main(string[] args)
        {
            game Game = new game();  //Object of Class game:
            Game.guess();  //calling method:


            Console.ReadKey();
        }
    }
}