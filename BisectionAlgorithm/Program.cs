using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput number = new UserInput();
            number.UserNumber();
            Algorithm logic = new Algorithm();
            int[] arr = logic.list;
            int num = number.userNum;
            logic.BasicBisection(arr, num);
            logic.HumanGuess();
            logic.ComputerGuess();
        }
    }
}
