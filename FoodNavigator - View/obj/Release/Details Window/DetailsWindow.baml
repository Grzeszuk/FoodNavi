   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:FoodNavigator___View.Details_Window#FoodNavigator___View.Details_Window  7    1FoodNavigator___View.Details_Window.DetailsWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:FoodNavigator___View.Details_Window     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �    � Title$ DetailsWindow��$��458.48��$��498.993��.��� ���	#FF404040.+��� -    ��Name$ backgroundPhoto��$<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��$��UniformToFill=��� ���	#7F000000
���   ��� -    ��Name$ restaurantAddress��$��Label��$
��Left=�$��10,82.816,0,0q�$	��Top=�
�������$��Cabana)�$��48(� J� RenderTransformOrigin$ 
0.17,0.046&��� -   $ restaurantRating��$��Rating:��$
��Left=�$��10,235.6,0,0q�$	��Top=�
�������$��Cabana)�$��48(�$ 
0.17,0.046&��� -   $ restaurantOpen��$��Label��$
��Left=�$��10,134.729,0,0q�$	��Top=�
�������$��Cabana)�$��48(�$ 
0.17,0.046&��� -   $ restaurantPhone��$��Label��$
��Left=�$��10,288.6,0,0q�$	��Top=�
�������$��Cabana)�$��48(�$ 
0.17,0.046&�!  MahApps.Metro.Controls.Glow  $	��100��$��0,327,-0.007,0q�$	��Top=�
���  ��   	GlowBrush �	#FF1700FF$ 0.5,0.5&�(  "MaterialDesignThemes.Wpf.RatingBar  -     Name$ restaurantRatingBar��$
��Left=�$��150.154,258.509,0,0q�$	��Top=����	#FF2E00FF$ 0.5,0.5&�z�V� .~���  �� ScaleX$ 2Q� �� ScaleY$ 2Q��� �� T� �� -   	 ��Name$	 
openButton��$��open website��$
��Left=�$��250,361.98,0,0q�$	��Top=�$	��235��
�������
����������	#000097FF$��ONE DAY)�$��20(�$��46.386��  $	��100��$��1,1,-1.007,0q�$	��Top=�
���  �� �	#FF1700FF$ 0.5,0.5&�z�V� .~��� �� �� 
 �� Angle$

 -180Q�T� �� -   $	 navigateButton��$��navigate��$
��Left=�$��10,361.98,0,0q�$	��Top=�$	��235��
�������
����������	#000097FF$��ONE DAY)�$��20(�$��46.386���� -	   $ restaurantName��$��Label��$
��Left=�$��10,0,0,0q�$	��Top=�
�������$��Cabana)�$��72(�$ 
0.17,0.046&��� -
   $ restaurantOpenText��$��Label��$
��Left=�$��10,182.6,0,0q�$	��Top=�
�������$��Cabana)�$��48(�$ 
0.17,0.046&