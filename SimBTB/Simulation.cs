using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimBTB
{
    public class Simulation
    {
        Simulator sim = null;
        string BTBType;
        int nrBp;
        int BTBSize;
        double pCorPred;
        double pIncorPred;
        double pWrngAddr;
        int Totale;
        int Takenn;
/*=================================
 *           Constructor
 *=================================
 */
        public Simulation(string trace, string BTBType, int nrbitipredictie, int BTBSize)
        {
            Simulator simulator = new Simulator();
            bool AutomatBits = true;
            if (nrbitipredictie == 1)
            {
                AutomatBits = false;
            }
            simulator.InitBTB(BTBSize, BTBType, AutomatBits);
            simulator.setTrace(trace);
            SetSimulator(simulator);
            this.BTBSize = BTBSize;
            this.BTBType = BTBType;
            this.nrBp = nrbitipredictie;
        }

        public void SetSimulator(Simulator simulator)
        {
            this.sim = simulator;
        }

        public void Execute()
        {



            
            sim.StartSimulation();


            Console.WriteLine(this.BTBType);
            Console.WriteLine(this.nrBp);
            Console.WriteLine(this.BTBSize);
            Console.WriteLine("Total instr:"+sim.TotalInstructions);
            Totale = sim.TotalInstructions;
            Console.WriteLine("Branchuri luate:"+sim.BranchesExecuted);
            Takenn = sim.BranchesExecuted;
            Console.WriteLine("Predictii corecte:"+sim.CorrectPredictions);
            pCorPred = Convert.ToDouble(sim.CorrectPredictions)/Convert.ToDouble(sim.TotalInstructions)*100;
            Console.WriteLine("Predictii gresite:"+sim.IncorrectPredictions);
            pIncorPred = Convert.ToDouble(sim.IncorrectPredictions) / Convert.ToDouble(sim.TotalInstructions) * 100;
            Console.WriteLine("Adrese gresite:"+sim.IncorrectAddress);
            pWrngAddr = Convert.ToDouble(sim.IncorrectAddress) / Convert.ToDouble(sim.TotalInstructions) * 100;


        }
/*======================================
 *           Getters for UI
 *======================================
 */
        public double getPCorPred()
        {
            return pCorPred;
        }

        public double getPIncorPred()
        {
            return pIncorPred;
        }

        public double getPWrngAddr()
        {
            return pWrngAddr;
        }

        public int getTotale()
        {
            return Totale;
        }

        public int getTaken()
        {
            return Takenn;
        }
    }
}
