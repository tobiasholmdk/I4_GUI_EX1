using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();
            double num = rnd.Next(0,100);
            Console.WriteLine("Welcome to the guess game, guess your number below: ");
            double guess = Convert.ToDouble(Console.ReadLine());
            while(guess != num)
            {
                if(guess > num)
                {
                    Console.WriteLine("Guess to high: "+ guess);
                }
                if(guess < num)
                {
                    Console.WriteLine("Guess to low: "+ guess);
                }
            guess = Convert.ToDouble(Console.ReadLine());
            }
         Console.WriteLine("Guess is correct, well done. Correct number was: " + num);
        }
    }
}
