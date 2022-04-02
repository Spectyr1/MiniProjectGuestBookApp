using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook
{
    public static class Controls
    {
        public static string GetName()
        {
            Console.Write("Please enter your family name: ");
            return Console.ReadLine();
        }

        public static int GetGroupSize()
        {
            bool validInt = true;
            int size;
            do
            {
                if (validInt == true)
                {
                    Console.Write("Please enter the size of your party: ");
                    validInt = false;
                }
                else
                {
                    Console.Write("That was not a Valid entry. Please enter the size of your party: ");
                }
                
                validInt = int.TryParse(Console.ReadLine(), out size);
            } while (validInt != true);

            return size;
        }

        public static int AddParty(int current, int toAdd)
        {
            int newTotal = current + toAdd;
            return newTotal;
        }

        public static void SeeLog(List<string> names, int size)
        {
            Console.WriteLine("Here is the list of who came to the party: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"You had a total of {size} people show up.");
        }
    }
}
