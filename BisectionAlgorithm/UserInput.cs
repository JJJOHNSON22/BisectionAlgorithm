using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class UserInput
    {
        public int userNum = 0;
        public int UserNumber()
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 11)
                {
                    Console.WriteLine($"The number selected is {userNum}\n");
                    return userNum;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n");
                    Console.ReadLine();
                    UserNumber();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input\n");
                Console.ReadLine();
                UserNumber();
            }
            return userNum;
        }
    }
}
