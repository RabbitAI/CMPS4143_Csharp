/*
 *      Name: Christian Douglas
 *      File: Mimic, Critters.dll
 *      Purpose: Derives from Majestic class has method Eat.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critters
{
    public class Mimic : Majestic
    {
        /*
         *      Method Name: Christian Douglas
         *      Params: hasEaten
         *      Purpose: checks to see if the Fly object and the Mimic
         *      object are in the same location if hasEaten is true, 
         *      Mimic object's life increases by 1, if false it decreases
         *      by one.
         */
        public int Eat(bool hasEaten)
        {
            if (hasEaten) return this.Life++;
            else return this.Life--;
        }
    }
}
