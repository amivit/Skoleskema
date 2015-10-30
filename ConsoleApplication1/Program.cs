using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[,] skema = new string[,]
            {
                {"Første Semester", "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag"},
                {"9:15 - 10:00", "PROG", "DB", "PROG", "SYS", "PROG"},
                {"10:15 - 11:00", "PROG", "DB", "PROG", "SYS", "PROG"},
                {"11:15 - 12:00", "PROG", "DB", "PROG", "SYS", "PROG"},
                {"12:30 - 13:15", "PROG", "DB", "PROG", "SYS", "Fredagscafe"},
                {"13:30 - 14:15", "ITO", "Lektiecafe", "-", "Lektiecafe", "Fredagscafe"},
                {"14:30 - 15:15", "ITO", "Lektiecafe", "-", "Lektiecafe", "Fredagscafe"},
            };
            for (int row = 0; row < (skema.GetLength(0)); row++)
            {
                for (int col = 0; col < (skema.GetLength(1)); col++)
                {
                    Console.Write(skema[row, col].PadLeft(18));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}