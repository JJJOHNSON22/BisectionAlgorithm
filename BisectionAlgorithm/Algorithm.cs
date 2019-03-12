using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Algorithm
    {
        public int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int BasicBisection(int[] list, int userNum)
        {
            UserInput number = new UserInput();
            int leftNum = 0;
            int rightNum = list.Length - 1;

            //Takes the array and cuts it in half based on the value given
            while (leftNum <= rightNum)
            {
                //finding the middle number in the current array
                int middleNum = leftNum + (rightNum - leftNum) / 2;

                //checks to see if the user number is on the small end of the array
                if (list[middleNum] > userNum)
                {
                    rightNum = middleNum - 1;
                    Console.WriteLine($"The new array to check is [{leftNum},{rightNum}].\n");
                }
                //checks to see if the user number is on the big end of the array
                else if (list[middleNum] < userNum)
                {
                    leftNum = middleNum + 1;
                    Console.WriteLine($"The new array to check is [{leftNum},{rightNum}].\n");
                }
                //returns the middle number to narrow down the search
                else
                {
                    Console.WriteLine($"The number is {userNum}.\n");
                    Console.ReadLine();
                    return middleNum;
                }
            }
            return 0;
        }

        public void HumanGuess()
        {
            Console.Clear();
            int userGuess = -1;
            int attempts = 1;
            Random rnd = new Random();
            int cpuNumber = rnd.Next(0, 1000);
            Console.WriteLine("Now the computer has selected a random number between 0 and 1000.\n");
            Console.WriteLine("Try to guess the number the computer will give you hints with each guess.");
            Console.ReadLine();
            while (userGuess != cpuNumber)
            {
                try
                {
                    Console.Clear();
                    //test
                    //Console.WriteLine(cpuNumber);
                    Console.WriteLine($"Try to guess the number, this is attempt {attempts}.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess > 0 && userGuess < 1001)
                    {
                        Console.WriteLine($"The number selected is {userGuess}\n");

                        //checks to see if the user number is correct
                        if (userGuess == cpuNumber)
                        {
                            Console.WriteLine($"You guessed right, the number is {userGuess}!\n");
                            Console.WriteLine($"It took you {attempts} attempts to get it right.");
                        }
                        //checks to see if the user number is too big
                        else if (cpuNumber < userGuess)
                        {
                            Console.WriteLine($"You guessed too high\n");
                            attempts++;
                        }
                        //checks to see if the user number is too low
                        else if (cpuNumber > userGuess)
                        {
                            Console.WriteLine($"You guessed too low.\n");
                            attempts++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.\n");
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input\n");
                    Console.ReadLine();
                }

                Console.ReadKey();
            }

        }

        public void ComputerGuess()
        {
            Console.Clear();
            Console.WriteLine($"Now the computer will attempt to guess the number that you have selected.\n");
            Console.WriteLine($"Please pick a number between 1 and 100.");
            int userNum = 0;
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 101)
                {
                    Console.WriteLine($"The number selected is {userNum}\n");
                    int leftNum = 0;
                    int rightNum = 100;
                    int middleNum = -1;
                    int cpuAtempts = 1;
                    while (userNum != middleNum)
                    {
                        middleNum = leftNum + (rightNum - leftNum) / 2;

                        if (middleNum > userNum)
                        {
                            rightNum = middleNum;
                            Console.WriteLine($"The computer guessed {middleNum}.");
                            Console.WriteLine($"The new range to check is {leftNum} - {rightNum}.\n");
                            cpuAtempts++;
                        }
                        else if (middleNum < userNum)
                        {
                            leftNum = middleNum;
                            Console.WriteLine($"The computer guessed {middleNum}.");
                            Console.WriteLine($"The new range to check is {leftNum} - {rightNum}.\n");
                            cpuAtempts++;
                        }
                        else
                        {
                            Console.WriteLine($"The Computer guessed the number {userNum} right with {cpuAtempts} attempts.\n");
                            Console.ReadLine();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n");
                    Console.ReadLine();
                    ComputerGuess();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input\n");
                Console.ReadLine();
                ComputerGuess();
            }
        }
    }
}
