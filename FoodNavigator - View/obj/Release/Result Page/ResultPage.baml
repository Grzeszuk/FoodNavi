   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FoodNavigator___View.Result_page FoodNavigator___View.Result_page  c _GMap.NET.WindowsPresentation, Version=1.7.5.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation 1    +FoodNavigator___View.Result_page.ResultPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:FoodNavigator___View.Result_page     pWindowsPresentationPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls    N� Title$  
ResultPage��.��� $��0,0,-1067.102,-369.04q�����  �� ImageSource$A ;/FoodNavigator - View;component/Search Page/background3.jpg�� j� Stretch$ UniformToFill=�.+�!  MahApps.Metro.Controls.Glow  $	��100��$��0,-3,0,0q�$	��Top=�
���  ��   	GlowBrush �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$
 -180Q�T�   $	��100��$��0,608,0.102,-38.96q�$	��Top=�
���  �� �	#FF1700FF�� -    ��Name$ 	textBlock��$
��Left=�$��348.069,45.434,0,0q�$
��Wrap=�$	��Top=�$��ONE DAY)�$��36(�
�������$��Restaurant Map:���� -   $ textBlock_Copy��$
��Left=�$��10,45.434,0,0q�$
��Wrap=�$	��Top=�$��ONE DAY)�$��36(�
�������$��Restaurant List:���� -    ��Name$ listBox��$
��Left=�$��549.106��$��10,109.934,0,0q�$	��Top=�$��323.43��
������ 
�������
�������$��Cabana)�$��36(��� -    ��Name$ slider��$
��Left=�$!��1304.446,109.934,-429.783,0q�$	��Top=�$	��100��	 �� Orientation$	 Vertical=�$��463.419��
 � Maximum$
 18Q� � Minimum$ 12Q� � SmallChange$ 1Q��� -   $ 	zoomLabel��$
��Left=�$��1235.273,598.747,0,0q�$
��Wrap=�$	��Top=�
�������$��	Zoom : 1x��$��ONE DAY)�$��22(�$ -1.715,5.01&��� -    ��Name$ returnButton��$��return to search options��$
��Left=�$��348.069,625.747,0,0q�$	��Top=�$��226.068��$��33.293��
�������
����������	#000097FF$��ONE DAY)�$��12(�� $
��Left=�$	��100��$��445,422,0,0q�$	��Top=�$	��100���� $0��*Green restaurant are open, red are closed.��$
��Left=�$��345.868,81.934,0,0q�$	��Top=�$��ONE DAY)�$��18(�
�������.  (GMap.NET.WindowsPresentation.GMapControl  -     Name$ 	resultMap��$
��Left=�$��510.813��$��348.069,109.934,0,0q�$	��Top=�$��882.204���� -   $ standardMap��$��standard map��$
��Left=�$��579.137,625.747,0,0q�$	��Top=�$��104.333��$��33.293��
�������
����������	#3300FF2E$��ONE DAY)�$��12(��� -	   $ 	hybridMap��$��
hybrid map��$
��Left=�$��688.47,625.747,0,0q�$	��Top=�$��104.333��$��33.293��
�������
����������	#33FF0000$��ONE DAY)�$��12(��� -
   $ satelliteMap��$��satellite map��$
��Left=�$��797.803,625.747,0,0q�$	��Top=�$��104.333��$��33.293��
�������
����������	#33FF0000$��ONE DAY)�$��12(�� $��0��$
��Left=�$	��100��$��1119.99,0,-47.388,0q�$	��Top=�$��294.5�����	#00DA7B7B.+��� $��User:
��$
��Left=�$	��Top=�$��ONE DAY)�$��20(�
�������$��-24.919,0,0,0q��� -   $ signOut��$��sign out��$��Center=�$��-24.919,57.5,253.183,0q�$	��Top=�
�������
�������$��ONE DAY)�$��12(�$��Center=�$	��Top=�$
��20.5��$��66.236�����	#000097FF�� -    ��Name$ 	userPhoto��$
��Left=�$
��75.5��$��-117.048,7,0,0q�$	��Top=�$
��75.5��$<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��$��UniformToFill=��� -    ��Name$ usernameLabel��$��Label��$
��Left=�$	��Top=�$��10,27.5,0,0q�$��ONE DAY)�$��20(�
�������