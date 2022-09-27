using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_program2
{
    internal class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Ingrese una fecha a dos digitos");
            string value = Console.ReadLine();

            Date date = new Date();
            date.DateValidation(value);
        }
    }
}
