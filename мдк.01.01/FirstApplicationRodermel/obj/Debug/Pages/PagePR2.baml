   M S B A M L   `   `   `  ����S  OFirstApplicationRodermel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:FirstApplicationRodermel.PagesFirstApplicationRodermel.Pages  5      ,    &FirstApplicationRodermel.Pages.PagePR2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:FirstApplicationRodermel.Pages     5        N� Title$  PagePR2��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�5      .+�5      �� $q��kЛабораторная работа №2. Вариант №8. Выполнил Родермель А.В.��6   
�������5      5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Center=�5      .+�5      �� $ Vertical=�6   $��Center=�5      .+�5      �� $ 
Horizontal=�6   $��Center=�5      .+�5      �� $'��!Введите значение X��6    $��10q�5      
���z���5       �� 5!      -   5        $
��txtX��5!      $��10q�6*   $	��100��66   5"      �� 5#      $ 
Horizontal=�6   $��Center=�5$      .+�5%      �� $'��!Введите значение M��6    $��10q�5&      
���z���5'      �� 5(      -   5        $
��txtM��5(      $��10q�6*   $	��100��66   
�������6B   5)      5*      �� 5+      $ Vertical=�6   $��Center=�5,      $��20q�5-      .+�5.      	� -   5        $��rbtSh��5/       	� 	GroupName$ Function��5.      $��sh(x)��50       d� 	IsChecked$
 TrueY�51      $��10q�52      
�������53      	� 54      -   5        $��rbtX2��55      $ Function��54      $	��x^2��56      $��10q�57      
�������58      	� 59      -   5        $��rbtExpX��5:      $ Function��59      $	��e^x��5;      $��10q�5<      
�������5=      5>      5?      �� 5@   
   $��2��6   $ Vertical=�6"   $��Center=�5A      .+�5B      �� $A��;Результат выполнения программы:��6   $��10q�5C      
���z���5D      �� 5E      -   5        $��	lstResult��5E      $��10q�6'   $	��150��5F      5G      ]� 5I   
   $��3��6   $��Center=�5J      .+�5K      �� -   5        $��btnCalc��5K         BtnStyle#��[  6$   $��Выполнить��5L      5M      �� 5N      -   5        $��btnClear��5N      #��[  6%   $��Очистить��5O      5P      5Q      5S      5T      