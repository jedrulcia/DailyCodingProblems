using System;
using System.Security.AccessControl;

namespace CodingProblem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 5;                                                                  // Size of the chessboard
            char[,] chessboard = new char[m, m];
            int n = 4;                                                                  // Number of bishops

            int[,] bishopsList = GenerateBishops(n, m);
            chessboard = AssignBishops(bishopsList, chessboard, m);
            int numberOfAttacks = NumberOfAttacks(bishopsList, m);

            Console.WriteLine("Number of attacks: " + numberOfAttacks);
        }

        static int[,] GenerateBishops(int n, int m)                                     // Method which generates bishops                              
        {
            Random random = new Random();
            int[,] bishopsList = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                bishopsList[i, 0] = random.Next(m);
                bishopsList[i, 1] = random.Next(m);
            }
            bishopsList = DeleteDuplicatedBishops(n, m, bishopsList);
            return bishopsList;
        }

        static int[,] DeleteDuplicatedBishops(int n, int m, int[,] bishopsList)         // This method deletes duplicated bishops
        {
            Random random = new Random();
            bool needCheck = true;
            while (needCheck == true)
            {
                needCheck = false;
                for (int i = 0; i < bishopsList.Length / 2; i++)
                {
                    for (int j = i + 1; j < bishopsList.Length / 2; j++)
                    {
                        if (bishopsList[i, 0] == bishopsList[j, 0] && bishopsList[i, 1] == bishopsList[j, 1])
                        {
                            bishopsList[j, 0] = random.Next(m);
                            bishopsList[j, 1] = random.Next(m);
                            needCheck = true;
                        }
                    }
                }
            }
            return bishopsList;
        }
        static char[,] AssignBishops(int[,] bishopsList, char[,] chessboard, int m)     // This method is to assign the bishops to their places on the chessboard
        {
            for (int i = 0; i < bishopsList.Length/2; i++)
            {
                Console.Write(bishopsList[i, 0]);                                       // Those lines show how bishops were generated
                Console.Write(bishopsList[i, 1]);
                Console.WriteLine();

                chessboard[bishopsList[i, 0], bishopsList[i, 1]] = 'b';                 // This line assigns the bishop to the chessboard
            }
            Console.WriteLine();                                                        // Those loops show the chessboard with the bishops on the screen
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (chessboard[i,j] != 'b')                                         // This statement puts the '-' character to the empty places of the chessboard (those without bishops)
                    {
                        chessboard[i, j] = '-';
                    }
                    Console.Write(chessboard[i, j]);
                }
                Console.WriteLine();
            }
            return chessboard;
        }
        static int NumberOfAttacks(int[,] bishopsList, int m)                           // This method counts the number of bishop pairs, that are placed diagonally to each other (Bishops that attack each other)
        {
            int sum = 0;
            for (int i = 0; i < bishopsList.Length / 2; i++)
            {
                for(int j = i + 1; j < bishopsList.Length/2; j++)
                {
                    if (Math.Abs(bishopsList[i, 0] - bishopsList[j, 0]) == Math.Abs(bishopsList[i, 1] - bishopsList[j, 1]) && i != j)
                    {
                        sum++;
                    }
                }

            }

            return sum;
        }
    }
}