   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:FoodNavigator___View.Welcome_page!FoodNavigator___View.Welcome_page  3    -FoodNavigator___View.Welcome_page.WelcomePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Alocal/clr-namespace:FoodNavigator___View.Welcome_page     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls    N� Title$  WelcomePage��$��844.573��$��1520.681��.��� -   ����  �� ImageSource$ background2.jpg�� j� Stretch$ UniformToFill=� � RowDefinitions �� $
��111* ��� $
��298* �.+�!  MahApps.Metro.Controls.Glow  $	��100��$��0,-2,0,0q�$	��Top=�
���  ��   	GlowBrush �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$
 -180Q�T� �� 
���   �$��2��$��0,0,0,41.34q����	#7F000000�� -    ��Name$ usernameBox��$��47.824��$��73.067,115.912,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$��24(�
�������
������ $
��Left=�$��333.863��	 J� Opacity$		 0.8Q�
�������
 �� SelectionBrush
 �	#FF1700FF$��ONE DAY)� �� 
CaretBrush
 �����*  $MahApps.Metro.Controls.TextBoxHelper   UseFloatingWatermark .    	Watermark$ username���� -    ��Name$ 
textBlock1��$��73.067,28.408,1098.168,0q�$
��Wrap=�$��login:��$	��Top=����	#FFFFECEC$��ONE DAY)�$��80(�$��87.504�����	#00000000$��1���� -    ��Name$ loginButton��$��	let's eat��$��73.067,232.361,0,0q�$��1��$��ONE DAY)����	#00000000
�������$
��Left=�$��237.927��$��56.991��$	��Top=�
�������$��24(�$��Normal"��� -   $ 
textBlock2��$��Center=�$%��1049.609,28.408,166.338,499.297q�$
��Wrap=�$��Center=�
�������$��ONE DAY)�$��87.656��$��304.734��$��20(�$��1�����	#008B8B8B�� $� ���� $�Don't have an account? ���� �� $� ���� $�It's easy do have one���� �� $� ���� $�click button���� $� ���� $�below���� �� �� �� -   $ 
makeButton��$��SIGN UP��$��1049.609,102.663,0,0q�$��1��$��ONE DAY)����	#00000000
�������$��56.991��$	��Top=�$
��Left=�$��237.927��
�������$��24(�$��Normal"�G� -    G�Name$ passwordBox��$��73.067,172.788,0,0q�$��1��$	��Top=�$��47.825��$��24(�$
��Left=�$��333.863��$		 0.8Q�
�������
������ 
������� G� SelectionBrush �	#FF1700FF$��ONE DAY)� G� 
CaretBrush
 ����� . $ password���� -    ��Name$ passwordLabel��$��<- Enter password��$
��Left=�$��411.93,172.784,0,0q�$��1��$	��Top=����	#00000000
�������$��ONE DAY)�$��22(��� -	   $ 	nameLabel��$��<- Enter username��$
��Left=�$��411.93,115.908,0,0q�$��1��$	��Top=����	#00000000
�������$��ONE DAY)�$��22(��� -
   $ 
loginLabel��$��	<- Log in��$
��Left=�$��315.993,232.361,0,0q�$��1�����	#00000000
�������$��ONE DAY)�$��53.162��$	��Top=�$��22(�
���   ��� $
��Left=�$��297.777��$��10,0,0,0q�$	��Top=�$��739.328��$��foodnavilogo.png��$��2���� $
��Left=�$��193.992��$��1099.752,380.029,0,0q�$��1��$	��Top=�$��247.923��$��twonoobslogo.png���� -   $ textBlock2_Copy��$��Center=�$%��1049.609,179.535,132.492,348.17q�$
��Wrap=�$��Center=�
�������$��ONE DAY)�$��87.656��$��338.58��$��20(�$��1�����	#008B8B8B�� $�Forgot password?���� �� $�Click button below���� �� $�You are welcome���� �� �� �� -   $ passwordRecorvery��$��help me��$��1049.609,251.856,0,0q�$��1��$��ONE DAY)����	#00000000
�������$��56.991��$	��Top=�$
��Left=�$��237.927��
�������$��24(�$��Normal"�  $	��100��$��0,366.788,-0.319,0q�$��1��$	��Top=�
���  �� �	#FF1700FF�� $��Release Canditate 1.7.3��$
��Left=�$	��Top=�$��23.818,408.457,0,0q�$��1��$��ONE DAY)�$��14(�$��460.339��$��32.002���� -   $ connectionLabel��$*��$connected to TwoNoobs Azure Cloud™��$
��Left=�$	��Top=�$��195.956,408.456,0,0q�$��ONE DAY)�$��14(�$��553.372��$��1��