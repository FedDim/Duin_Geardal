using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duin_Geardâl.Генерація
{
    internal class Комната
    {
        public char[,] Карта { get; set; }

        public int Ширина { get; set; }

        public int Длина { get; set; }

        public Комната()
        {
            Random random = new Random();

            Ширина = random.Next(5, 14);
            Длина = random.Next(5, 14);

            Карта = new char[Ширина, Длина];

            for(int y = 0; y < Длина; y++)
            {
                for (int x = 0; x < Ширина; x++)
                {
                    Карта[x, y] = ' ';
                }
            }

            int возможныеТочки = random.Next(4, (Ширина + Длина) / 2 + 1);

            while(возможныеТочки > 0)
            {
                int x = random.Next(0, Ширина);
                int y = random.Next(0, Длина);

                if (Карта[x, y] != '#')
                {
                    Карта[x, y] = '#';
                    возможныеТочки--;
                }
            }
        }
    }
}
