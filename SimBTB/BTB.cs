using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*======================================================
 * [BTB Class]
 * Branch Target Buffer
 * Base class for Simulator
 * BTB sturcture->    |Branch Instruction PC|Next PC|Prediction Bits|LRU|
 * ====================================================
 */

namespace SimBTB
{
    public class BTB
    {
        public List<EntryBTB> EntriesBTB= new List<EntryBTB>(); /* Stores every BTB Entry */
        string Architecture = "MAPPED"; /* Cache Architecture Type [MAPPED|FULLASSOCIATIVE] */
        string result = "CORRECT";   /* Prediction result */
        int SizeBTB = 0; /* Number of entries a BTB can store */
        int index = 0; /* BTB index */
        bool AutomatBits = false; /* Automaton type */
        bool AddrInBTB = false; /* Checks if BTB contains the search Address */

/*=========================================
 *               Constructor
 *=========================================
 */
        public BTB()
        {
            index = 0;
        }
/*============================================
 *   Set BTB Size
 *   >in: Size
 *============================================
 */
        public void setBTBSize(int size)
        {
            this.EntriesBTB = new List<EntryBTB>();
            for(int i=0;i<size;i++)
            {
                this.EntriesBTB.Add(new EntryBTB(0));
            }
        }
/*===========================================
 * Initialize all BTB entries with 0 for
 * Current PC and Predicted PC
 *===========================================
 */
        public void InitBTB0()
        {
            EntryBTB entryBTB = null;
            for(int i=0;i<EntriesBTB.Count;i++)
            {
                entryBTB = EntriesBTB.ElementAt(i);
                entryBTB.setInstrPC(0);
                entryBTB.setPredPC(0);
                EntriesBTB[i] = entryBTB;
            }
        }
/*=====================================
 *        Setter automat type
 *=====================================
 */

        public void setAutomatBits(bool autbits)
        {
            this.AutomatBits = autbits;
        }

/*======================================
 * Initialize the confidence with 
 * Not taken for all entries
 *======================================
 */
        public void InitAutomat()
        {
            EntryBTB entryBTB = null;
            for(int i=0;i<EntriesBTB.Count();i++)
            {
                entryBTB = EntriesBTB.ElementAt(i);
                entryBTB.getConfidence().SetAutomatState(1);
                EntriesBTB[i] = entryBTB;
            }
        }
/*========================================================
 * Initialize BTB
 *  >in: Size 
 *         Number of entries BTB can store
 *  >in: Architecture
 *         Either Mapped or Fully Associative
 *  >in: AutomatBits
 *         Automaton Type (either 1 or 2 bits)
 *========================================================
 */
        public void InitBTB(int size,string architecture,bool AutomatBits)
        {
            setBTBSize(size);
            this.SizeBTB = size;
            InitBTB0();
            InitAutomat();
            setAutomatBits(AutomatBits);
            this.Architecture = architecture;
        }
/*===========================================
 *  BTB Search for Direct Mapped Architecture
 *  Index in Direct Mapped:
 *  (mem_block_addr/cache_size_bytes) % cache_size
 *   >in: PC
 *        Program Counter
 *   <out: 
 *       True - Address found in BTB
 *       False - Address NOT found BTB
 *===========================================
 */

