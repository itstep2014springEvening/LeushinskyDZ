   M S B A M L   `   `   `  ����G  CBrowserPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BrowserPanelBrowserPanel  5   	       BrowserPanel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )myclr-namespace:BrowserPanel     5   	     � Title$+  %Демонстрация User Control��5   	   $	��350��6+   $	��525��68   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5	      $
��auto �6   6,   �� 5
      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   %   BrowserPanel.BrowsePanelControl  -   5          Name$ brsMain��5       $��0��6�      FileName 61   ��  �� ElementName$ tbSetFileName�� �� Path$
 Text� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   '   !BrowserPanel.BrowsePanelControlNo  5   
   -   5          Name$ 	brsMainNo��5   "   	   FileName$	 
пусто��65   $��1��6F   6U   �� 5   
   $&�� Введите имя файла��6   $��2��6,   6;   �� 5   
   -   5        
 ��Name$
 tbSetFileName��5      
���   �$��5q�6>   $��3��6I   6Y   �� 5   
   -   5        $��4��5   &   $��50��63   $
��Left=�6>   $��5q�6Y   .��6d   #!Просмотр значения6w   5      5      