using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*======================================================
 * [Simulator Class]
 * Simulates and decodes instructions
 * Inherits BTB
 * ====================================================
 */

namespace SimBTB
{
    public class Simulator : BTB
    {
        int CurrentPC;
        int NextPC;
        char firstChar;
        bool ToExecute;
       public int BranchesExecuted;
       public int TotalInstructions;
        public int CorrectPredictions;
        public int IncorrectPredictions;
        public int IncorrectAddress;
        public string Trace = string.Empty;
/*==================================
 *          Constructor
 *==================================
 */
        public Simulator() 
        {
            CurrentPC = 0;
            NextPC = 0;
            ToExecute = false;
            BranchesExecuted = 0;
            TotalInstructions = 0;
            CorrectPredictions = 0;
            IncorrectPredictions = 0;
            IncorrectAddress = 0;
        }
/*=====================
 *      Setter
 *=====================
 */
        public void setTrace(string trace)
        {
            this.Trace = trace;
        }
/*===============================
 * Decodes instruction
 * Splits the instruction string into 3 parts
 * [B|N] - taken or not
 * CurrentPC
 * NextPC
 *  >in: instruction
 *      Line read from .TRA file
 *===============================
 */
        public void DecodeInstruction(string instruction)
        {
            instruction = instruction.Trim();
            char[] chars=new char[instruction.Length];
            chars = instruction.ToCharArray();
            this.firstChar = chars[0];
            instruction = instruction.Substring(3);
            int ind = instruction.IndexOf(' ');
            this.CurrentPC = Convert.ToInt32(instruction.Substring(0, ind));
            instruction = instruction.Substring(ind + 1);
            this.NextPC = Convert.ToInt32(instruction.Trim());
        }
/*=============================================================
 * Stores the data from a .TRA file into a StreamReader
 * Decodes line by line (instruction by instruction)
 * Compares the execution state with the prediction
 *   case 1: ToExecute(read instruction) == Prediction(from BTB)
 *      -> case 1.1: NextPC (read instruction) == NextPC (from BTB)
 *              Result: CORRECT PREDICTION
 *      -> case 1.2: NextPC (read instruction) != NextPC (from BTB)
 *              Result: WRONG ADDRESS 
 *   case 2: ToExecute(read instruction) != Prediction(from BTB)
 *              Result: WRONG PREDICTION
 * After each comparison we update the Prediction
 *=============================================================
 */

        public void StartSimulation() 
        {
            StreamReader sr=new StreamReader(this.Trace);
            bool _prediction = true;
            int _nextPc = 0;
            string instr = string.Empty;
            instr = sr.ReadLine();
            while(instr!=null)
            {
                DecodeInstruction(instr);
                if(firstChar=='N')
                {
                    this.ToExecute = false;
                }
                else
                {
                    this.BranchesExecuted += 1;
                    this.ToExecute = true;
                }
                _prediction = getPrediction(this.CurrentPC);
                if(this.ToExecute!=_prediction)
                {
                    this.IncorrectPredictions += 1;
                    UpdatePrediction("INCORRECT", this.ToExecute, this.CurrentPC, this.NextPC);
                }
                else
                {
                    _nextPc = GetNextPc();
                    if(this.NextPC!=_nextPc)
                    {
                        this.IncorrectAddress += 1;
                        UpdatePrediction("WRONGADDR", this.ToExecute, this.CurrentPC, this.NextPC);
                    }
                    else
                    {
                        this.CorrectPredictions += 1;
                        UpdatePrediction("CORRECT", this.ToExecute, this.CurrentPC, this.NextPC);
                    }
                }
                this.TotalInstructions += 1;
                instr = sr.ReadLine();
            }

        }

    }
}
