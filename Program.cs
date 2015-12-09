using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber = ranNumberGenerator.Next(1, 11);
            Console.Write("Guess a number: ");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            if (selectedNumber < randomNumber)
            {
                Console.WriteLine(randomNumber);
                Console.WriteLine("Your guess was too low by {0} places", randomNumber - selectedNumber);
            }
            else if (selectedNumber > randomNumber)
            {
                Console.WriteLine(randomNumber);
                Console.WriteLine("Your guess was too high by {0} places", selectedNumber - randomNumber);
            }
            else if (selectedNumber == randomNumber)
            {
                Console.WriteLine(randomNumber);
                Console.WriteLine("Your guess was correct");
            }
}
    }
}
