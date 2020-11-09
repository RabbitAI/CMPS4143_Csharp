/*
 *      Name: Christian Douglas
 *      File: Fly, Critters.dll
 *      Purpose: Derives from Actor class has classes for
 *      position, move, and eat.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critters
{

    public class Fly : Actor
    {
        private Majestic majestic = new Majestic();         //Majestic object for checking Majestic's
                                                            //position
        private Mimic mimic = new Mimic();                  //Mimic object for checking Mimic's position
        private int gridsize;                               //Used to make sure x and y values are not
                                                            //larger than define grid size

        public Fly() : base() { }
        
        /*
         *      Method Name: Eat
         *      Return: int
         *      Param: hasEaten
         *      Purpose: Checks to see if Fly's object and Majestic's object have
         *      the same location if they do hasEaten equals true and Life is 
         *      increased by 1, if false Life is decreased by 1.
         */
        public int Eat(bool hasEaten)
        {
            if (hasEaten) return this.Life ++;
            else return this.Life--;
        }

        /*
         *      Method Name: Move
         *      Purpose: Moves Fly's object randomly in any direction by 1 and checks
         *      to see if Fly's coordinates equals Majestic's and Mimic's objects and
         *      calls Eat if either are true.
         */
        public void Move()
        {
            Random randi = new Random();
            int direction = randi.Next(1, 8);

            switch (direction)
            {
                case 1:
                    Position(this.X, this.Y + 1);
                    break;
                case 2:
                    Position(this.X + 1, this.Y + 1);
                    break;
                case 3:
                    Position(this.X + 1, this.Y);
                    break;
                case 4:
                    Position(this.X + 1, this.Y - 1);
                    break;
                case 5:
                    Position(this.X, this.Y - 1);
                    break;
                case 6:
                    Position(this.X - 1, this.Y - 1);
                    break;
                case 7:
                    Position(this.X - 1, this.Y);
                    break;
                default:
                    Position(this.X - 1, this.Y + 1);
                    break;
            }
            if (this.X == majestic.X && this.Y == majestic.Y)
            {
                Eat(true);
            }
            if(this.X == mimic.X && this.Y == mimic.Y)
            {
                this.Life = 0;
                mimic.Eat(true);
            }
        }

        /*
         *      Method Name: Position
         *      Purpose: Gets the postion of x and y, uses branchless programming
         *      to see if it is within the parameters of gridsize
         */
        public override void Position(int xPos , int yPos)
        {
            this.X = xPos * Convert.ToInt32(xPos < gridsize || xPos >= 0);
            this.Y = yPos * Convert.ToInt32(yPos < gridsize || yPos >= 0);
        }
    }
}
