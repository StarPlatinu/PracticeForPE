   M S B A M L   `   `   `  ����L  HJsonDemonstration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:JsonDemonstrationJsonDemonstration  5   	   "    JsonDemonstration.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:JsonDemonstration     5   	   -   5          � Title$  
MainWindow��5   	   $	��430��6   $	��420��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� 
����ح� �� Orientation$ Vertical=�6-   $
��Left=�5      $	��400��64   .+�5      �� -   5        $��lblInstruction��5      
���  ��$��DemiBold"�6;   $��20(�5      $��Product Information��6"   �� 5      -   5        $��lblProductID��5      $��	ProductID��6(   �� 5      -   5        $��txtProductID��5      $
��Left=�6*   $��25��5      $	��300��6"   ��5      ��  �� Path$ 	ProductID� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ 
lvProducts��$ SelectedItem��� 5      -   5        $��lbProductName��5      $��Product Name��6)   �� 5      -   5        $��txtProductName��5      $
��Left=�6,   $��25��5      $	��300��6"   ��6/   �� $ ProductName�$ OneWay=� 5      �� $ 
lvProducts��$ SelectedItem��� 5       $ 
Horizontal=�6   $
��Left=�63   .+�5!      �� -   5        	 ��Name$	 	btnInsert��5!      $��10q�6,   $��70��68   $��Insert��6C   5"      �� 5#      -   5        $	 	btnUpdate��5#      $��10q�6-   $��70��69   $��Update��6E   5$      �� 5%      -	   5        $	 	btnDelete��5%      $��10q�6,   $��70��69   $��Delete��6D   5&      5'      5(      �� 5)   
   -
   5        $��
lvProducts��5)       $��1��6   $	��400��62   
 �� View
 5*      �� 5+      .P�5,      �� $��
Product ID��6%    �� Width$	 100��6:    �� DisplayMemberBinding 5-   %   �� $ 	ProductID��� 5.      $��Product Name��6%   $	 200��6;    5/   %   �� $ ProductName�50      52      54      55      