   M S B A M L   `   `   `  ����L  HPerceptronTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PerceptronTrainerPerceptronTrainer  5      H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      $    PerceptronTrainer.Sample_Input   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PerceptronTrainer     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      .��5
      �� $��Train Samples:��6   $��0q�6'   .��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��newSampleTextBox��5   �   *  $MahApps.Metro.Controls.TextBoxHelper   SelectAllOnFocus .    UseFloatingWatermark . $	��860��6|   $��18(�6�      	Watermark$ 
New Sample��6�   6  �� 5      -   5        $��AddNewTrainSampleButton��5      $��12(�6^   .��6l   Add new inupt6{   5      �� 5   
   $��1��6   $ ��The Sampels For Training :��6   $��18(�6C   6S   �� 5   
   -   5        $��sampleInputsMatTextBlock��5      $��5q�6   $��2��6?   �� 5   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5   
   �� -   5        $��confirmButton��5      $��Confirm��6&   $��0,0,20,0q�68   $��Center=�6J   $��80��6h   �� 5      -   5        $��ClearButton��5      $��Clear��6(   $��Center=�6R   $��80��6p   5      5      5      5       