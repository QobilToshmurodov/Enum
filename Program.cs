using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.Program;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Importance qiymatini kiriting (None, Trivial, Regular, Important, Critical):");
            string input = Console.ReadLine();
            Importance result = (Importance)System.Enum.Parse(typeof(Importance), "Critical");
            if (result == Importance.Critical)
            {
                Console.WriteLine("O'ta muhim!");
            }
            else
            {
                Console.WriteLine($"Kiritilgan qiymat: {result}");
            }
        }
        public enum Importance
        {

            None,
            Trivial,
            Regular,
            Important,
            Critical
        }
    }
}