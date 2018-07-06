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
    /// Interaction logic for Sample_Input.xaml
    /// </summary>
    public partial class Sample_Input : UserControl
    {
        bool help = false;
        public Sample_Input()
        {
            InitializeComponent();
            sampleInputsMatTextBlock.Text = "";
        }

        private void addNewTrainSampleButton_Click(object sender, RoutedEventArgs e)
        {
            string sample = newSampleTextBox.Text;
            newSampleTextBox.Text = "";
            if (help)
                sampleInputsMatTextBlock.Text += "\n" + sample;
            else
                sampleInputsMatTextBlock.Text +=sample;

            help = true;
        }

     
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            sampleInputsMatTextBlock.Text = "";
            newSampleTextBox.Text = "";
            help = false;
        }

        private void newSampleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string sample = newSampleTextBox.Text;
                newSampleTextBox.Text = "";
                if (help)
                    sampleInputsMatTextBlock.Text += "\n" + sample;
                else
                    sampleInputsMatTextBlock.Text += sample;

                help = true;
            }
        }
    }
}
