using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
    enum Direction
    {
        NoDirection,
        Left,
        Right,
        Up,
        Down
    }
 
    struct Enemy
    {
        public int x;
        public int y;
 
        public static void MoveEnemy(int dx, int dy, ref Enemy e)
        {
            e.x += dx;
            e.y += dy;
        }
        public static void EnemyMovement(int x, int y, Direction direction, ref Enemy e)
        {
            int oldX = x;
            int oldY = y;
 
            switch (direction)
            { 
                case Direction.Right:
                    MoveEnemy(1, 0, ref e);
                    break;
                case Direction.Left:
                    MoveEnemy(-1, 0, ref e);
                    break;
                case Direction.Up:
                    MoveEnemy(0, -1, ref e);
                    break;
                case Direction.Down:
                    MoveEnemy(0, 1, ref e);
                    break;
                default:
                    break;
            }
        }
    }
}