   M S B A M L   `   `   `  ����E  AMouseMover, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MouseMover
MouseMover  5   	       MouseMover.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MouseMover     5   	     � Title$  Idle Program��5   	   $	��250��6   $	��450��6+    � Icon$ /Computer.png��67   ���	#FFB7E0CE
���   �.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ 	start_btn��5      $��
Start Idle��6$   $��0��69   $��1��6I   $��50��6V   $	��150��6e   6t   �� 5   
   $*��$Enter your idle interval in seconds:��6   $��0��6?   $��0��6O   $��Center=�6\   $	��Top=�6�   �� 5   
   -   5         ��Name$ seconds_label��5      $��Seconds must be over 5!��6'   $��0��6I   $��0��6Y   $��Center=�6f   $��Bottom=�6�   �� 5   
   -   5         ��Name$ 	input_str��5      $��0��6m   $��0��6}   $��20��6�    �� MaxLines$ 1��6�    �� 	MaxLength$ 5��6�   $	��150��6�   $��60��6�   �� 5   
   $��Status:��6   $��1��6"   $��1��62   $��Center=�6?   $	��Top=�6c   �� 5   
   -   5        $ 	Operation��5      $��Operation aborted��6#   $��1��6?   $��1��6O   $��Center=�6\   $��Bottom=�6�   �� 5   
   -   5        	 ��Name$	 Status��5      $��1��6$   $��1��64   
���   �$��50��6P   $	��100��6\   �� 5   
   -   5        
 ��Name$
 Smooth_Mouse��5      $��Smooth Mouse��6)   $��1��6@   $��Center=�6P   $��Center=�6k   6�   5      5      