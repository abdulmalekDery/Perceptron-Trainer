   M S B A M L   `   `   `  ����L  HPerceptronTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PerceptronTrainerPerceptronTrainer  5          PerceptronTrainer.Start   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PerceptronTrainer     5      .��5
   
   �� $
��Auto=�6   $
��Auto=�6:   .��5   
   � .+�5      �� $��16(�6   $��How to use this Software:��6&   $��	10,10,0,0q�6G   $	��Top=�6Z   $
��Left=�6r   6�   �� 5      $��14(�6   $
��Left=�6&   $����1- Click on "Enter Train Sample" Button then enter the train samples each sample in a line and separate each two samples by comma   
2- Next, Click on "Enter desired output" Button then enter each desired output for all output neuron in one line and separate 
 each two output by a comma note that each desired output lineshould match each line from the previous step                      
3- Then from the drop down list "Choose Activation Function" combo box choose the suitable activation function for your input                    
4- Then check on "With Bias" CheckBox if you want to use bais ,if you want random bais you can type "random" inside "Enter bais"textBox                   
5- Then check "Set Weights Manually" checkBox to enter the weights manually note that if you didn't check this checkBox the weights will be random                   
6- Then fill in the rest textBox with suitable information and click on "Train" Button to train this network                   
7- After train the network you can test it by click on "Test" Button and input test sample to get correct output ��6A   $��10,35,10,40q�5   �   5      5      5      