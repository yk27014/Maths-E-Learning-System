   M S B A M L   `   `   `  ����K  GE_Maths_Learning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:E_Maths_LearningE_Maths_Learning  5           E_Maths_Learning.TopicMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:E_Maths_Learning     5      -   5          N�Name$  topicMenuPage��5       N� Title$ 	TopicMenu��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $
��0.5* �6   .+�5   
   �� -   5         ��Name$ topicTitleLabel��5      $��Topics��6)   $��10,10,10,10q�6:   $��72(�6O   
���   �$��1,1,1,1q�6q   $��Center=�6�   $��Center=�6�   
�������$��5,0,5,5q�6�   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��1��6    5      �� 5      $��6* �6$   .+�5      �� -   5         ��Name$ topicOptionsBox��5      $��1q�62   
���   �$��10,10,10,10q�6Z   ._�5      �  5      �� 5      �� 5      $��* �6/    5!      �� 5"      �� 5#      $��* �6,   .+�5%      �� -   5         ��Name$ studyBtn��5%   !   $��Study��63   $��36(�6C   $��10,10,10,10q�6h   
�������6}   �� 5&      -   5        $ 	randomBtn��5&   !   $
��Test��64   $��36(�6C   $��2��6g   $��10,10,10,10q�6t   
�������6�   �� 5'      $H��BPlease select the topics you wish to learn and then press "Study".��6$   $
��Wrap=�6x   $��10,10,10,10q�6�   $��18(�6�    �� TextAlignment$ Justify=�6�   $��1��6�   �� 5(      $3��-Asks questions randomly from selected topics.��6$   $
��Wrap=�6Y   $��10,10,10,10q�6m   	 �� Padding$	 5,5,5,5q�6�   $��1��6�   $��2��6�   $��18(�6�   $ Justify=�6�   5)      5*      5,      �� 5-      -   5        $ topicBorder��5-      $��1q�6*   
���   �$��10,10,10,10q�6R   
�������._�5.      �  5/      �� 50      �� 51      �� 52      �� 53      �� 54      .+�56      �� $��1q�6   ._�57      �� -   5        
 ��Name$
 algebraCheckBox��57   #   $��Algebra��6<   $��40(�6N   $��9,9,9,9q�6\   58      �� 59      $��1q�6   $��1��61   ._�5:      �� -   5        $
 calculusCheckBox��5:   #   $��Calculus��6=   $��40(�6P   $��9,9,9,9q�6^   5;      �� 5<      $��1q�6   $��2��61   ._�5=      �� -	   5        $
 geometryCheckBox��5=   #   $��Geometry��6=   $��40(�6P   $��9,9,9,9q�6^   5>      �� 5?      $��1q�6   $��4��61   ._�5@      �� -
   5        $
 trigonometryCheckBox��5@   #   $��Trigonometry��6A   $��40(�6X   $��9,9,9,9q�6f   5A      �� 5B      $��1q�6   $��5��61   �� 5C      -   5        $"
 simultaneousEquationCheckBox��5C      $��Simultaneous Equations��6E   $��40(�6f   $��10,10,10,11q�6t   $��3��6�   5D      5E      5F      �� 5G   
   -   5        $ homeBtn��5G      $
��Home��6"   $��10,10,10,10q�61   $��2��6F   $��36(�6S   
�������6w   5I      5J      