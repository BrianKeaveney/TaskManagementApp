   M S B A M L   `   `   `  ����L  HTaskManagementApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TaskManagementAppTaskManagementApp  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      #    TaskManagementApp.AddTaskPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TaskManagementApp     5      6sys&clr-namespace:System;assembly=mscorlib     5      -   5          N� Title$  AddTaskPage��5
       N� 
Background �	#FF464343.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��0 10q�6,   $��Right=�6:   $	��200��6V   $��0��6b   .+�5      �� $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   Title:6g   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   Description:6m   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   	Category:6j   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   	Due Date:6j   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   	Priority:6j   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   	Labels:6h   �� 5      $
��0 10q�6   $��Right=�6"   $��20(�6>   
�������.��6_   Responsibility:6p   5      �� 5   
   $ Vertical=�6   $
��0 10q�6,   $
��left=�6:   $	��150��6U   $��1��6a   .+�5      �� -   5         ��Name$ tbxTitle��5      $
��0 20q�6(   $��Bottom=�66   6S   �� 5      -   5        $ tbxDescription��5      $
��0 20q�6.   $��Bottom=�6<   6Y   �� 5       -   5         ��Name$ cbxCategory��5       $
��0 20q�6,   $��Bottom=�6:   6W   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ 
tbxDueDate��5!      $
��0 15q�6-   $��Bottom=�6;   6Y   �� 5"      -   5        $ cbxPriority��5"      $
��0 20q�6,   $��Bottom=�6:   6W   �� 5#      -   5        $ 	tbxLabels��5#      $
��0 19q�6)   $��Bottom=�67   6T   �� 5$      $ 
Horizontal=�6   .+�5%      �� -   5        $ cbxResponsibility��5%      $
��0 16q�66   $��90��6D   $��Bottom=�6O   $
��Left=�6j   6�   �� 5&      -	   5         ��Name$ 
btnAddUser��5&      $��40��6-   $��22��68   $��10q�6D      buttonStyle#��[  6i   .��6�   Add6�   5'      5(      �� 5)   
   -
   5        $ 	btnFinish��5)      $��Finish��6$   $��1��65   $
��Left=�6E   $��274,378,0,0q�6`   $	��Top=�6u   $��94��6�   $��38��6�    J� RenderTransformOrigin$ 0.467,0.888&�6�   #��[  6�   �� 5*   
   -   5        $ 	btnCancel��5*      $��Cancel��6$   $
��Left=�65   $��
56,378,0,0q�6P   $	��Top=�6d   $��86��6|   $��38��6�   #��[  6�   5+      5,      