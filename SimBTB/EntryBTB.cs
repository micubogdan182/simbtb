using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*======================================================
 * [EntryBTB Class]
 * This class represents a template for each entry in the
 * Branch Target Buffer structure 
 * BTB sturcture->    |Branch Instruction PC|Next PC|Prediction Bits|LRU|
 * entry ->           |       InstrPC       | PredPc|   Confidence  |LRU|
 * ====================================================
 */

namespace SimBTB
{
    public class EntryBTB
    {
        int InstrPC;
        int PredPC;
        Automat Confidence = new Automat();
        int LRU;
/*====================
 *    Constructor 
 *====================
 */
        public EntryBTB(int _lru) 
        {
            this.LRU = _lru;
        }

/*==================================
 *        Getters & setters
 *==================================
 */
        public void setInstrPC(int pc)
        {
            this.InstrPC = pc;
        }

        public void setPredPC(int nextpc)
        {
            this.PredPC = nextpc;
        }

        public void setConfidence(Automat ConAut)
        {
            this.Confidence = ConAut;
        }

        public void setLRU(int ValLRU)
        {
            this.LRU = ValLRU;
        }

        public int getInstrPC()
        {
            return this.InstrPC;
        }

        public int getPredPC()
        {
            return this.PredPC;
        }

        public Automat getConfidence()
        {
            return this.Confidence;
        }

        public int getLRU()
        {
            return this.LRU;
        }

    }
}
