using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
 
    struct Hero
    {
        public int x;
        public int y;
        public char symbol;
 
        public static void MoveHero(int dx, int dy, ref Hero h)
        {
            h.x += dx;
            h.y += dy;
        }
        public static void ClearHero(Hero h, ConsoleKey keyPressed)
        {
            switch (keyPressed)
            {
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(h.x + 1, h.y);
                    Console.Write(" ");
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(h.x - 1, h.y);
                    Console.Write(" ");
                    break;
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(h.x, h.y + 1);
                    Console.Write(" ");
                    break;
                case ConsoleKey.DownArrow:
                    Console.SetCursorPosition(h.x, h.y - 1);
                    Console.Write(" ");
                    break;
                default:
                    break;
            }
        }
    }
}