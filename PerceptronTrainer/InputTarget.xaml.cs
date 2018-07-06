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
    /// Interaction logic for InputTarget.xaml
    /// </summary>
    public partial class InputTarget : UserControl
    {
        bool help = false;
        public InputTarget()
        {
            InitializeComponent();
        }

        private void AddNewTarget_Click(object sender, RoutedEventArgs e)
        {
            string sample = AddNewTargetTextBox.Text;
            AddNewTargetTextBox.Text = "";
            if (help)
                TargetMatTextBlock.Text += "\n" + sample;
            else
                TargetMatTextBlock.Text += sample;

            help = true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewTargetTextBox.Text = "";
            TargetMatTextBlock.Text = "";
            help = false;
        }

        private void AddNewTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) { 
                string sample = AddNewTargetTextBox.Text;
            AddNewTargetTextBox.Text = "";
            if (help)
                TargetMatTextBlock.Text += "\n" + sample;
            else
                TargetMatTextBlock.Text += sample;

            help = true;
            }
        }
    }
}
