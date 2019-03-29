using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceflight
{
    class Program
    {
        static void Main(string[] args)
        {

            BoardModel enemyBoard = new BoardModel();
            int colls = enemyBoard.COLL;
            int rows = enemyBoard.ROW;

            Player player = new Player(rows / 2, colls);

            enemy e1 = new enemy();
            enemy e2 = new enemy();
            enemy e3 = new enemy(); //there HAS to be a better way of doing this
            enemy e4 = new enemy();
            enemy e5 = new enemy();
            enemy e6 = new enemy();
            enemy e7 = new enemy();
            enemy e8 = new enemy();
            enemy e9 = new enemy();

            enemyBoard.printBoard(
                e1.yPosition,
                e1.xPosition,
                
                e2.yPosition,
                e2.xPosition,

                e3.yPosition,
                e3.xPosition,

                e4.yPosition,
                e4.xPosition,

                e5.yPosition,
                e5.xPosition,

                e6.yPosition,
                e6.xPosition,

                e7.yPosition,
                e7.xPosition,

                e8.yPosition,
                e8.xPosition,

                e9.yPosition,
                e9.xPosition,
                
                player.yPosition,
                player.xPosition
                );

            Console.ReadLine();
           

            while (!BoardModel.deathDetect)
            {
                Console.Clear();

                MoveAllDown(e1, e2, e3, e4, e5, e6, e7, e8, e9);
                Spawner(colls, e1, e2, e3, e4, e5, e6, e7, e8, e9);

                enemyBoard.printBoard(
                e1.yPosition,
                e1.xPosition,

                e2.yPosition,
                e2.xPosition,

                e3.yPosition,
                e3.xPosition,

                e4.yPosition,
                e4.xPosition,

                e5.yPosition,
                e5.xPosition,

                e6.yPosition,
                e6.xPosition,

                e7.yPosition,
                e7.xPosition,

                e8.yPosition,
                e8.xPosition,

                e9.yPosition,
                e9.xPosition,

                player.yPosition,
                player.xPosition);

                Console.WriteLine("enemies on the board: " + enemy.onBoard);
                Console.WriteLine("dodged:               " + enemy.dodgedCount);
                Console.WriteLine("Deathdetect = " + BoardModel.deathDetect);




                Console.ReadLine();
            }
            Console.ReadLine();
    




        }

        static void Spawner(int ROW, enemy e1, enemy e2, enemy e3, enemy e4, enemy e5, enemy e6, enemy e7, enemy e8, enemy e9)
        {
            Random rand = new Random();
            int eChooser = rand.Next(9) ;
            int rowChooser = rand.Next(ROW
                );
            switch (eChooser)
            {
                case 1: e1.Spawn(rowChooser); break;
                case 2: e2.Spawn(rowChooser); break;
                case 3: e3.Spawn(rowChooser); break;
                case 4: e4.Spawn(rowChooser); break;
                case 5: e5.Spawn(rowChooser); break;
                case 6: e6.Spawn(rowChooser); break;
                case 7: e7.Spawn(rowChooser); break;
                case 8: e8.Spawn(rowChooser); break;
                case 9: e9.Spawn(rowChooser); break;
            }
        }

        static void MoveAllDown(enemy e1, enemy e2, enemy e3, enemy e4, enemy e5, enemy e6, enemy e7, enemy e8, enemy e9)
        {
            e1.MoveDown();
            e2.MoveDown();
            e3.MoveDown();
            e4.MoveDown();
            e5.MoveDown();
            e6.MoveDown();
            e7.MoveDown();
            e8.MoveDown();
            e9.MoveDown();
        }
    }
}
