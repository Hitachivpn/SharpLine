using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
    class Program
    {
       public static bool wasLeft,
                          wasUp,
                          wasDown = false;
       public static bool wasRight = true;
        static void Main(string[] args)
        {            
            Hero h3;
            Bullet b3;
            Enemy e3;
            UI.GetHero(out h3);
            UI.GetEnemy(out e3);
            Console.CursorVisible = false;      
            ConsoleKey key = ConsoleKey.Spacebar;
 
            do            
            {
                UI.ShowHero(h3);
 
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
 
                    switch (key)
                    {
                        case ConsoleKey.LeftArrow:
                            Hero.MoveHero(-1, 0, ref h3);
                            Hero.ClearHero(h3, ConsoleKey.LeftArrow);
                            wasLeft = true;
                            wasRight = false;
                            wasUp = false;
                            wasDown = false;
                            break;
                        case ConsoleKey.RightArrow:
                            Hero.MoveHero(1, 0, ref h3);
                            Hero.ClearHero(h3, ConsoleKey.RightArrow);
                            wasLeft = false;
                            wasRight = true;
                            wasUp = false;
                            wasDown = false;
                            break;
                        case ConsoleKey.UpArrow:
                            Hero.MoveHero(0, -1, ref h3);
                            Hero.ClearHero(h3, ConsoleKey.UpArrow);
                            wasLeft = false;
                            wasRight = false;
                            wasUp = true;
                            wasDown = false;
                            break;
                        case ConsoleKey.DownArrow:
                            Hero.MoveHero(0, 1, ref h3);
                            Hero.ClearHero(h3, ConsoleKey.DownArrow);
                            wasLeft = false;
                            wasRight = false;
                            wasUp = false;
                            wasDown = true;
                            break;
                        case ConsoleKey.E:
                            if (wasLeft)
                            {
                                b3.x = h3.x - 1;
                                b3.y = h3.y;
                                UI.ShowBullet(b3);
                                Bullet.BulletWay(b3.x, b3.y, ref b3);
                            }
                            if (wasRight)
                            {
                                b3.x = h3.x + 1;
                                b3.y = h3.y;
                                UI.ShowBullet(b3);
                                Bullet.BulletWay(b3.x, b3.y, ref b3);
                            }
                            if (wasUp)
                            {
                                b3.x = h3.x;
                                b3.y = h3.y - 1;
                                UI.ShowBullet(b3);
                                Bullet.BulletWay(b3.x, b3.y, ref b3);
                            }
                            if (wasDown)
                            {
                                b3.x = h3.x;
                                b3.y = h3.y + 1;
                                UI.ShowBullet(b3);
                                Bullet.BulletWay(b3.x, b3.y, ref b3);
                            }
 
                            break;
                        default:
                            break;
                    }
                    
                }
 
                UI.HideEnemy(e3);
                Enemy.EnemyMovement(e3.x, e3.y, Randomizer.GetRandomDirection(), ref e3);
                UI.ShowEnemy(e3);
                System.Threading.Thread.Sleep(100);
            } while (key != ConsoleKey.Escape);
            Console.ReadKey();
        }
 
    }
}