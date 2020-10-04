using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Genetik_Algoritma
{
    class Genetic
    {
        RosenBrock rosenBrock = new RosenBrock();
        List<double> AvaragesOfFitnesses = new List<double>();
        List<double> fitnessList = new List<double>();
        Random r = new Random();
        int nIPop, elitism;
        double mutationRatio;
        double crossRatio;
        double[] gen;
        double x;

        public Genetic(int nIPop, int elitism, double crossRatio,double mutationRatio)
        {

            this.nIPop = nIPop;
            this.elitism = elitism;
            this.crossRatio = crossRatio;
            this.mutationRatio = mutationRatio;

        }

        
        int iteration = 0;
        public void goalFunction()
        {

            if(iteration == 0)
            {
                fitnessList.Clear();
                for (int j = 0; j < nIPop; j++)
                {
                    gen = new double[31];
                    for (int i = 1; i <= 30; i++)
                    {
                        x = r.Next(-30, 30);
                        gen[i] = x;
                    }

                    fitnessList.Add(rosenBrock.Function(gen));

                }
                SelectProcess();
                Mutation();
                rosenBrock.canAddGens = false;//don't allow adding gens to chromosome after first iteration.After first iteration we will make crossing or mutation on gens.
                iteration++;
            }
            else if (iteration != 0)
            {

                fitnessList.Clear();
                for (int j = 0; j < nIPop; j++)
                {

                    for (int k = 1; k <= 30; k++)
                    {
                        gen = new double[31];
                        gen = rosenBrock.chromosome[j];
                    }
                    
                    fitnessList.Add(rosenBrock.Function(gen));
                }
                SelectProcess();
                Mutation();

            }
        }

        double[] selectedFitnesses;
        List<double> tempList;    
        double[] nBest;
        public void SelectProcess()
        {
            tempList = new List<double>();
            foreach (var item in fitnessList)
            {
                tempList.Add(item);
            }
            fitnessList.Sort();//sort the list from smallest to greatest.

            AvaragesOfFitnesses.Add(fitnessList.Average()); //hold avarages of fitnesses.We will use it in chart.
            selectedFitnesses = new double[elitism];//units that chosen with elitism
            Array.Copy(fitnessList.ToArray(), selectedFitnesses,elitism);

            if (elitism % 2 == 1){elitism--;}

            nBest = new double[elitism / 2];

            Array.Copy(selectedFitnesses, nBest, elitism / 2);

            Matching();
                
        }

        double[] selectedChromosome1 = new double[31];
        double[] selectedChromosome2 = new double[31];
        int ChromosomeFitness1, ChromosomeFitness2;
        double selectedFitnessFirst, selectedFitnessSecond;
        public void Matching()
        {
            //Random Match
            for (int i = 0; i < (nBest.Length / 2) ; i++)//in every iteration in for loop we will match 2 chromosome.
                                                         // for that reason  we divide nBest to 2.  -->(nBest.Length / 2).
            {
                //Chromosome=roundup{NBest x randomNumber}
                int randomNumber1 = (int)Math.Ceiling(r.NextDouble() * (nBest.Count() - 1));
                int randomNumber2 = (int)Math.Ceiling(r.NextDouble() * (nBest.Count() - 1));
                //Select chosen fitnesses and find index of them in the tempFitnessList(fitnessList) and find the chromosome in same index with fitnesses.
                selectedFitnessFirst = nBest[randomNumber1];
                selectedFitnessSecond = nBest[randomNumber2];
                //index of fitness and chromosome is same.So to find which chrosome we will use, we are finding index of fitness.
                ChromosomeFitness1 = Array.IndexOf(tempList.ToArray(), selectedFitnessFirst);
                ChromosomeFitness2 = Array.IndexOf(tempList.ToArray(), selectedFitnessSecond);
                //and find one chromosome in chromosomes by help of index.
                selectedChromosome1 = rosenBrock.chromosome[ChromosomeFitness1];
                selectedChromosome2 = rosenBrock.chromosome[ChromosomeFitness2];

                Crossing();
            }
        }

        double firstGen, secondGen;
        double randomNumber;
        public void Crossing()
        {
            for (int k = 1; k < 29; k++)
            {
                randomNumber = r.NextDouble();
                if (randomNumber < crossRatio)
                {   //Pfather*(B) + (1-B)*Pmother
                    firstGen = selectedChromosome1[k];
                    secondGen = selectedChromosome2[k];
                    selectedChromosome2[k] = secondGen * randomNumber + (1 - randomNumber) * firstGen;
                    selectedChromosome1[k] = firstGen * randomNumber + (1 - randomNumber) * secondGen;
                }
            }
            rosenBrock.chromosome[ChromosomeFitness1] = selectedChromosome1;
            rosenBrock.chromosome[ChromosomeFitness2] = selectedChromosome2;
        }

        public void Mutation()
        {
            double p;
            double xNew;
            foreach (var chromosome in rosenBrock.chromosome)
            {

                for (int i = 1; i <= 30; i++)
                {
                    p = r.NextDouble();
                    if (p < mutationRatio)
                    {
                        xNew = r.Next(-30, 30);
                        chromosome[i] = xNew;
                    }
                }                
            }         
        }

        public void DrawChart(Chart chart1)
        {

            int counter = 1;
            foreach (var item in AvaragesOfFitnesses)
            {
                chart1.Series["Rosenbrock Function"].Points.AddXY(counter, item);
                counter++;
            }


        }

        string a;
        public void WriteResults(RichTextBox richTextBox1)
        {

            a = "Amaç Fonskiyonu--> " + AvaragesOfFitnesses.Last() + "\n";

            a += "-----------------------------------------------------------------------------------------------------------\n";

            int queueOfChromosome = 1;
            foreach (var chrosome in rosenBrock.chromosome)
            {
                a += (queueOfChromosome + ".kromozom \n");
                queueOfChromosome++;
                for (int i = 1; i < chrosome.Length; i++)
                {

                    a += (i+ ".gen--> "  + chrosome[i].ToString("0.0") + "   ");

                }
                a += "\n \n";
            }
            richTextBox1.Text = a;
        }
    }

}

