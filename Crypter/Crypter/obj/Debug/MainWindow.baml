   M S B A M L   `   `   `  ����B  >Crypter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CrypterCrypter  5   	       Crypter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Crypter     5   	     � WindowStyle$
  None=�5   	   
������  � AllowsTransparency .  � Title$ 
MainWindow��5
   	   $	��200��6   $	��405��6)   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight# ZJ�6   %  System.Windows.SystemParameters"   WindowResizeBorderThickness   ResizeBorderThickness# Z 5       � 	Resources 5       �� Source�� 5   
   $ Resource/Styles.xaml?�6   %    .��5      �� 
���  ��$��1q�5      ._�5   
   � -   5        	 �Name$	 gird1��5      
 � ShowGridLines
 . ���	#AA888888 J� RenderTransformOrigin$ 
0.39,0.487&�6J    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $��* �6#   .+�5!      �� $��0��6   $��2��6&    �� Orientation$ 
Horizontal=�6:   $��5q�6S   $��Right=�5"      $	��Top=�5#      .+�5$      �� $��0��6      CaptionButtonStyleKey#���   6%   �� 5%      $��1��6   #���   6%   �� 5&      $��2��6   #���   6%   �� 5'      $��r��6   #���   6%   5(      o� 5*      $��1��6   #��Z��6    $
��Auto��6S   $��2��6`   .@�5+      m� #��Z��6   $��Files��6N   5,      �� 5-      -   5         ��Name$ textBox��5-      $
��Left=�6'   $��23��6B   $��	10,10,0,0q�6N   $��3��6a    �� TextWrapping$
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��200��6�   $��1��6�   �� 5.      -   5         ��Name$ button��5.      $��Button��6%   $��1��66   $
��Left=�6F   $��
220,10,0,0q�6a   $��3��6u   $	��Top=�6�   $��73��6�   $��23��6�   �� 5/      -   5        $ textBox_Copy��5/      $
��Left=�6,   $��23��6G   $��	10,51,0,0q�6S   $��3��6f   $
 Wrap=�6s   $��TextBox��6�   $	��Top=�6�   $	��200��6�   $��1��6�   �� 50      -   5        $ button_Copy��50      $��Button��6*   $��1��6;   $
��Left=�6K   $��
220,51,0,0q�6f   $��3��6z   $	��Top=�6�   $��73��6�   $��23��6�   �� 51      -   5         ��Name$ 	textBlock��51      $
��Left=�6+   $��	10,14,0,0q�6F   $��3��6Y   $
��Wrap=�6f   $��	TextBlock��6z   $	��Top=�6�   $��80��6�   �� 52      -   5        $ textBlock_Copy��52      $
��Left=�60   $��	10,55,0,0q�6K   $��3��6^   $
��Wrap=�6k   $��	TextBlock��6   $	��Top=�6�   $��80��6�   �� 53      $
��Left=�6   $��4��63   $��2��6@   $	��Top=�6T   $��20��6l   .@�54      �� -   5        $ textBlock_Copy2��54      $
��Left=�65   $
��Wrap=�6Q   $��	TextBlock��6e   $	��Top=�6v   $
��Auto��6�   55      56      57      58      