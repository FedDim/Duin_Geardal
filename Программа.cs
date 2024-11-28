using Duin_Geardâl.Генерація;
using System;


namespace Duin_Geardâl
{
    internal class Программа
    {
        static void Main(string[] args)
        {
            Комната комната = new Комната();

            // Выводъ Результата
            for (int y = 0; y < комната.Длина; y++)
            {
                for (int x = 0; x < комната.Ширина; x++)
                {
                    Console.Write(комната.Карта[x, y]);
                }
                Console.WriteLine();
            }

            

        }

    }
}
