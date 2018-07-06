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
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newSampleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            newSampleTextBox.Text = "";
            ResultOutputTextBlock.Text = "";
        }
    }
}
