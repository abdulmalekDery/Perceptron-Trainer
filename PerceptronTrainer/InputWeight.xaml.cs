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
    /// Interaction logic for InputWeight.xaml
    /// </summary>
    public partial class InputWeight : UserControl
    {
        bool help = false;
        public InputWeight()
        {
            InitializeComponent();
        }

        private void AddNewWeights_Click(object sender, RoutedEventArgs e)
        {
            string sample = newWeight.Text;
            newWeight.Text = "";
            if (help)
                WeightsMatTextBlock.Text += "\n" + sample;
            else
                WeightsMatTextBlock.Text += sample;

            help = true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            newWeight.Text = "";
            WeightsMatTextBlock.Text = "";
            help = false;
        }

        private void newWeight_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.Key==Key.Enter)
            {
                string sample = newWeight.Text;
                newWeight.Text = "";
                if (help)
                    WeightsMatTextBlock.Text += "\n" + sample;
                else
                    WeightsMatTextBlock.Text += sample;

                help = true;
            }
        }
    }
}
