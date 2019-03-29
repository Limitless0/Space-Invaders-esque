using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceflight
{
    class BoardModel
    {
        string emptyTile = "|   |";
        string enemyTile = "| 0 |";
        string enemyFireTile = "| ! |";
        string playerFireTile = "| i |";
        string playerTile = "| A |";
        string explosionTile = "| * |";

        public static bool deathDetect = false;

        public int rows = 5;
        public int collumns = 4;
        public int COLL
        {
            get { return collumns; }
        }
        public int ROW
        {
            get { return rows; }
        }
        
        public void printBoard(int e1R, int e1C, int e2R, int e2C, int e3R, int e3C, int e4R, int e4C, int e5R, int e5C,int e6R, int e6C, int e7R, int e7C, int e8R, int e8C, int e9R, int e9C, int pR, int pC)

        {
            int r = 0;
            while (r < rows)
            {
                int c = 0;
                while (c < collumns)
                {
                    if (!printEnemy(e1R, e1C, r, c, pR, pC) && !printEnemy(e2R, e2C, r, c, pR, pC) && !printEnemy(e3R, e3C, r, c, pR, pC) && !printEnemy(e4R, e4C, r, c, pR, pC) && !printEnemy(e5R, e5C, r, c, pR, pC) && !printEnemy(e6R, e6C, r, c, pR, pC) && !printEnemy(e7R, e7C, r, c, pR, pC) && !printEnemy(e8R, e8C, r, c, pR, pC) && !printEnemy(e9R, e9C, r, c, pR, pC))
                    {
                        Console.Write(emptyTile);
                    }
                    c++;
                }
                Console.Write("\n");
                r++;
            }
        }

        public bool printEnemy(int eR, int eC, int r, int c, int pR, int pC)
        {
            if (((eR == pR) && (pR == r)) && ((eC == pC) && (pC == c)))
            {
                Console.Write(explosionTile);
                deathDetect = true;
                return true;
            }
                      else
                       {
                           if ((pR == r && pC == c) && !(eR == pR) )
                           {
                               Console.Write(playerTile);
                               return true;
                           }
                       }
           
            if (eR == r && eC == c)
            {
                Console.Write(enemyTile);
                return true;
            } else
            {
                return false;
            }
        }
        


    }


}
