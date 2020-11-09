/*
 *      Name: Christian Douglas
 *      File: Actors, Critters.dll
 *      Purpose: Abstract class for the other classes to inherit from.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critters
{
    public abstract class Actor
    {
        private int x;                             //Private variable for X coordinate 
        private int y;                             //Private variable for Y coordinate
        private int life;                          //Private variable for Life value
        private int gridSize;                      //Private variable for size of GameBoard
        private Actor actor;                       //object of actor class for parameterized
                                                   //Constructor

        /*
         *      Method Name: Actor
         *      Purpose: Constructor
         */
        public Actor()
        {
            x = 0;
            y = 0;
            life = 1;
            gridSize = 0;
            
        }

        /*
         *      Method Name: Actor
         *      Params: choices, xPos, yPos, grid
         *      Purpose: Parameterized Constructor, uses a switch statement to
         *      initialize what type actor will be
         */
        public Actor(char choices, int xPos, int yPos, int grid)
        {
            x = xPos;
            y = yPos;
            gridSize = grid;
            switch (choices)
            {
                case 'M':
                    actor = new Majestic();
                    break;
                case 'N':
                    actor = new Mimic();
                    break;
                case 'F':
                    actor = new Fly();
                    break;
            }
        }

        /*
         *      Property Name: X
         *      Purpose: gets and sets x's value
         */
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = ((value >= 0 && value < gridSize) ? value : 0);
            }
        }

        /*
         *      Property Name: Y
         *      Purpose: gets and sets y's value
         */
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = ((value >= 0 && value < gridSize) ? value : 0);
            }
        }

        /*
         *      Property Name: Life
         *      Purpose: gets and sets life's value
         */
        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = ((value > 0) ? life : 0);
            }
        }

        /*
         *      Method Name: Position
         *      Return: void
         *      Param: posX, posY
         *      Purpose: set x and y's values
         */
        public virtual void Position(int posX, int posY)
        {
            x = posX;
            y = posY;
        }
    }
}
