   M S B A M L   `   `   `  ����K  GE_Maths_Learning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:E_Maths_LearningE_Maths_Learning  5      $    E_Maths_Learning.FlashCardMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:E_Maths_Learning     5        N� Title$  FlashCardMenu��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��0* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��
Flash Card��6   $��
10,10,10,0q�6%   $	��Top=�69   $��72(�6Q   
���   �$��1,1,1,1q�6s   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $
��Home��5      $��5��6    $��Center=�6-   $��36(�6H   $��1,1,1,1q�6V   $��483,0,483,0q�6h    � IsSharedSizeScope$
 True��6}   6�   �� 5   
   $��Center=�6   $��1��60   $��Center=�6=   $	��630��6X    �� 
IsEditable$
 True��6d   $��24(�6v   � 5   
   $��3��6    � ColumnDefinitions 5      �� 5      �� 5      $��* �6#   �� 5      .+�5      �� $��Create��6   $��Center=�6&   $��Center=�6C   $��36(�6^   $	��350��6l   �� 5       $��Delete��6   $��Center=�6&   $��Center=�6C   $��36(�6^   $	��350��6l   $��2��6x   �� 5!      $
��Edit��6   $��1��6$   $��Center=�64   $��Center=�6Q   $��36(�6l   $	��350��6z   5"      � 5#   
   $��4��6    5$      �� 5%      �� 5&      �� 5'      .+�5)      � .+�5*      �� $��Import��6   $��Center=�6*   $��Center=�6G   $��36(�6b   $	��350��6p   5+      �� 5,      $��Open File Directory��6   $��Center=�63   $��Center=�6P   $��36(�6k   $	��350��6y   $��2��6�   �� 5-      $
��Test��6   $��1��6$   $��Center=�64   $��Center=�6Q   $��36(�6l   $��350                     ��6z   5/      51      52      