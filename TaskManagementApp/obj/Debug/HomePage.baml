   M S B A M L   `   `   `  ����L  HTaskManagementApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TaskManagementAppTaskManagementApp  5           TaskManagementApp.HomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TaskManagementApp     5      -   5          N� Title$  HomePage��5	       N� 
Background �	#FF464343.��5      �  � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��65* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $	��89* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ lbxTasks��5         tasksTemplate#��[  6$     priority#��[ 6R   $��0��6�   $��3,3,3,3q�6�   $��	56,6,56,0q�6�   $��2��6�   
�������6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��Center=�6;   $
��46,0q�6X   .+�5      �� -   5         ��Name$ 
btnAddTask��5      $	��Add��6)   $��Center=�67   $��40 20q�6T   $	��Top=�6c   $��75��6{     buttonStyle#��[ 6�   �� 5      -   5        $ btnEdit��5      $
��Edit��6&   $��Center=�65   $��40 20q�6R   $	��Top=�6a   $��75��6y   #��[ 6�   �� 5      -   5        $ btnCompleteTask��5      $��Complete��6.   $��Center=�6A   $��40 20q�6^   $	��Top=�6m   $��75��6�   #��[ 6�   �� 5      -   5        $ btnDeleteTask��5      $��Delete��6,   $��Center=�6=   $��40 20q�6Z   $	��Top=�6i   $��75��6�   #��[ 6�   5      �� 5   
   $ Vertical=�6   $��1��6,   $��0,9.233,0,5q�6<   $��2��6Q   .+�5      �� -   5        $ btnSave��5      $
��Save��6&   $
��0 30q�65   $��75��6C   #��[ 6d   �� 5       -   5        $ btnLoad��5       $
��Load��6&   $
��0 30q�65   $��75��6C   #��[ 6d   5!      �� 5"   
   -	   5        $ btnCompletedTasks��5"      $��Completed Tasks��6,   $
��20 0q�6F   $��20��6T   $��0��6�   $
��Left=�6�   $	��110��6�   #��[ 6�   �� 5#   
   $��1��6   $��0��6"   $ 
Horizontal=�62   $��Bottom=�6K   $
��Left=�6f   $��30��6�   $
��60 0q�6�   .+�5$      �� -
   5         ��Name$ tbxTaskSearch��5$      $��24��6-    �� TextWrapping$
 Wrap=�69   $�� ��6M   $	��120��6U   6a   �� 5%      -   5        	 ��Name$	 cbxPriority��5%      $	��120��6,   $
��36 0q�6\   �� 5&      -   5        $	 cbxCategory��5&      $	��120��6,   $
��20 0q�6\   5'      �� 5(   
   -   5        $ btnClearFilter��5(      $��Clear Filters��6)   $��Right=�6A   $��	0,10,10,0q�6]   $	��Top=�6p   $��75��6�   
 J� RenderTransformOrigin$
 	1.067,0.7&�6�   $��1��6�   #��[ 6�   �� 5)   
   $��0��6   $��1��6%   $��Right=�62   $ 
Horizontal=�6N   $
��40 0q�6g   $��Bottom=�6u   .+�5*      	� -   5         	�Name$ 
rdoClosest��5*      $��Closest��6.   $	��Top=�6@    	� 	GroupName$ 
DateFilter��6X   
�������6�   	� 5+      -   5        $ rdoFurthest��5+      $��Furthest��6/   $	��Top=�6B   $ 
DateFilter��6w   $	��5 0q�6�   
�������6�   5,      �� 5-   
   $��Task Managment App��6   $��Center=�6-   $��0��6J   $��0��6W   $��2��6g   $��28(�6{   $��Franklin Gothic Book)�6�   ���	#FFB60C0C$
��Bold"�6�   5.      5/      