using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();
            int num =Convert.ToInt32(rnd.Next(0,100)); 
            Console.WriteLine("Welcome to the guess game, think of a number");
            while(true)
            {
                Console.WriteLine("My Guess is: " + num + " If lower, write L, higer, H or E");
                char a = Convert.ToChar(Console.ReadLine());
                if(a == 'L')
                {
                    num = rnd.Next(0,num);
                }
                if(a == 'H')    
                {
                    num = rnd.Next(num,100);
                }
                if(a == 'E')
                {
                    Console.WriteLine("I am genius PC ");
                    break;
                }

            }
}
}
}
