   M S B A M L   `   `   `  ����O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FoodNavigator___View.Result_page FoodNavigator___View.Result_page  5      c _GMap.NET.WindowsPresentation, Version=1.7.5.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation 5      1    +FoodNavigator___View.Result_page.ResultPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:FoodNavigator___View.Result_page     5      pWindowsPresentationPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation     5      U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  6t     N� Title$  
ResultPage��5
      .��5      � $��0,0,-1067.102,-369.04q�6   ��5   
   �� 5       �� ImageSource$A ;/FoodNavigator - View;component/Search Page/background3.jpg��6    j� Stretch$ UniformToFill=�6c   .+�5   
   !  MahApps.Metro.Controls.Glow  $	��100��6   $��0,-3,0,0q�6#   $	��Top=�65   
���  ��   	GlowBrush �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 -180Q�6&   T� 5      5      5        5   
   $	��100��6   $��0,608,0.102,-38.96q�6#   $	��Top=�6?   
���  �� �	#FF1700FF6h   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��348.069,45.434,0,0q�6B   $
��Wrap=�6^   $	��Top=�6r   $��ONE DAY)�6�   $��36(�6�   
�������$��Restaurant Map:��6�   �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��10,45.434,0,0q�6G   $
��Wrap=�6^   $	��Top=�6r   $��ONE DAY)�6�   $��36(�6�   
�������$��Restaurant List:��6�   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $��549.106��6>   $��10,109.934,0,0q�6O   $	��Top=�6g   $��323.43��6   
������ 
�������
�������$��Cabana)�6�   $��36(�6�   6  �� 5    
   -   5         ��Name$ slider��5       $
��Left=�6!   $!��1304.446,109.934,-429.783,0q�6<   $	��Top=�6a   $	��100��6y   	 �� Orientation$	 Vertical=�6�   $��463.419��6�   
 � Maximum$
 18Q�6�    � Minimum$ 12Q�6�    � SmallChange$ 1Q�6�   6�   �� 5!   
   -   5        $ 	zoomLabel��5!      $
��Left=�6'   $��1235.273,598.747,0,0q�6B   $
��Wrap=�6`   $	��Top=�6t   
�������$��	Zoom : 1x��6�   $��ONE DAY)�6�   $��22(�6�   $ -1.715,5.01&�6�   �� 5"   
   -   5         ��Name$ returnButton��5"      $��return to search options��6'   $
��Left=�6J   $��348.069,625.747,0,0q�6e   $	��Top=�6�   $��226.068��6�   $��33.293��6�   
�������
����������	#000097FF$��ONE DAY)�6�   $��12(�6  6  � 5#   
   $
��Left=�6   $	��100��6*   $��445,422,0,0q�67   $	��Top=�6L   $	��100��6d   �� 5$   
   $0��*Green restaurant are open, red are closed.��6   $
��Left=�6E   $��345.868,81.934,0,0q�6`   $	��Top=�6|   $��ONE DAY)�6�   $��18(�6�   
�������6�   .  (GMap.NET.WindowsPresentation.GMapControl  5&   
   -   5          Name$ 	resultMap��5&   *   $
��Left=�6=   $��510.813��6X   $��348.069,109.934,0,0q�6i   $	��Top=�6�   $��882.204��6�   �� 5'   
   -   5        $ standardMap��5'      $��standard map��6&   $
��Left=�6=   $��579.137,625.747,0,0q�6X   $	��Top=�6u   $��104.333��6�   $��33.293��6�   
�������
����������	#3300FF2E$��ONE DAY)�6�   $��12(�6   6  �� 5(   
   -	   5        $ 	hybridMap��5(      $��
hybrid map��6$   $
��Left=�69   $��688.47,625.747,0,0q�6T   $	��Top=�6p   $��104.333��6�   $��33.293��6�   
�������
����������	#33FF0000$��ONE DAY)�6�   $��12(�6�   6	  �� 5)   
   -
   5        $ satelliteMap��5)      $��satellite map��6'   $
��Left=�6?   $��797.803,625.747,0,0q�6Z   $	��Top=�6w   $��104.333��6�   $��33.293��6�   
�������
����������	#33FF0000$��ONE DAY)�6�   $��12(�6  6  � 5*   
   $��0��6   $
��Left=�6   $	��100��6:   $��1119.99,0,-47.388,0q�6G   $	��Top=�6d   $��294.5��6|   ���	#00DA7B7B.+�5+      �� $��User:
��6   $
��Left=�6)   $	��Top=�6D   $��ONE DAY)�6\   $��20(�6q   
�������$��-24.919,0,0,0q�6�   �� 5,      -   5        $ signOut��5,      $��sign out��6&   $��Center=�69   $��-24.919,57.5,253.183,0q�6V   $	��Top=�6v   
�������
�������$��ONE DAY)�6�   $��12(�6�   $��Center=�6�   $	��Top=�6�   $
��20.5��6  $��66.236��6)  ���	#000097FF6O  �� 5-      -   5         ��Name$ 	userPhoto��5-      $
��Left=�6'   $
��75.5��6B   $��-117.048,7,0,0q�6P   $	��Top=�6h   $
��75.5��6�   $<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��6�   $��UniformToFill=�6�   �� 5.      -   5         ��Name$ usernameLabel��5.      $��Label��6+   $
��Left=�6;   $	��Top=�6V   $��10,27.5,0,0q�6n   $��ONE DAY)�6�   $��20(�6�   
�������6�   5/      51      52      