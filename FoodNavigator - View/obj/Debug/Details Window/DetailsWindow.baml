   M S B A M L   `   `   `  ����O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:FoodNavigator___View.Details_Window#FoodNavigator___View.Details_Window  5   	   7    1FoodNavigator___View.Details_Window.DetailsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:FoodNavigator___View.Details_Window     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5
       � Title$ DetailsWindow��5   	   $��458.48��6   $��498.993��6/   .��5      � ���	#FF404040.+�5   
   �� -   5         ��Name$ backgroundPhoto��5      $<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��6)   $��UniformToFill=�6i   �� 5   
   ���	#7F000000
���   �6%   �� 5   
   -   5         ��Name$ restaurantAddress��5      $��Label��6+   $
��Left=�6;   $��10,82.816,0,0q�6V   $	��Top=�6m   
�������$��Cabana)�6�   $��48(�6�    J� RenderTransformOrigin$ 
0.17,0.046&�6�   �� 5   
   -   5        $ restaurantRating��5      $��Rating:��6*   $
��Left=�6<   $��10,235.6,0,0q�6W   $	��Top=�6m   
�������$��Cabana)�6�   $��48(�6�   $ 
0.17,0.046&�6�   �� 5   
   -   5        $ restaurantOpen��5      $��Label��6(   $
��Left=�68   $��10,134.729,0,0q�6S   $	��Top=�6k   
�������$��Cabana)�6�   $��48(�6�   $ 
0.17,0.046&�6�   �� 5   
   -   5        $ restaurantPhone��5      $��Label��6)   $
��Left=�69   $��10,288.6,0,0q�6T   $	��Top=�6j   
�������$��Cabana)�6�   $��48(�6�   $ 
0.17,0.046&�6�   !  MahApps.Metro.Controls.Glow  5   
   $	��100��6   $��0,327,-0.007,0q�6%   $	��Top=�6=   
���  ��   	GlowBrush �	#FF1700FF$ 0.5,0.5&�6|   (  "MaterialDesignThemes.Wpf.RatingBar  5   
   -   5          Name$ restaurantRatingBar��5   #   $
��Left=�6@   $��150.154,258.509,0,0q�6[   $	��Top=�6x   ���	#FF2E00FF$ 0.5,0.5&�6�   z�5      V� 5      .~�5      ��  �� ScaleX$ 2Q�6%    �� ScaleY$ 2Q�60   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        	 ��Name$	 
openButton��5      $��open website��6%   $
��Left=�6<   $��250,361.98,0,0q�6W   $	��Top=�6o   $	��235��6�   
�������
����������	#000097FF$��ONE DAY)�6�   $��20(�6�   $��46.386��6    5    
   $	��100��6   $��1,1,-1.007,0q�6%   $	��Top=�6;   
���  �� �	#FF1700FF$ 0.5,0.5&�6z   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%      
 �� Angle$

 -180Q�6&   T� 5&      5'      5)      �� 5*   
   -   5        $	 navigateButton��5*      $��navigate��6)   $
��Left=�6<   $��10,361.98,0,0q�6W   $	��Top=�6n   $	��235��6�   
�������
����������	#000097FF$��ONE DAY)�6�   $��20(�6�   $��46.386��6  �� 5+   
   -	   5        $ restaurantName��5+      $��Label��6(   $
��Left=�68   $��10,0,0,0q�6S   $	��Top=�6e   
�������$��Cabana)�6�   $��72(�6�   $ 
0.17,0.046&�6�   �� 5,   
   -
   5        $ restaurantOpenText��5,      $��Label��6,   $
��Left=�6<   $��10,182.6,0,0q�6W   $	��Top=�6m   
�������$��Cabana)�6�   $��48(�6�   $ 
0.17,0.046&�6�   5-      5.      