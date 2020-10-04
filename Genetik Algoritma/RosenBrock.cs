using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetik_Algoritma
{
    public class RosenBrock
    {
        public double[] gens;
        public List<double[]> chromosome = new List<double[]>();
        int d = 30;
        double result;
        public bool canAddGens = true;
        int iteration;
        public double Function(double[] gen)
        {
            result = 0;
            gens = new double[31];
            this.gens = gen;
            for (int i = 1; i <= d-1; i++)
            {
                result += (100 * Math.Pow((gens[i + 1] - Math.Pow(gens[i], 2)), 2)) + Math.Pow((gens[i] - 1), 2);
            }
            
            if(canAddGens)//for the first iteration we will assign gens to chromosome list.But after first iteration no necessarry to assing gens because we will change gens with crossing and mutation.
            {
                chromosome.Add(gens);
                iteration++;
            }
            return result;


        }


    }
}
