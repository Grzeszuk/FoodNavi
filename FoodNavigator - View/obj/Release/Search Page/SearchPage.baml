   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FoodNavigator___View.Search_page FoodNavigator___View.Search_page  1    +FoodNavigator___View.Search_page.SearchPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:FoodNavigator___View.Search_page     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls    N� Title$  
SearchPage��.��� -   ����  �� ImageSource$ background4.jpg�� j� Stretch$ UniformToFill=�.+��� ���	#00000000
���   �!  MahApps.Metro.Controls.Glow  $	��137��$��0,-1,0,0q�$	��Top=�   	GlowBrush �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&����	#FF1700FFz�V� .~��� �� ��  �� Angle$
 -180Q�T� �� $�� ��$
��Left=�$	��Top=�$��122.729,2.134,0,0q��� $��Search options:
�����	#CCFFFFFF$��ONE DAY)�$��48(�$��	10,10,0,0q�$
��Left=�$��387.573��$��87.93��$	��Top=��� $��1.Food Types:
��
�������$��ONE DAY)�$��36(�$��38.131,131.254,0,0q�$��70.842��$	��Top=�$
��Left=�$��248.163���� $��2.Transport Types:
�����	#F8FFFFFF$��ONE DAY)�$��36(�$��38.131,386.105,774.762,0q�$��65.842��$	��Top=��� $��4.Range options:��
�������$��ONE DAY)�$��36(�$��474.246,386.105,360.493,0q�$��63.07��$	��Top=��� $��5.Additional options:
�����	#F8FFFFFF$��ONE DAY)�$��24(�$ ��976.738,433.105,-190.049,0q�$��49.037��$	��Top=��� $��selection summary:
�����	#F8FFFFFF$��ONE DAY)�$��36(�$ ��976.738,131.254,-173.732,0q�$��55.44��$	��Top=��� -    ��Name$ searchButton��$��search��$!��1062.441,308.192,-100.265,0q�
����������	#0030278D
�������$��ONE DAY)�$��20(�$
��Left=�$��199.077��$��54.252��$	��Top=��� -   $ 
loadButton��$��load from cloud��$��981.374,508.642,-55.189,0q�
����������	#000097FF
�������$��ONE DAY)�$��14(�$
��Left=�$��235.068��$��32��$	��Top=��� -   $ 
saveButton��$��save to cloud��$��981.374,471.642,-55.189,0q�
����������	#000097FF
�������$��ONE DAY)�$��14(�$
��Left=�$��235.068��$��32��$	��Top=��� -   $ resetButton��$��reset selection��$��981.374,545.642,-55.189,0q�
����������	#000097FF
�������$��ONE DAY)�$��14(�$
��Left=�$��235.068��$��32��$	��Top=��� 
�������$��2��$��0,102.93,0,0q�
�������$	��Top=��� -   $ resetButton_Copy��$��random values��$��981.374,582.642,-55.189,0q�
����������	#000097FF
�������$��ONE DAY)�$��14(�$
��Left=�$��235.068��$��32��$	��Top=��� -    ��Name$ foodBox��$
��Left=�$��201.241��$��53.656,180.625,0,0q�$	��Top=�$��341.579��$ 0.5,0.5&�$��Cabana)����	#00FF0000z�V� .~��� �� �� $ 0.478Q�T� %  MahApps.Metro.Controls.FlipView  -     Name$ transportBox��$
��Left=�$��205.309��$��50.741,439.691,0,0q�$	��Top=�$��346.832�����	#00000000$��ONE DAY)�$��6(�$ 0.5,0.5&��� -	   	 ��Name$	 slider��$
��Left=�$��588.79,477.282,0,0q�$	��Top=�$��83.495�����	#000D2D44
�������
 � Maximum$
 10Q� � SmallChange$ 1Q� � Value$ 5Q�$ 0.5,0.5&�$��21.583��z�V� .~���  �� ScaleX$ 3Q� �� ScaleY$ 3Q��� �� T� �� -
    ��Name$ distanceLabel��$��distance: 5km��$
