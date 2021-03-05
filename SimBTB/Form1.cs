using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimBTB
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
           
        }



        private void btnMagic_Click(object sender, EventArgs e)
        {
            string TraceName;
            string Architecture;
            int BitsAutomat;
            int SizeBTB;

            TraceName = cbTrace.Text+".TRA";
            if (cbArchitecture.Text == "DIRECT MAPPED")
            {
                Architecture = "MAPPED";
            }
            else
            {
                Architecture = "FULLASSOCIATIVE";
            }

            BitsAutomat = Convert.ToInt32(cbPredictionBits.Text);
            SizeBTB = Convert.ToInt32(cbBTBSize.Text);



            Simulation simulation = new Simulation(TraceName,Architecture,BitsAutomat,SizeBTB);
           // Simulation simulation = new Simulation("FMATRIX.TRA","MAPPED", 2, 8);
            simulation.Execute();
            double pCorrPred = simulation.getPCorPred();
            double pIncorrPred = simulation.getPIncorPred();
            double WAddress = simulation.getPWrngAddr();
            int InstrTotal = simulation.getTotale();
            int InstrTaken = simulation.getTaken();

            

            chart1.Series.Clear();
            chart1.Series.Add("values");
            chart1.Series["values"].ChartType = SeriesChartType.Pie;
            chart1.Series["values"].Points.AddXY("Predictii Corecte",pCorrPred);
            chart1.Series["values"].Points.AddXY("Predictii Incorecte", pIncorrPred);
            chart1.Series["values"].Points.AddXY("Adresa Incorecta", WAddress);

           
            textBox1.Text = Convert.ToString(Math.Round(pCorrPred,2)+"%");
            tbWrongPred.Text = Convert.ToString(Math.Round(pIncorrPred, 2) + "%");
            tbWrongAddr.Text = Convert.ToString(Math.Round(WAddress, 2)+"%");
            tbTaken.Text = Convert.ToString(InstrTaken);
            tbTotal.Text = Convert.ToString(InstrTotal);

        }



    }
}
