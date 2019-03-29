using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceflight
{
    class enemy
    {
        public int xPosition = -1;
        public int yPosition = -1;
        bool isOnBoard = false;
        public static int killCount = 0;
        public static int dodgedCount = 0;
        public static int onBoard = 0; // number of enimies on the board

        public void Spawn(int xStartPosition)
        {
            if (!isOnBoard)
            {
                xPosition = xStartPosition;
                yPosition = 0;
                isOnBoard = true;
                onBoard++;
            }
        }

 //       public void Kill()
 //       {
 //           killCount++;
 //           xPosition = -1;
 //           yPosition = -1;
 //           isOnBoard = false;
 //           onBoard--;
 //       }

        public void MoveDown()
        {
            if (isOnBoard)
            {
                yPosition++;
            }

            if (yPosition > 5 && isOnBoard)
            {
                xPosition = -1;
                yPosition = -1;
                isOnBoard = false;
                dodgedCount++;
                onBoard--;
            }
        }

    }
}
