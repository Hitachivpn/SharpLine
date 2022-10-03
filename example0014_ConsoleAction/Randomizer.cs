using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _20170512_ExamTask
{
    class Randomizer
    {
        public static Random Rnd = new Random();
 
        public static Direction GetRandomDirection()
        {
            Direction retDirection = Direction.NoDirection;
 
            //[PointColors.NoColor .. PointColors.Blue
            //[                  0 .. 3]
 
            retDirection = (Direction)(Rnd.Next((int)Direction.NoDirection) + Rnd.Next(1, 4));
 
            return retDirection;
        }
 
        public static int GetRandomCoord(int min, int max)
        {
            return Rnd.Next(min, max);
        }
 
        //public static Point PointGetRandomPoint()
        //{ 
        //}
 
    }
}