��Left=�$��544.199,540.892,0,0q�$	��Top=�$��ONE DAY)�$��24(�
��������� -   $
 food��$��{select food type}��$
��Left=�$!��1078.878,179.596,-109.425,0q�$	��Top=�$��ONE DAY)�$��20(�
�������$
��38.8��� $��0��$
��Left=�$	��100��$��1035.892,10,-169.139,0q�$	��Top=�$��294.5�����	#00DA7B7B.+��� $��User:
��$
��Left=�$	��Top=�$��ONE DAY)�$��20(�
�������$��-24.919,0,0,0q��� -   $ signOut��$��sign out��$��Center=�$��-24.919,57.5,253.183,0q�$	��Top=�
�������
�������$��ONE DAY)�$��12(�$��Center=�$	��Top=�$
��20.5��$��66.236�����	#000097FF�� -    ��Name$ 	userPhoto��$
��Left=�$
��75.5��$��-117.048,7,0,0q�$	��Top=�$
��75.5��$<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��$��UniformToFill=��� -   $ usernameLabel��$��Label��$
��Left=�$	��Top=�$��10,27.5,0,0q�$��ONE DAY)�$��20(�
��������� $��3.Your location:
�����	#F8FFFFFF$��ONE DAY)�$��36(�$��474.246,131.254,0,0q�$��64.57��$	��Top=�$
��Left=�$��288.065���� -    ��Name$ CityBox��$
��Left=�$��40.058��$��492.107,219.011,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��278.919��
������� �� SelectionBrush �	#FF1700FF$��24(�$��ONE DAY)�
������ �� -   $ 	StreetBox��$
��Left=�$��40.058��$��492.107,299.748,0,0q�$
 Wrap=�$	��Top=�$��278.919��
������� �	#FF1700FF$��24(�$��ONE DAY)�
������ �� $��City:
��
�������$��ONE DAY)�$��22(�$��492.107,184.84,596.374,0q�$��34.171��$	��Top=�$ 0.359,0.762&��� $��Street:
��
�������$��ONE DAY)�$��22(�$��492.107,264.069,0,0q�$��39.752��$	��Top=�$
��Left=�$��219.726���� $��I will eat
��$
��Left=�$��976.738,179.596,0,0q�$	��Top=�$��ONE DAY)�$��20(�$
��38.8�����	#FFACACAC�� $	��in
��$
��Left=�$��976.738,205.292,0,0q�$	��Top=�$��ONE DAY)�$��20(�$
��38.8��$ 
2.995,0.18&����	#FFACACAC�� -   $
 city��$��{fill in city}��$
��Left=�$��1007.398,205.292,0,0q�$	��Top=�$��ONE DAY)�$��20(�
�������$
��38.8���� $��By��$
��Left=�$��976.738,269.392,0,0q�$	��Top=�$��ONE DAY)�$��20(�$
��38.8��$ 
0.386,0.21&����	#FFACACAC�� -   $
 type��$��{select transport type}��$
��Left=�$!��1007.398,269.392,-100.265,0q�$	��Top=�$��ONE DAY)�$��20(�
�������$
��38.8���� -   $ distance��$	��5KM��$
��Left=�$��1103.813,234.092,0,0q�$	��Top=�$��ONE DAY)�$��20(�
�������$
��38.8��$ 1.713,0.086&��� $��by radius of:
��$
��Left=�$��976.738,234.092,0,0q�$	��Top=�$��ONE DAY)�$��20(�$
��38.8�����	#FFACACAC�� $�� ��$
��Left=�$��122.729,606.142,0,0q�$	��Top=�$��Cabana)�$��24(�$
��38.8��  $	��100��$��0,595,0.253,-50q�$	��Top=�
���  �� �	#FF1700FF