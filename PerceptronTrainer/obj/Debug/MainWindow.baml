   M S B A M L   `   `   `  ����L  HPerceptronTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PerceptronTrainerPerceptronTrainer  5   	   H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   "    PerceptronTrainer.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PerceptronTrainer     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Perceptron Trainer��5	   	   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�6$   $	��550��5
      $	��975��6(    � WindowState$ 	Maximized=�5      
����  �   	GlowBrush
 ��  � � 	Resources 5       �� 
TargetType   GroupBoxHeader �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��$ 18(�6)   66   �� 5       � ��
 ���� 6A   �� 5       � ��
 �   �6;   �� 5       � ��$ 4q�6'   63   5      5      .��5      � .+�5   
   �� $��wallhaven-284217.jpg��6   $��UniformToFill=�6.    J� OpacityMask 5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Offset$
 0.03Q�6#    � Color$ 	#00000000��61   � 5      $	 0.9Q�6#   $ 	#FF000000��60   5      5      � 5   
    � RowDefinitions 5      �� 5       $��2* �6    �� 5!      $��* �6     � ColumnDefinitions 5#      �� 5$      $��3* �6#   �� 5%      $
��auto �6#   .+�5(      =  7MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl  -   5          Name$ MainTap��5(   8   5)      � 5,      $��1��6   $��0��6#   .+�5-      �� $��
Parameters��6   .��5.      �� $
��Auto=�6#   $
��Auto=�6F   .��5/      �� .+�50      �� -   5        $��5q�50   %   .��6O   Enter Train Sample6c   �� 52      -   5        $��5q�52   %   .��6O   Enter desired output6e   �� 53      -   5        $��activationCombo��53   2   $��5q�6'   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$  Choose Activation Function��6I   .@�54   "   �� .��6/   Bipolar Bainary Function6I   �� 55   "   .��6/   Unipolar Bainary Function6J   56      �� 57       �� Orientation$ 
Horizontal=�6)   .+�58   "   �� -   5         ��Name$ SetBaisCheckBox��58   6   $��5q�6+   .��6O   	With Bias6Z   �� 59   "   -   5        $��baisMatTextBox��59   *   $ 
Enter bais��6@   $��5q�6n   $	��230��6y   {�6�   ��  �� ElementName$ SetBaisCheckBox�� �� Path$ 	IsChecked� �� UpdateSourceTrigger$ PropertyChanged=�.��6�   5:   #   5;      �� 5<      $ 
Horizontal=�6)   .+�5=   "   �� -   5        $ SetWeightManuallyCheckBox��5=   8   $��5q�6+   .��6\   Set Weights Manually6r   �� 5>   "   -   5        $��openSetWeightButton��5>   a   $��5q�6J   $	��150��6U   $
��Left=�5?      {�5>   |   �� $ SetWeightManuallyCheckBox��$ 	IsChecked�.��5?   8   Enter Weights5@   #   5A      �� 5B      -	   5        $��epochsTextBox��5B   �      SelectAllOnFocus .    UseFloatingWatermark . $ Epochs��6�   $��5q�6�   6�   �� 5C      -
   5        $��LearningRateTextBox��5C   �    .  . $ Learning Rate��6�   $��5q�6�   6�   �� 5D      -   5        $��TimeTextBox��5D   �    .  . $ 
Time in ms��6�   $��5q�6�   6�   �� 5E      -   5        $��ThreasholdTextBox��5E   �    .  . $ 
Threashold��6�   $��5q�6�   6�   �� 5F      $ 
Horizontal=�6)   .+�5G   "   �� -   5        $��5q�5G   )   $	��150��6M   .��6Y   Train6`   �� 5H   "   -   5        $��5q�5H   )   $	��150��6L   .��6X   Test6^   5I      5J      5K      5L      5M      � 5O      $��1��6   $��1��6#   62   �� 5Q      $��Network Drawing:��6   $��0q�61   $��0��6F   $��1��6V   #��[  6c   .��5S      �� $
��Auto=�6   $
��Auto=�6A   .��5T      � -   5        $��networkBoard��5T      5W      5X      5Y      �� 5Z      -   5         ��Name$ button��5Z      $��Modify��6%   $
��Left=�66   $��1��6Q   $��1��5[      $	��Top=�6"   $��75��6:   5]      5^      5_      