using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*======================================================
 * [Automat Class]
 * Used to predict if a branch will be taken or not
 * in Branch Target Buffer
 * Represents a confidence automaton on 1 or 2 bits
 * =====================================================
 */

namespace SimBTB
{
    public class Automat 
    {
        int State;

/*=========================
 *       Constructor
 * ========================
 */
        public Automat()
        {
            State = 1; 
        }
/*========================================================
 * Returns prediction for a given 1bit/2bits automat
 *    >in: AutomatType 
 *      False - 1 bit
 *      True - 2 bits
 *    <out:
 *      False - NOT Taken
 *      True - Taken
 * ======================================================
 */
        public bool Prediction(bool AutomatType)
        {
            if(AutomatType==true)
            {
                switch (State) 
                {
                    case 1:
                        return false;
                    case 2:
                        return false;
                    case 3:
                        return true;
                    case 4:
                        return true;
                    default:
                        return false;
                }

            }
            else
                if (State == 1)
                {
                    return false;
                }
                else
                {
                    return true; 
                }
        }
/*========================================================
 * Updates the state of the confidence automaton
 *    >in: Taken
 *      True - Branch Taken
 *      False - Branch NOT Taken
 *    >in: AutomatType
 *      False - 1 bit
 *      True - 2 bits
 * ======================================================
 */
        public void UpdateAutomat(bool Taken, bool AutomatType)
        {
            if(AutomatType==true)
            {
                if (Taken == true)
                {
                    switch (State)
                    {
                        case 1:
                            State = 2;
                            break;
                        case 2:
                            State = 3;
                            break;
                        case 3:
                            State = 4;
                            break;
                        case 4:
                            State = 4;
                            break;

                    }
                }
                else
                {
                    switch (State)
                    {
                        case 1:
                            State = 1;
                            break;
                        case 2:
                            State = 1;
                            break;
                        case 3:
                            State = 2;
                            break;
                        case 4:
                            State = 3;
                            break;
                    }
                }
            }
            else
            {
                if (Taken == true)
                {
                    State = 2;
                }
                else
                {
                    State = 1;
                }
            }
        }
/*======================================
 *         Setter for state
 *======================================
 */
        public void SetAutomatState(int State)
        {
            this.State = State;
        }

    }
}
