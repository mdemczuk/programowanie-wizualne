   M S B A M L   `   `   `  ����@  <Lab06, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab06Lab06  5   	       Lab06.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab06     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��700��6)   .��5
      � .+�5   
   �� -   5         ��Name$ listView��5   .   $��183,10,184.6,91.4q�6    �� View 5      �� 5      .P�5      �� -   5        Name��$
��Name��5   3    �� Width$	 120��6A    �� DisplayMemberBinding 6M   �� *
ItemName+�� 5      -   5        ID��$��ID��5   1   $ 50��6=    6H   �� *	ItemIndex+�� 5      -   5        	Count��$��Count��5   4   $	 150��6C    6O   �� *	ItemCount+5      5      �� 5   
   -   5         ��Name$ button_save��5      $��Save to CSV file��6&   $
��Left=�6A   $��183,508,0,0q�6\   $	��Top=�6q   $	��107��6�   $��25��6�   6�   �� 5   
   -   5        $ button_read��5      $��Read from CSV file��6&   $
��Left=�6C   $��398,508,0,0q�6^   $	��Top=�6s   $	��111��6�   $��25��6�   6�   �� 5   
   -   5        $ 
button_add��5      $	��Add��6%   $
��Left=�63   $��
568,60,0,0q�6N   $	��Top=�6b   $��75��6z   6�   5      5      