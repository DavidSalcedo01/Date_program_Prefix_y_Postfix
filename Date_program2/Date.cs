using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Date_program2
{
    internal class Date
    {
        private uint[] splitDate = new uint[3];
        private readonly uint[] month31 = { 1, 3, 5, 7, 8, 10, 12 };
        private readonly uint[] month30 = { 4, 6, 9, 11 };
        public void DateValidation(string Value)
        {
            int l = 0;
            string[] split = Value.Split('/');
            for (int i = 0; i < split.Length; i++)
            {
                try
                {
                    splitDate[l] = uint.Parse(split[i]);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("!- Ingrese solo numeros -!");
                    Thread.Sleep(1000);
                    Program.Main();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("!- Ingrese una fecha real -!");
                    Thread.Sleep(1000);
                    Program.Main();
                }
                l++;
            }
            Day(splitDate[0]);
        }

        public void Day(uint day)
        {
            switch (Month(splitDate[1]))
            {
                case 31:
                        if (splitDate[0] != 0 && splitDate[0] <= 31)
                        {
                            messaje(true);
                        }
                        else
                        {
                            messaje(false);
                        }
                    break;
                case 30:
                        if (splitDate[0] != 0 && splitDate[0] <= 30)
                        {
                            messaje(true);
                        }
                        else
                        {
                            messaje(false);

                        }
                    break;
                case 29:
                        if (splitDate[0] != 0 && splitDate[0] <= 29)
                        {
                            messaje(true);
                        }
                        else
                        {
                            messaje(false);
                        }
                    break;
                case 28:
                        if (splitDate[0] != 0 && splitDate[0] <= 28)
                        {
                            messaje(true);
                        }
                        else
                        {
                            messaje(false);
                        }
                    break;
            }
            
        }
        public uint Month(uint month)
        {
            if (month != 0 && month <= 12)
            {
                for (int i = 0; i < month31.Length; i++)
                {
                    if (month == month31[i])
                    {
                        return 31;
                    }

                }
                for (int l = 0; l < month30.Length; l++)
                {
                    if (month == month30[l])
                    {
                        return 30;
                    }
                }

                if (month.Equals(2))
                {
                    if (Year(splitDate[2]))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
            }
            else
            {
                messaje(false);
                return 0;
            }
            return 0;
        }
        private bool Year(uint year)
        {
            if ((year % 4) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void messaje(bool v)
        {
            if(v)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("fecha correcta!");
                Thread.Sleep(1200);
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Desea agregar un dia a la fecha escrita?");
                string val = (Console.ReadLine());

                int comp = String.Compare(val, "si", true);
                if(comp.Equals(0))
                {
                    DateAdd dateAdd = new DateAdd();
                    dateAdd.AddDay(splitDate[0], splitDate[1], splitDate[2]);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("fecha correcta!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("fecha incorrecta!");
                Thread.Sleep(1500);
                Program.Main();
            }
        }
    }
}

