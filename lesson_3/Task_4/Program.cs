using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] fieldWithShips = new string[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    fieldWithShips[i, j] = "O";
                }
            }
            FieldOutput(fieldWithShips);
            Console.WriteLine();
            InputDataShip(3, 2, ref fieldWithShips);
            Console.ReadLine();
        }

        static void InputDataShip(int sizeOfShips, int numberOfShips, ref string[,] fieldWithShips)
        {
            int coordinates;
            int orientation;

            for (int i = 0; i < numberOfShips; i++)
            {
                do
                {
                    do
                    {
                        Console.WriteLine($"Количество палуб корабля: {sizeOfShips}. Введите двузначную координату начала корабля");
                        Console.WriteLine("Пример: По вертикали - 5, по горизонтали - 3 => число 53");
                    }
                    while (!Int32.TryParse(Console.ReadLine(), out coordinates) || coordinates < 0 || coordinates > 99);

                    do
                    {
                        Console.WriteLine("Укажите ориентацию корабля. По горизонтали 0, по вертикали 1");
                    }
                    while (!Int32.TryParse(Console.ReadLine(), out orientation));

                }
                while (!ShipPlacement(sizeOfShips, coordinates, orientation, ref fieldWithShips));
                
                FieldOutput(fieldWithShips);
            }

        }

        static void FieldOutput(string [,] fieldWithShips) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");
            Console.WriteLine("  -----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < fieldWithShips.GetLength(0); i++)
            {

                Console.ForegroundColor = ConsoleColor.Red; 
                Console.Write(" " + i + " |");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < fieldWithShips.GetLength(1); j++)
                {
                    if(fieldWithShips[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" " + fieldWithShips[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    } else   Console.Write(" " + fieldWithShips[i, j]);
                    Console.Write(" |");
                }
                Console.WriteLine();
                Console.WriteLine("  -----------------------------------------");
            }
        }

        static bool ShipPlacement(int size, int coordinates, int orientation, ref string[,] fieldWithShips)
        {
            if (orientation == 0)
            {
                for (int i = coordinates % 10; i < (coordinates % 10 + size); i++)
                {
                    if (i == 10 || fieldWithShips[coordinates / 10, i] == "X")
                    {
                        Console.WriteLine("Нельзя установить корабль. Повторите ввод");
                        return false;
                    }
                    fieldWithShips[coordinates / 10, i] = "X";
                }
            } 
            else
            {
                for (int i = coordinates / 10; i < (coordinates / 10 + size); i++)
                {
                    if (i == 10 || fieldWithShips[i, coordinates % 10] == "X")
                    {
                        Console.WriteLine("Нельзя установить корабль. Повторите ввод");
                        return false;
                    }
                    fieldWithShips[i, coordinates % 10] = "X";
                }
            }
            
            return true;
        } 
    }
}
