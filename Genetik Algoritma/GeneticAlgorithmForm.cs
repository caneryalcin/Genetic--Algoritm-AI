using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetik_Algoritma
{
    public partial class Form1 : Form
    {

        int nIPop;
        int elitism;
        double mutationRatio;
        double crossRatio;
        Genetic genetic;
        int generationNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            nIPop = int.Parse(populationNumericUpDown.Value.ToString());

            if(int.Parse(elitismNumericUpDown.Value.ToString()) >= nIPop)
            {
                MessageBox.Show("seçkinlik popülasyon sayısından küçük olmak zorundadır.");
                elitismNumericUpDown.Value = nIPop/2;
            }
            else
            {
                elitism = int.Parse(elitismNumericUpDown.Value.ToString());
                crossRatio = Double.Parse(crossNumericUpDown.Value.ToString());
                mutationRatio = Double.Parse(mutationNumericUpDown.Value.ToString());
                
                generationNumber = int.Parse(jenerationNumericUpDown.Value.ToString());
                genetic = new Genetic(nIPop, elitism, crossRatio, mutationRatio);
                chart1.Series["Rosenbrock Function"].Points.Clear();

                for (int i = 0; i < generationNumber; i++)
                {
                    genetic.goalFunction();
                }

                genetic.DrawChart(chart1);
                //genetic.WriteGoalAndParamaters(richTextBox1);
                genetic.WriteResults(richTextBox1);
            }


           
        }

    }
}
