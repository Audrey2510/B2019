   M S B A M L   `   `   `  ����C  ?Cookbook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CookbookCookbook  5          Cookbook.SearchPage1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Cookbook     5        N� Title$  SearchPage1��5	      .��5      � .+�5   
   �� -   5         ��Name$ scroll1��5      $
��Left=�6(   $��92��6C   $	��Top=�6O   $	��576��6g    �� PanningMode$ HorizontalOnly=�6s   $��Disabled=�6�   $��Hidden=�6�   �� 5   
   -   5        $��Find Recipes��5      $
��Left=�6(   $��157,437,0,0q�6C   $	��Top=�6X   $	��254��6p   $��50��6|   ���	#FFAF413B$��36(�6�      CustomButtonStyle#��[  6�   �� 5   
   -   5         ��Name$ 	searchBar��5      $
��Left=�6%   $��39��6@   $��
70,118,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6u   $	��228��6�   $��20(�6�   �� 5   
   -   5        $ ingredsearchBar��5      $
��Left=�6+   $��39��6F   $��319,118,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��175��6�   $��20(�6�   6�   �� 5   
   -   5         ��Name$ IngredientTags��5       �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��58��6a   $��
70,183,0,0q�6m   $	��Top=�6�   $	��367��6�   5      �� 5   
   $��Search��6   $
��Left=�6!   $��	70,87,0,0q�6<   $	��Top=�6O    J� RenderTransformOrigin$ 0.783,0.308&�6g   $	��228��6�   �� 5   
   $��Ingredient Search��6   $
��Left=�6,   $��
319,87,0,0q�6G   $	��Top=�6[   $	��175��6s   �� 5   
   -   5         ��Name$ resetButton��5      $��Reset Search��6&   $
��Left=�6=   $��229,381,0,0q�6X   $	��Top=�6m   $	��105��6�   $��34��6�   $��16(�6�   6�      Cookbook.FilterBar  5   
   -   5        	  Name$	 	filterBar��5      $
��Left=�6-   $	��102��6H   $��
70,194,0,0q�6U   $	��Top=�6i   $	��424��6�   �� 5   
   $��Filter��6   $
��Left=�6!   $��
70,162,0,0q�6<   $	��Top=�6P   $��27��6h   $	��100��6t      Cookbook.SortBar  5   
   $
��Left=�6   $��161,319,0,0q�63   $	��Top=�6H   $��85��6`   $	��250��6l   �� 5   
   -   5        
 ��Name$
 
FridgeBack��5      
�������$
��Left=�64   $	��453��6O   $��
70,183,0,0q�6\   $	��Top=�6p   $	��424��6�   $y�	Collapsed=�6�   �� 5   
   -	   5        $ Fridge��5      $
��Left=�6'   $	��453��6B   $��
70,183,0,0q�6O   $	��Top=�6c   $	��424��6{   $ VerticalOnly=�6�   $��Hidden=�6�   $��Disabled=�6�   $y�	Collapsed=�6�   �� 5    
   -
   5        $ FridgeClose��5       $��Close��6&   $
��Left=�66   $��419,183,0,0q�6Q   $	��Top=�6f   $��75��6~   $��29��6�   #��[  6�   $y�	Collapsed=�6�   �� 5!   
   -   5        $ 
FridgeOpen��5!      
�������$
��More��6G   $
��Left=�6V   $��437,183,0,0q�6q   $	��Top=�6�   $��57��6�   $��58��6�   #��[  6�   $y�	Collapsed=�6�   5#      5$      