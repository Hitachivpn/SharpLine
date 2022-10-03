using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
    class UI
    {
        //const int minWidth = 15;
        //const int maxWidth = 50;
        //const int minHeight = 10;
        //const int maxHeight = 50;
 
        public static void GetHero(out Hero h)
        {
            h.x = 10;
            h.y = 10;
            h.symbol = '0';
        }
 
        static int pointPosTop;
        static int pointPosLeft;
 
        public static void ShowHero(Hero h)
        {
            Console.SetCursorPosition(h.x, h.y);
            Console.Write(h.symbol);
            pointPosTop = Console.CursorTop;    // сохранение позиции по вертикали
            pointPosLeft = Console.CursorLeft;
        }
        public static void ShowBullet(Bullet b)
        {
 
            Console.SetCursorPosition(b.x, b.y);
            Console.Write(".", b.x, b.y);
        }
        public static void GetEnemy(out Enemy e)
        {
            e.x = Randomizer.GetRandomCoord(10, 70);
            e.y = Randomizer.GetRandomCoord(10, 50);
           
        }
        public static void ShowEnemy(Enemy e)
        {
            Console.SetCursorPosition(e.x, e.y);
            Console.Write("E", e.x, e.y);
            Console.SetCursorPosition(pointPosLeft, pointPosTop);
        }
 
        public static void HideEnemy(Enemy e)
        {
            Console.SetCursorPosition(e.x, e.y);
            Console.Write(' ');
            Console.SetCursorPosition(pointPosLeft, pointPosTop);
        }
    }
}