   M S B A M L   `   `   `  ����?  ;2048, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_2048_2048  5   	       _2048.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_2048     5   	   -   5          �Name$  Main_Window��5   	    � Title$
 2048��5   	   $	��425��6   $	��365��6#    � Icon$ App-Sudoku-icon.png��6/   ���	#FFF8F6E9 � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Templates.xaml?�6%   6?   %    5      .��5      � -   5         �Name$ Common_grid��5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � -   5        $ Grid_for_text��5      $��0��6&   $��70��63   $	��Top=�6?   $��5,5,5,0q�6W   ���	#FFF8F6E9 � ColumnDefinitions 5      �� 5      $
��50,* �6#   �� 5      $
��50,* �6#   .+�5      �� -   5        	 ��Name$		 brd��5      $��0��6"   
 �� CornerRadius$
 20��62   ._�5      �� -   5         ��Name$ Score_txt_block��5      $��0��65   6G   5      �� 5      -   5        $	 brd_high_score��5      $
 20��6-   $��1��6?   ._�5      �� -   5        $ High_score_txt_block��5      $��1��6:   5      5       � 5!   
   -   5        $ Grid_for_buttons��5!      $��1��6)   $��Bottom=�66   ���	#FFBBADA0$��5,0,5,5q�6h    5"      �� 5#      $
��25,* �6#   �� 5$      $
��25,* �6#   �� 5%      $
��25,* �6#   �� 5&      $
��25,* �6#    5(      �� 5)      $
��25,* �6    �� 5*      $
��25,* �6    �� 5+      $
��25,* �6    �� 5,      $
��25,* �6    5/      50      51      