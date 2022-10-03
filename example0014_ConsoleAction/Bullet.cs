using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
    struct Bullet
    {
        public int x;
        public int y;
        // + Direction
 
        public static void MoveBullet(int dx, int dy, ref Bullet b)
        {
            b.x += dx;
            b.y += dy;
        }
        public static void BulletWay(int x, int y, ref Bullet b)
        {
            if (Program.wasRight)
            {
                for (int i = x; i < Console.BufferWidth; i += 3)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("*");
                    System.Threading.Thread.Sleep(25);
                    Console.SetCursorPosition(i, y);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(25);
                }
            }
            if (Program.wasLeft)
            {
                for (int i = x; i > 0; i -= 3)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("*");
                    System.Threading.Thread.Sleep(25);
                    Console.SetCursorPosition(i, y);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(25);
                }
            }
            if (Program.wasUp)
            {
                for (int i = y; i > 0; i -= 3)
                {
                    Console.SetCursorPosition(x, i);
                    Console.Write("*");
                    System.Threading.Thread.Sleep(25);
                    Console.SetCursorPosition(x, i);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(25);
                }
            }
            if (Program.wasDown)
            {
                for (int i = y; i < Console.BufferHeight; i += 3)
                {
                    Console.SetCursorPosition(x, i);
                    Console.Write("*");
                    System.Threading.Thread.Sleep(25);
                    Console.SetCursorPosition(x, i);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(25);
                }
            }
        }
    }
}