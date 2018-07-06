using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PerceptronTrainer
{
    public enum ActivationFunction
    {
        BipolarContinuse,
        UnipolarContinuse,
        BipolarBinary,
        UnipolarBinary
    }
    public class Perceptron
    {
        public int NumOfInputNeuren { get; set; }
        public int NumOfOutputNeuren { get; set; }
        public double[][] Weights { get; set; }//each coulmn represent one output neuren
        public double[] Bais { get; set; }
        public double[][] TrainSamples { get; set; }//each row represent one sample and the number of coulmns is te number of inputs  
        public double[][] DesiredOutput { get; set; }//the number of coulmns is the number of output
        public double Threshold { get; set; }
        public double LearningRate { get; set; }
        public long Epochs { get; set; }
        public long Time { get; set; }
        public bool isTrained { get; set; }
        public long ResultNeededEpochsToTrain { get; set; }
        public long ResultNeededTimeToTrain { get; set; }
        public bool WithBais { get; set; }
        public Perceptron()
        {
                        
        }

        public void BipolarContinuseTrain()
        {

        }

        public void UnipolarContinuseTrain()
        {

        }


        public void BipolarBinaryTrain()
        {
            #region comments
            /*
            int theNumberOfSampleTrainingSet = TrainSamples.Length;//عدد نماذج التدريب
            double totalError = 0;
            int i = 0;
            for (i = 0; i < Epochs; i++)
            {
                totalError = 0;
                for (int j = 0; j < theNumberOfSampleTrainingSet; j++)
                {
                    for (int k = 0; k < NumOfOutputNeuren; k++)
                    {
                        double output = BipolarBinaryOutput(TrainSamples[j],k);
                        double error = DesiredOutput[j][k] - output;

                        totalError += error;

                        for (int l = 0; l < NumOfInputNeuren; l++)
                        { 
                             double delta = LearningRate * TrainSamples[j][l] * error;
                             Weights[l][k] += delta;
                        }
                        Bais[k] = Bais[k] + LearningRate * DesiredOutput[j][k];
                    }
                }

                if (totalError == 0)
                    break;
            }
            if (totalError == 0) isTrained = true;  
            */
            #endregion
            if (WithBais)
            {
                int theNumberOfSampleTrainingSet = TrainSamples.Length;//عدد نماذج التدريب
                long currentLoopTime = 0, current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                double totalError = 0;
                int i = 0;
                for (i = 0; i < Epochs; i++)
                {
                    currentLoopTime = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                    if (currentLoopTime - current >= Time)
                    { isTrained = false; break; }
                    totalError = 0;
                    for (int j = 0; j < theNumberOfSampleTrainingSet; j++)
                    {
                        for (int k = 0; k < NumOfOutputNeuren; k++)
                        {
                            double output = BipolarBinaryOutput(TrainSamples[j], k);

                            double error = DesiredOutput[j][k] - output;
                            totalError += Math.Abs(error);
                            if (error != 0)
                            {
                                for (int l = 0; l < NumOfInputNeuren; l++)
                                {
                                    double perceptron = LearningRate * TrainSamples[j][l] * error;
                                    Weights[l][k] += perceptron;
                                }
                                Bais[k] = Bais[k] + LearningRate * error;
                            }
                        }
                    }
                    if (totalError == 0)
                        break;

                }
                if ((totalError == 0) && (currentLoopTime - current < Time)) isTrained = true;
                long End = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                ResultNeededTimeToTrain = End - current;
                ResultNeededEpochsToTrain = i;
            }
            else
            {
                int theNumberOfSampleTrainingSet = TrainSamples.Length;//عدد نماذج التدريب
                long currentLoopTime = 0, current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                double totalError = 0;
                int i = 0;
                for (i = 0; i < Epochs; i++)
                {
                    currentLoopTime = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                    if (currentLoopTime - current >= Time)
                    { isTrained = false; break; }
                    totalError = 0;
                    for (int j = 0; j < theNumberOfSampleTrainingSet; j++)
                    {
                        for (int k = 0; k < NumOfOutputNeuren; k++)
                        {
                            double output = BipolarBinaryOutput(TrainSamples[j], k);

                            double error = DesiredOutput[j][k] - output;
                            totalError += Math.Abs(error);
                            if (error != 0)
                            {
                                for (int l = 0; l < NumOfInputNeuren; l++)
                                {
                                    double perceptron = LearningRate * TrainSamples[j][l] * error;
                                    Weights[l][k] += perceptron;
                                }
                            }
                        }
                    }
                    if (totalError == 0)
                        break;

                }
                if ((totalError == 0) && (currentLoopTime - current < Time)) isTrained = true;
                long End = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                ResultNeededTimeToTrain = End - current;
                ResultNeededEpochsToTrain = i;
            }
        }

        public int BipolarBinaryOutput(double[] input, int k)
        {
            double sum = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Weights[i][k] * input[i];
            }
            if (WithBais)
                sum += Bais[k];

            if (sum > Threshold)
                return 1;
            else
                return -1;
        }
        /*
                public void BipolarBinaryTrain()
                {
                    #region comment
                    /*


                    long current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60+ DateTime.Now.Hour*1000*3600;
                    for (long i = 0; i < 1000000; i++)
                    {

                    }

                    long next = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                    MessageBox.Show(next - current + "\n");
                    MessageBox.Show(next + "\n");
                    MessageBox.Show(current + "");
                    /*


                    #endregion
                    long current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                    long curentEpochs = 0, currentLoopTime = 0;
                    double[] tempOut = new double[NumOfOutputNeuren];
                    while (curentEpochs <= Epochs)
                    {
                        currentLoopTime = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                        if (currentLoopTime - current >= Time)
                        { isTrained = false; break; }
                        else
                        {
                            int ChangeWight = 0;
                            for (int k = 0; k < InputMatrix.GetLength(2); k++)
                            {
                                for (int i = 0; i < NumOfOutputNeuren; i++)
                                {
                                    for (int j = 0; j < NumOfInputNeuren; j++)
                                    {
                                        tempOut[i] += Wights[j, i] * InputMatrix[j, k];
                                    }
                                    tempOut[i] += Bais[i];
                                }

                            for (int i = 0; i < NumOfOutputNeuren; i++)
                            {
                                if (tempOut[i] >= Threshould) tempOut[i] = 1;
                                else tempOut[i] = -1;
                            }
                            for (int i = 0; i < NumOfOutputNeuren; i++)
                            {
                                if (tempOut[i] != DesiredOutput[i])
                                {
                                        ChangeWight++;
                                    for (int j = 0; j < NumOfInputNeuren; j++)
                                    {
                                        Wights[j, i] = Wights[j, i] + LearningRate * (DesiredOutput[i] - tempOut[i]);
                                    }
                                    Bais[i] = Bais[i] + LearningRate * DesiredOutput[i];
                                }
                            }
                        }
                            if (ChangeWight == 0) { isTrained = true; break; }
                            curentEpochs++;
                        }
                    }

                }

            */
        public void UnipolarBinaryTrain()
        {
            if (WithBais)
            {
                int theNumberOfSampleTrainingSet = TrainSamples.Length;//عدد نماذج التدريب
                long currentLoopTime = 0, current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                double totalError = 0;
                int i = 0;
                for (i = 0; i < Epochs; i++)
                {
                    totalError = 0;
                    for (int j = 0; j < theNumberOfSampleTrainingSet; j++)
                    {
                        for (int k = 0; k < NumOfOutputNeuren; k++)
                        {
                            double output = UniBipolarBinaryOutput(TrainSamples[j], k);

                            double error = DesiredOutput[j][k] - output;
                            totalError += Math.Abs(error);
                            if (error != 0)
                            {
                                for (int l = 0; l < NumOfInputNeuren; l++)
                                {
                                    double perceptron = LearningRate * TrainSamples[j][l] * error;
                                    Weights[l][k] += perceptron;
                                }
                                Bais[k] = Bais[k] + LearningRate * error;
                            }
                        }
                    }
                    if (totalError == 0)
                        break;

                }
                if ((totalError == 0) && (currentLoopTime - current < Time)) isTrained = true;
                long End = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                ResultNeededTimeToTrain = End - current;
                ResultNeededEpochsToTrain = i;
            }
            else
            {
                int theNumberOfSampleTrainingSet = TrainSamples.Length;//عدد نماذج التدريب
                long currentLoopTime = 0, current = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                double totalError = 0;
                int i = 0;
                for (i = 0; i < Epochs; i++)
                {
                    totalError = 0;
                    for (int j = 0; j < theNumberOfSampleTrainingSet; j++)
                    {
                        for (int k = 0; k < NumOfOutputNeuren; k++)
                        {
                            double output = UniBipolarBinaryOutput(TrainSamples[j], k);

                            double error = DesiredOutput[j][k] - output;
                            totalError += Math.Abs(error);
                            if (error != 0)
                            {
                                for (int l = 0; l < NumOfInputNeuren; l++)
                                {
                                    double perceptron = LearningRate * TrainSamples[j][l] * error;
                                    Weights[l][k] += perceptron;
                                }
                            }
                        }
                    }
                    if (totalError == 0)
                        break;

                }
                if ((totalError == 0) && (currentLoopTime - current < Time)) isTrained = true;
                long End = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 1000 * 60 + DateTime.Now.Hour * 1000 * 3600;
                ResultNeededTimeToTrain = End-current;
                ResultNeededEpochsToTrain = i;
            }
        }

        public int UniBipolarBinaryOutput(double[] input, int k)
        {
            double sum = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Weights[i][k] * input[i];
            }
            if (WithBais)
                sum += Bais[k];

            if (sum > Threshold)
                return 1;
            else
                return 0;
        }
    }
}
