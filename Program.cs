using System;

namespace russianroulette
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = "yes";
            
            while(sex == "yes")
            {
                Random nmb = new Random();
                int random_number = Convert.ToInt32(nmb.Next(1,6));

                Console.Write("What is your nubmer (1-6): ");
                int user_number = Convert.ToInt32(Console.ReadLine());

                if (user_number > 6)
                {
                    Console.WriteLine("Number exceeded 6 try again.\n");
                    continue;
                }
                else if (user_number == random_number)
                {
                    Console.WriteLine("You died the number was " + random_number + "\n");
                    Console.WriteLine("Quitting...");
                    break;
                }
                else if (user_number != random_number)
                {
                    Console.WriteLine("You survied the number was " + random_number + "\n");
                }
            }
            

        }
    }
}
