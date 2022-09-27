using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_program2
{
    internal class DateAdd
    {
        private uint[] dateAdd = new uint[3];
        public void AddDay(uint day, uint month, uint year)
        {
            Date date = new Date();
            dateAdd[0] = day;
            dateAdd[1] = month;
            dateAdd[2] = year;

            ++dateAdd[0];

            switch (date.Month(dateAdd[1]))
            {
                case 31:
                    if (dateAdd[0] != 0 && dateAdd[0] <= 31)
                    {
                        aproveMesaje();
                    }
                    else
                    {
                        moveDate();
                    }
                    break;
                case 30:
                    if (dateAdd[0] != 0 && dateAdd[0] <= 30)
                    {
                        aproveMesaje();
                    }
                    else
                    {
                        moveDate();
                    }
                    break;
                case 29:
                    if (dateAdd[0] != 0 && dateAdd[0] <= 29)
                    {
                        aproveMesaje();
                    }
                    else
                    {
                        moveDate();
                    }
                    break;
                case 28:
                    if (dateAdd[0] != 0 && dateAdd[0] <= 28)
                    {
                        aproveMesaje();
                    }
                    else
                    {
                        moveDate();
                    }
                    break;
            }
        
        }

        private void moveDate()
        {
            if (dateAdd[1].Equals(12))
            {
                dateAdd[0] = 1;
                dateAdd[1] = 1;
                dateAdd[2]++;
                aproveMesaje();
            }
            else
            {
                dateAdd[0] = 1;
                dateAdd[1]++;
                aproveMesaje();
            }
        }

        private void aproveMesaje()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("fecha correcta!");
            Console.ResetColor();
            Console.WriteLine(dateAdd[0] + "/" + dateAdd[1] + "/" + dateAdd[2]);
        }
    }
}
