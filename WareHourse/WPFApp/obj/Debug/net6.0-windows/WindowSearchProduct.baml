   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	        WPFApp.WindowSearchProduct   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	     � Title$  WindowSearchProduct��5   	   $	��450��6%   $	��800��62   .��5	      � 
��� ���.+�5
   
   �� -   5        $��search��5
   .   $
��Left=�6   $��
428,50,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��229��6|   $��32��6�   �� 5   
   -   5        
���<��
�������$��Search��5   9   $
��Left=�6a   $��
684,50,0,0q�6|   $	��Top=�6�   $��32��6�   $��81��6�   �� 5   
   -   5        $��lbTitle��5      $��Search Product Info��6   $��Times New Roman)�6=   $��30(�5      $��Black"�6"   
�������$	��282��6H   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataProduct��5      $��10,105,10,72q�6&      AutoGenerateColumns$ False��6<      RowBackground
 �����   AlternatingRowBackground
 ��ح�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ 	ProductId��6/      
IsReadOnly$
 true��6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� *	ProductId+6`     5      $ * 6%   $ 
CategoryId��6/   	 6C   �� *
CategoryId+  5      $ * 6%   $ ProductName��6/   	 6D   �� *ProductName+  5      $ * 6%   $ Weight��6/   	 6?   �� *Weight+  5      $ * 6%   $ 	UnitPrice��6/   	 6B   �� *	UnitPrice+  5      $ * 6%   $ UnitslnStock��6/   	 6E   �� *UnitsInStock+5      �� 5   
   -   5        
���<��
�������$��Close��5   9   $
��Left=�6_   $��684,380,0,0q�6z   $	��Top=�6�   $��32��6�   $��81��6�   5      5      