using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool wholeGame = true;

            while (wholeGame)
            {
                string[] myArray = new string[9];
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = i.ToString();
                }
                DrawGrid(myArray);
                bool ticTacToe = true;
                while (ticTacToe)
                {
                    Player1(myArray);
                    DrawGrid(myArray);
                    if (!(ticTacToe = Solution(myArray)))
                    {
                        break;
                    }

                    if (tieGame1(myArray) == true)
                    {
                        break;
                    }

                    Player2(myArray);
                    DrawGrid(myArray);
                    ticTacToe = Solution(myArray);
                }
                //Console.ReadLine();

                Console.WriteLine("Would you like to play again? (y/n)");
                string answer = Console.ReadLine();
                    if (answer.Substring(0, 1).ToLower() == "n")
                        wholeGame = false;
                    else
                    {
                    DrawGrid(myArray);
                }

            }
        }
        static void MyMethod(string stuff)
        {
            Console.WriteLine(stuff);
        }
        static void DrawGrid(string[] methodArray)
        {
            MyMethod(string.Format("{0} {1} {2}", methodArray[0], methodArray[1], methodArray[2]));
            MyMethod(string.Format("{0} {1} {2}", "-", "-", "-"));
            MyMethod(string.Format("{0} {1} {2}", methodArray[3], methodArray[4], methodArray[5]));
            MyMethod(string.Format("{0} {1} {2}", "-", "-", "-"));
            MyMethod(string.Format("{0} {1} {2}", methodArray[6], methodArray[7], methodArray[8]));
            MyMethod(string.Format("{0} {1} {2}", " ", " ", " "));
        }
        static void Player1(string[] method2Array)
        {
            Console.WriteLine("Player one, please pick a space on the grid (0-8)");
            Console.WriteLine(" ");
            string y = Console.ReadLine();
            Console.WriteLine(" ");
            int intChoice = Convert.ToInt32(y);
            if (check(intChoice, method2Array) == true)
            {
                method2Array[intChoice] = "X";
            }
            else if (check(intChoice, method2Array) == false)
            {
                Console.WriteLine("That has already been selected, please select again.");
                Console.WriteLine(" ");
                Player1(method2Array);
            }

        }
        static void Player2(string[] method3Array)
        {
            Console.WriteLine("Player two, please pick a space on the grid (0-8)");
            Console.WriteLine(" ");
            string y = Console.ReadLine();
            Console.WriteLine(" ");
            int intChoice = Convert.ToInt32(y);
            if (check(intChoice, method3Array) == true)
            {
                method3Array[intChoice] = "O";
            }
            else if (check(intChoice, method3Array) == false)
            {
                Console.WriteLine("That has already been selected, please select again.");
                Console.WriteLine(" ");
                Player2(method3Array);
            }
        }
        static bool check(int intChoice1, string[] checkArray)
        {
            if (checkArray[intChoice1] == "X" || checkArray[intChoice1] == "O")
            {
                return false;
            }
            return true;
        }
        static bool Solution(string[] solutionArray)
        {
            if ((solutionArray[0]) == (solutionArray[1]) && (solutionArray[1]) == (solutionArray[2]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[3]) == (solutionArray[4]) && (solutionArray[4]) == (solutionArray[5]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[6]) == (solutionArray[7]) && (solutionArray[7]) == (solutionArray[8]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[0]) == (solutionArray[3]) && (solutionArray[3]) == (solutionArray[6]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[1]) == (solutionArray[4]) && (solutionArray[4]) == (solutionArray[7]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[2]) == (solutionArray[5]) && (solutionArray[5]) == (solutionArray[8]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[0]) == (solutionArray[4]) && (solutionArray[4]) == (solutionArray[8]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else if ((solutionArray[6]) == (solutionArray[4]) && (solutionArray[4]) == (solutionArray[2]))
            {
                Console.WriteLine("Congratulations! We have a winner!");
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool tieGame1(string[] tieArray)
        {
            for (int i = 0; i < tieArray.Length; i++)
            {
                if (tieArray[i] != "X" && tieArray[i] != "O")
                {    
                    return false;
                }
            }
            Console.WriteLine("Tie Game!");
            return true;
        }
    }
}






































