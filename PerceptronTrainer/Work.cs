using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronTrainer
{
   public class Work
    {
       public Perceptron p;
        public Work()
        {
            p = new Perceptron();
        }
        public void GetTrainSamples(string trainSample)
        {
            string[] rows = trainSample.Split('\n');
            double[][] elems = new double[rows.Length][];
        
            for (int i = 0; i < rows.Length; i++)
            {
                string[] col = rows[i].Split(',');
                elems[i] = new double[col.Length];
                for (int j = 0; j < col.Length; j++)
                {
                    elems[i][j] = double.Parse(col[j]);
                }
            }
            p.TrainSamples = elems;
            p.NumOfInputNeuren = elems[0].Length;
        }


        public void GetWeights(string Weights)
        {
            string[] rows = Weights.Split('\n');
            double[][] elems = new double[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                string[] col = rows[i].Split(',');
                elems[i] = new double[col.Length];
                for (int j = 0; j < col.Length; j++)
                {
                    elems[i][j] = double.Parse(col[j]);
                }
            }
            p.Weights = elems;
        }


        public void GetDesireds(string DesiredOutput)
        {
            string[] rows = DesiredOutput.Split('\n');
            double[][] elems = new double[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                string[] col = rows[i].Split(',');
                elems[i] = new double[col.Length];
                for (int j = 0; j < col.Length; j++)
                {
                    elems[i][j] = double.Parse(col[j]);
                }
            }
            p.DesiredOutput = elems;
            p.NumOfOutputNeuren = elems[0].Length;
        }

        public void GetBais(string Bais)
        {
            
                string[] rows = Bais.Split(',');
                double[] elems = new double[rows.Length];

                for (int i = 0; i < rows.Length; i++)
                {
                    elems[i] = double.Parse(rows[i]);
                }
                p.Bais = elems;
            
            p.WithBais = true;
        }


        public Perceptron Train(string threshold,string learningRate,string epochs,string time, ActivationFunction AF)
        {
            p.Threshold = double.Parse(threshold);
            p.LearningRate = double.Parse(learningRate);
            p.Epochs = long.Parse(epochs);
            p.Time = long.Parse(time);
            if (AF == ActivationFunction.BipolarBinary)
                p.BipolarBinaryTrain();
            if (AF == ActivationFunction.UnipolarBinary)
                p.UnipolarBinaryTrain();
            return p;
        }

        public void SetRandomWeights()
        {
            Random r = new Random();
            double[][] weights = new double[p.NumOfInputNeuren][];
            for (int i = 0; i < p.NumOfInputNeuren; i++)
            {
                weights[i] = new double[p.NumOfOutputNeuren];
                for (int j = 0; j < p.NumOfOutputNeuren; j++)
                {
                    weights[i][j] = r.NextDouble();
                }
            }
            p.Weights = weights;
        }

        public void SetRandomBais()
        {
            Random r = new Random();
            double[] baises = new double[p.NumOfOutputNeuren];
            for (int i = 0; i < p.NumOfOutputNeuren; i++)
            {
                baises[i] = r.NextDouble();   
            }
            p.Bais = baises;
            p.WithBais = true;
        }
    }
}
