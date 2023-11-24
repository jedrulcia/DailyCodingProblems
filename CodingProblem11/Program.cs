using System.Diagnostics.Tracing;
using System.Security;

namespace CodingProblem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] tab = { { 'F', 'A', 'C', 'I' },
                            { 'O', 'B', 'Q', 'P' },
                            { 'A', 'N', 'O', 'B' },
                            { 'M', 'A', 'S', 'S' } };
            string word = "OBQP";
            bool answer = false;
            answer = HorizontalWords(tab, word);
            if (answer == true)
            {
                Console.Write(answer);
            }
            else
            {
                answer = VerticalWords(tab, word);
                Console.Write(answer);
            }
        }
        static bool HorizontalWords(char[,] tab, string word)       // Method to compare the given word to the horizontal words of the matrix
        {
            string holder = "";
            for (int i = 0; i < tab.GetLength(0); i++)          
            {
                holder = "";
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    holder = holder + tab[i, j];
                }
                if (holder == word)
                {
                    return true;
                }
            }
            return false;
        }
        static bool VerticalWords(char[,] tab, string word)         // Method to compare the given word to the vertical words of the matrix
        {
            string holder = "";
            for (int i = 0; i < tab.GetLength(1); i++)
            {
                holder = "";
                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    holder = holder + tab[j, i];
                }
                if (holder == word)
                {
                    return true;
                }
            }
            return false;
        }
    }
}