        public bool MappedSearch(int pc)
        {
            EntryBTB entryBTB = null;
            int index = pc - this.SizeBTB * (pc / this.SizeBTB); 
            entryBTB = EntriesBTB.ElementAt(index);
            if(entryBTB.getInstrPC()==pc)
            {
                this.index = index;
                this.AddrInBTB = true;
                return true;
            }
            this.AddrInBTB=false;
            return false;

        }
/*==============================================
 * BTB Search for Fully Associative Architecture
 * No formula for Fully Associative (search all)
 *  >in PC
 *      Program Counter
 *  <out:
 *       True - Address found in BTB
 *       False - Address NOT found BTB
 *==============================================
 */
        public bool AssociativeSearch(int pc)
        {
            EntryBTB entryBTB = null;
            for(int i=0;i<this.SizeBTB;i++)
            {
                entryBTB = EntriesBTB.ElementAt(i);
                if(entryBTB.getInstrPC()==pc)
                {
                    this.index = i;
                    this.AddrInBTB = true;
                    return true;
                }
            }
            this.AddrInBTB = false;
            return false;
        }
/*=========================================
 * Update LRU
 * If the instruction is not found in BTB
 * set its LRU to the BTB Size
 * If its found decrement LRU
 *=========================================
 */
        public void UpdateLRU()
        {
            int i = 0;
            EntryBTB entryBTB = null;
            for (i = 0; i < this.SizeBTB; i++) 
            {
                if(i==this.index)
                {
                    entryBTB = EntriesBTB.ElementAt(i);
                    entryBTB.setLRU(this.SizeBTB);
                    EntriesBTB[i] = entryBTB;
                }
                else
                {
                    entryBTB = EntriesBTB.ElementAt(i);
                    if(entryBTB.getLRU() > 0)
                    {
                        entryBTB.setLRU((entryBTB.getLRU() - 1));
                        EntriesBTB[i] = entryBTB;
                    }
                }
            }
        }
/*======================================================
 * Get prediction for a given instruction
 * Returns false if the instruction is not found in BTB
 * If the instruction is found it returns its prediction
 *  >in: _pc
 *      Instruction PC
 *  <out:
 *      True - Taken
 *      False - NOT Taken
 *======================================================
 */
        public bool getPrediction(int _pc)
        {
            bool _result = true;
            if (Architecture.Equals("MAPPED"))
            {
                if (!MappedSearch(_pc))
                    return false;
            }
            else
            {
                if (!AssociativeSearch(_pc))
                    return false;
            }
            EntryBTB entryBTB = null;
            entryBTB = EntriesBTB.ElementAt(index); 
            _result = entryBTB.getConfidence().Prediction(this.AutomatBits);
            EntriesBTB[index] = entryBTB;
            if (Architecture.Equals("FULLASSOCIATIVE"))
            {
                UpdateLRU();
            }
            return _result;
        }
/*==================================================  <--- TODO
 * Update automat
 *  >in: result
 *      
 *  >in: Taken
 *      Branch taken or not taken
 *  >in: pc
 *      Current PC
 *  >in: nextpc
 *      Next PC
 *==================================================
 */
        public void UpdatePrediction(string result,bool Taken, int pc,int nextpc)
        {
            EntryBTB entryBTB = null;
            if (result.Equals("CORRECT")) 
            {
                entryBTB = EntriesBTB.ElementAt(index);
                Automat aut = entryBTB.getConfidence();
                aut.UpdateAutomat(Taken, this.AutomatBits);
                entryBTB.setConfidence(aut);
                EntriesBTB[index] = entryBTB;
            }

            if(result.Equals("INCORRECT"))
            {
                if (this.AddrInBTB) 
                {
                    entryBTB = EntriesBTB.ElementAt(index);
                    Automat aut = entryBTB.getConfidence();
                    aut.UpdateAutomat(Taken, this.AutomatBits);
                    entryBTB.setConfidence(aut);
                    EntriesBTB[index] = entryBTB;
                }

                else
                {
                    UpdateBTB(pc, nextpc);
                }
            }
            if(result.Equals("WRONGADDR"))
            {
                UpdateAddress(nextpc, Taken);
            }

        }
/*==================
 *     Getter
 *==================
 */
        public int GetNextPc()
        {
            EntryBTB entryBTB = null;
            entryBTB = EntriesBTB.ElementAt(this.index);
            return entryBTB.getPredPC();
        }
/*===================================
 * Update BTB with a new entry
 * Overwrites if it's the case
 * Sets confidence to Taken or Weak Taken (depending on the Automaton Type)
 *  >in: pc
 *      Instruction PC
 *  >in:
 *      Predicted PC
 *===================================
 */
        public void UpdateBTB(int pc,int nextpc)
        {
            EntryBTB entryBTB = null;
            int index = 0;

            if(this.Architecture.Equals("MAPPED"))
            {
                index = pc - this.SizeBTB * (pc / this.SizeBTB);
            }
            else
            {
                index = GetFirstIndex();
            }

            entryBTB = EntriesBTB.ElementAt(index);
            entryBTB.setInstrPC(pc);
            entryBTB.setPredPC(nextpc);
            if(this.AutomatBits)
            {
                entryBTB.getConfidence().SetAutomatState(3);
            }
            else
            {
                entryBTB.getConfidence().SetAutomatState(2);
            }
            EntriesBTB[index] = entryBTB;
            if(this.Architecture.Equals("FULLASSOCIATIVE"))
            {
                this.index = index;
                UpdateLRU();
            }
        }
/*=====================================
 * Updates PredPC in BTB
 *  >in: nextpc
 *      New PredPC
 *  >in: taken
 *      Branch taken or NOT taken
 *=====================================
 */
        public void UpdateAddress(int nextpc, bool taken)
        {
            EntryBTB entryBTB = null;
            entryBTB = EntriesBTB.ElementAt(this.index);
            entryBTB.setPredPC(nextpc);
            Automat aut = entryBTB.getConfidence();
            aut.UpdateAutomat(taken,this.AutomatBits);
            entryBTB.setConfidence(aut);
            EntriesBTB[this.index] = entryBTB;
        }

        public int GetFirstIndex()
        {
            int i = 0;
            for(i=0;i<this.SizeBTB;i++)
            {
                EntryBTB entryBTB=EntriesBTB.ElementAt(i);
                if(entryBTB.getLRU()==0)
                {
                    return i;
                }
            }
            return 0;

        }











    }
}
