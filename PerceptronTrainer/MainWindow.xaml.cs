using MahApps.Metro.Controls;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Work work;
        Perceptron p;
        public MainWindow()
        {
            work = new Work();
            InitializeComponent();
            Start st = new Start();
            MainTap.Items.Add(st);
            Sample_Input s = new Sample_Input();
            s.confirmButton.Click += delegate
            {
                work.GetTrainSamples(s.sampleInputsMatTextBlock.Text);
                MainTap.SelectedIndex = 0;
            };
             MainTap.Items.Add(s);
            InputTarget t = new InputTarget();
            t.confirmButton.Click += delegate
              {
                  work.GetDesireds(t.TargetMatTextBlock.Text);
                  MainTap.SelectedIndex = 0;
              };
            MainTap.Items.Add(t);
            InputWeight w = new InputWeight();
            w.confirmButton.Click += delegate
              {
                  work.GetWeights(w.WeightsMatTextBlock.Text);
                  MainTap.SelectedIndex = 0;
              };
            MainTap.Items.Add(w);
            Test test = new Test();
            test.Test1.Click += delegate
            {
                string []text = test.newSampleTextBox.Text.Split(',');
                double[] inputs = new double[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    inputs[i] = double.Parse(text[i]);
                }
                string outo = "";
                if (isBipolar(work.p.DesiredOutput)) 
                for (int i = 0; i < work.p.NumOfOutputNeuren; i++)
                {
                        outo += work.p.BipolarBinaryOutput(inputs, i);
                }

                if (isUniBipolar(work.p.DesiredOutput))
                    for (int i = 0; i < work.p.NumOfOutputNeuren; i++)
                    {
                        outo += work.p.UniBipolarBinaryOutput(inputs, i);
                    }
                test.ResultOutputTextBlock.Text = outo;

            };
            
           
            test.cansleButton.Click += delegate
            {
                MainTap.SelectedIndex = 0;
                work = new Work();
            };
            MainTap.Items.Add(test);
          
        }

        private void EnterSampleInputClick(object sender, RoutedEventArgs e)
        {
           MainTap.SelectedIndex = 1;
        }

        private void EntermatrixTargetClick(object sender, RoutedEventArgs e)
        {
            MainTap.SelectedIndex =2;
        }

        private  void openSetWeightButtonClick(object sender, RoutedEventArgs e)
        {
            MainTap.SelectedIndex = 3;

        }

        private void TestButtonClick(object sender, RoutedEventArgs e)
        {
            MainTap.SelectedIndex = 4;
        }

        private void TrainButtonClick(object sender, RoutedEventArgs e)
        {
            if ((bool)SetBaisCheckBox.IsChecked)
                if (baisMatTextBox.Text.Equals("random"))
                    work.SetRandomBais();
                else
                    work.GetBais(baisMatTextBox.Text);
            if (!(bool)SetWeightManuallyCheckBox.IsChecked)
                work.SetRandomWeights();

            //if(activationCombo.SelectedIndex==0)
            //p = work.Train(ThreasholdTextBox.Text, LearningRateTextBox.Text, epochsTextBox.Text, TimeTextBox.Text, ActivationFunction.BipolarBinary);
            //if(activationCombo.SelectedIndex == 1)
            //    p = work.Train(ThreasholdTextBox.Text, LearningRateTextBox.Text, epochsTextBox.Text, TimeTextBox.Text, ActivationFunction.UnipolarBinary);

            if(isBipolar(work.p.DesiredOutput))
                 p = work.Train(ThreasholdTextBox.Text, LearningRateTextBox.Text, epochsTextBox.Text, TimeTextBox.Text, ActivationFunction.BipolarBinary);
            if(isUniBipolar(work.p.DesiredOutput))
                p = work.Train(ThreasholdTextBox.Text, LearningRateTextBox.Text, epochsTextBox.Text, TimeTextBox.Text, ActivationFunction.UnipolarBinary);

            Train train = new Train();
            train.resultEpochsTextBlock.Text = p.ResultNeededEpochsToTrain+1+"";
            train.resultTimeTextBlock.Text = p.ResultNeededTimeToTrain + "";
            string result = "";
            for (int i = 0; i < p.Weights.Length; i++)
            {
                for (int j = 0; j < p.Weights[0].Length; j++)
                {
                    result += p.Weights[i][j] + ",";
                }
                result += "\n";
            }
            train.resultWeightsMatrix.Text = result;
            result = "";
         if(p.WithBais)
            for (int i = 0; i < p.Bais.Length; i++)
            {
                if(i>0)
                result += ","+p.Bais[i] ;
                else result += p.Bais[i];
            }
            train.resultBaisMatrixTextBlock.Text = result;
            MainTap.Items.Add(train);
            MainTap.SelectedIndex = 5;
            DrawNetwork();
        }

        public bool isBipolar(double[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length; j++)
                {
                    if (a[i][j] == -1) return true;
                }
            }
            return false;
        }


        public bool isUniBipolar(double[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length; j++)
                {
                    if (a[i][j] == -1) return false;
                }
            }
            return true;
        }
        public void DrawNetwork()
        {
            Path allNeuron = new Path();
            Path allWeights = new Path();
           
            GeometryGroup neuron = new GeometryGroup();
            GeometryGroup weights = new GeometryGroup();
            
            EllipseGeometry[] InputNeurons = new EllipseGeometry[p.NumOfInputNeuren];
            EllipseGeometry[] OutputNeurons = new EllipseGeometry[p.NumOfOutputNeuren];
           
            Point[] Start = new Point[p.NumOfInputNeuren];//don't forget bais.length
            Point[] End = new Point[p.NumOfOutputNeuren];

            //neuron section
            for (int i = 0; i < InputNeurons.Length; i++)
            {
                Start [i]= new Point(200, 40 * (i + 1) / 0.9);
                InputNeurons[i] = new EllipseGeometry(Start[i], 20, 20);
                neuron.Children.Add(InputNeurons[i]);
            }

            for (int i = 0; i < OutputNeurons.Length; i++)
            {
                End[i] = new Point(800, 40 * (i + 1) / 0.9);
                OutputNeurons[i] = new EllipseGeometry(End[i], 20, 20);
                neuron.Children.Add(OutputNeurons[i]);
            }

           

            allNeuron.StrokeThickness = 0.3;
            allNeuron.Stroke = Brushes.BlueViolet;
            allNeuron.Fill = Brushes.Blue;
            allNeuron.Data = neuron;
            

            //line section
            for (int i = 0; i < InputNeurons.Length; i++)
            {
                for (int j = 0; j < OutputNeurons.Length; j++)
                {
                    LineGeometry lg = new LineGeometry(Start[i], End[j]);
                    weights.Children.Add(lg);
                }
            }
           
        



            Path allBais = new Path();
            if ((bool)SetBaisCheckBox.IsChecked)
            {
                
                EllipseGeometry[] BaisNeurons = new EllipseGeometry[p.Bais.Length];
                GeometryGroup bais = new GeometryGroup();
                 Start = new Point[BaisNeurons.Length];

                for (int i = 0; i < BaisNeurons.Length; i++)
                {
                    Start[i] = new Point(200, 40 * (i + 1 + p.NumOfInputNeuren) / 0.9);
                    BaisNeurons[i] = new EllipseGeometry(Start[i], 20, 20);
                    bais.Children.Add(BaisNeurons[i]);
                }

                for (int i = 0; i < BaisNeurons.Length; i++)
                {
                    LineGeometry lg = new LineGeometry(Start[i], End[i]);
                    weights.Children.Add(lg);
                }

                allBais.StrokeThickness = 0.3;
                allBais.Stroke = Brushes.Black;
                allBais.Fill = Brushes.Firebrick;
                allBais.Data = bais;

            }

            allWeights.StrokeThickness = 1.3;
            allWeights.Stroke = Brushes.Black;
            allWeights.Fill = Brushes.AliceBlue;
            allWeights.Data = weights;

            networkBoard.Children.Add(allWeights);
            networkBoard.Children.Add(allNeuron);
            networkBoard.Children.Add(allBais);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
