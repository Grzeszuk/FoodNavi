   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FoodNavigator___View.Settings_Window$FoodNavigator___View.Settings_Window  3    -FoodNavigator___View.Settings_Window.Settings   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:FoodNavigator___View.Settings_Window     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$  Settings��$��521.09��$��757.305��.���  � RowDefinitions �� $	��59* ��� $
��186* �����  �� ImageSource$B </FoodNavigator - View;component/Welcome Page/background2.jpg��.+��� ���	#4C000000
���   �$��2��!  MahApps.Metro.Controls.Glow  $	��100��$��0,285,0.305,-12.91q�$	��Top=�
���  ��   	GlowBrush �	#FF1700FF$��1��  $	��100��$��0,1,0.305,0q�$	��Top=�
���  �� �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$
 -180Q�T� � $��0��$
��Left=�$	��100��$��571.734,0,-116.929,0q�$	��Top=�$��294.5�����	#00DA7B7B.+��� $��User:
��$
��Left=�$	��Top=�$��ONE DAY)�$��20(�
�������$��-24.919,0,0,0q��� -    ��Name$ signOut��$��sign out��$��Center=�$��-24.919,57.5,253.183,0q�$	��Top=�
�������
�������$��ONE DAY)�$��12(�$��Center=�$	��Top=�$
��20.5��$��66.236�����	#000097FF�� -    ��Name$ 	userPhoto��$
��Left=�$
��75.5��$��-117.048,7,0,0q�$	��Top=�$
��75.5��$<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��$��UniformToFill=��� -    ��Name$ usernameLabel��$��Label��$
��Left=�$	��Top=�$��10,27.5,0,0q�$��ONE DAY)�$��20(�
��������� $��account settings:��$
��Left=�$��0,10,0,0q�$	��Top=�$��ONE DAY)�$��48(��� $��password changing:��$
��Left=�$��10,112.488,0,0q�$	��Top=�$��ONE DAY)�$��36(�$��2���� $��photo changing:��$
��Left=�$��10,216.935,0,0q�$	��Top=�$��ONE DAY)�$��36(�$��1���� -   $ 
passButton��$��change password��$
��Left=�$��25.506,160.325,0,0q�$	��Top=�$��252.568�����	#00000000
�������$��ONE DAY)�$��Normal"�$��40.818��$��1���� -   $ 	picButton��$��change photo��$
��Left=�$��25.506,313.753,0,0q�$	��Top=�$��252.568�����	#00000000
�������$��ONE DAY)�$��Normal"�$��40.818��$��1���� -   	 ��Name$	 picBox��$
��Left=�$��40.818��$��25.506,267.935,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$��252.568�����	#00252525$��Verdana)�$��24(�$��1��G� -    G�Name$ passBox��$
��Left=�$��25.506,45.488,0,0q�$	��Top=�$��252.568�����	#00252525
�������$ -1.669,-3.624&�$��40.818��$��24(�$��1��G� -   $ passConfrimBox��$
��Left=�$��25.506,102.289,0,0q�$	��Top=�$��252.568�����	#00252525
�������$��40.818��$��24(�$��1���� -	   $ PasswordLabel2��$��<- enter password
��$
��Left=�$��283.216,45.488,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��155.717��$��1���� -
   $ PasswordLabel��$��<- Renter password
��$
��Left=�$��283.216,117.464,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��163.209��$��1���� -   $ PasswordCheck��$��<-Password must contain:
��$
��Left=�$��448.968,44.895,0,0q�$	��Top=�
�������$��ONE DAY)�$��247.032��$��18(�$��49.808��$��1���� -   $ 	BigLetter��$��- at least one big letter��$
��Left=�$��462.421,101.453,0,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��16(�$��1���� -   $ Number��$��- at least one number��$
��Left=�$��462.423,152.575,0,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��16(�$��1���� -   $ Special��$!��- at least one special char��$
��Left=�$��462.421,183.575,-5.081,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��291.965��$��1���� -   $ SmallLetter��$!��- at least one small letter��$
��Left=�$��462.421,126.575,0,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��16(�$��1���� -   $ count��$��- at least 8 characters��$
��Left=�$��462.423,75.703,0,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��16(�$��1���� -   $ 
PhotoLabel��$��<- Photo url ��$
��Left=�$��283.216,267.935,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��181.568��$��1��F� ���Е��� ��ш'�. ��	���	#FFF4F4F5$��1��$��0,88,0,0q� �� Stretch$
 Fill=�
�������$	��Top=