   M S B A M L   `   `   `  ����L  HPerceptronTrainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PerceptronTrainerPerceptronTrainer  5          PerceptronTrainer.Train   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PerceptronTrainer     5      .��5	      �� $��Output Results:��6   $��0q�6(   .��5
   
   �� .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� $��Result Epochs:��6   $��0��6.   $��0��6>   $��
10,10,1,10q�6K   $��14(�6_   �� 5      -   5        $��resultEpochsTextBlock��5      $��0��65   $��1��6B   $��
10,10,1,10q�6S   $��12(�6g   �� 5      $��0��6   $��1��6(   $��Result Time:��65   $��
10,10,1,10q�6J   $��14(�6^   �� 5      -   5        $��resultTimeTextBlock��5      $��1��64   $��1��6D   $��
10,10,1,10q�6Q   $��12(�6e   �� 5      $��Result Bais Matrix:��6   $��0��63   $��2��6C   $��
10,10,1,10q�6P   $��14(�6d   �� 5      -   5        $��resultBaisMatrixTextBlock��5      $��1��69   $��2��6I   $��
10,10,1,10q�6W   $��12(�6k   �� 5      $��Result Weights Matrix:��6   $��0��66   $��3��6F   $��
10,10,1,10q�6T   $��14(�6h   �� 5      -   5        $��resultWeightsMatrix��5      $��1��63   $��3��6C   $��
10,10,1,10q�6P   $��14(�6d   5      5       5!      5"      