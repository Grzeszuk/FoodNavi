   M S B A M L   `   `   `  ����O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FoodNavigator___View.Settings_Window$FoodNavigator___View.Settings_Window  5   	   3    -FoodNavigator___View.Settings_Window.Settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:FoodNavigator___View.Settings_Window     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  Settings��5	   	   $��521.09��6   $��757.305��6*   .��5
      �  � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��186* �6   ��5   
   �� 5       �� ImageSource$B </FoodNavigator - View;component/Welcome Page/background2.jpg��6   .+�5   
   �� ���	#4C000000
���   �$��2��64   !  MahApps.Metro.Controls.Glow  5   
   $	��100��6   $��0,285,0.305,-12.91q�6%   $	��Top=�6A   
���  ��   	GlowBrush �	#FF1700FF$��1��6�     5   
   $	��100��6   $��0,1,0.305,0q�6%   $	��Top=�6:   
���  �� �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�6y   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 -180Q�6&   T� 5      5      5       � 5"   
   $��0��6   $
��Left=�6   $	��100��6:   $��571.734,0,-116.929,0q�6G   $	��Top=�6e   $��294.5��6}   ���	#00DA7B7B.+�5#      �� $��User:
��6   $
��Left=�6)   $	��Top=�6D   $��ONE DAY)�6\   $��20(�6q   
�������$��-24.919,0,0,0q�6�   �� 5$      -   5         ��Name$ signOut��5$      $��sign out��6&   $��Center=�69   $��-24.919,57.5,253.183,0q�6V   $	��Top=�6v   
�������
�������$��ONE DAY)�6�   $��12(�6�   $��Center=�6�   $	��Top=�6�   $
��20.5��6  $��66.236��6)  ���	#000097FF6O  �� 5%      -   5         ��Name$ 	userPhoto��5%      $
��Left=�6'   $
��75.5��6B   $��-117.048,7,0,0q�6P   $	��Top=�6h   $
��75.5��6�   $<��6/FoodNavigator - View;component/Welcome Page/back2.jpg��6�   $��UniformToFill=�6�   �� 5&      -   5         ��Name$ usernameLabel��5&      $��Label��6+   $
��Left=�6;   $	��Top=�6V   $��10,27.5,0,0q�6n   $��ONE DAY)�6�   $��20(�6�   
�������6�   5'      �� 5(   
   $��account settings:��6   $
��Left=�6,   $��0,10,0,0q�6G   $	��Top=�6Y   $��ONE DAY)�6q   $��48(�6�   �� 5)   
   $��password changing:��6   $
��Left=�6-   $��10,112.488,0,0q�6H   $	��Top=�6`   $��ONE DAY)�6x   $��36(�6�   $��2��6�   �� 5*   
   $��photo changing:��6   $
��Left=�6*   $��10,216.935,0,0q�6E   $	��Top=�6]   $��ONE DAY)�6u   $��36(�6�   $��1��6�   �� 5+   
   -   5        $ 
passButton��5+      $��change password��6%   $
��Left=�6?   $��25.506,160.325,0,0q�6Z   $	��Top=�6v   $��252.568��6�   ���	#00000000
�������$��ONE DAY)�6�   $��Normal"�6�   $��40.818��6  $��1��6  �� 5,   
   -   5        $ 	picButton��5,      $��change photo��6$   $
��Left=�6;   $��25.506,313.753,0,0q�6V   $	��Top=�6r   $��252.568��6�   ���	#00000000
�������$��ONE DAY)�6�   $��Normal"�6�   $��40.818��6  $��1��6  �� 5-   
   -   5        	 ��Name$	 picBox��5-      $
��Left=�6"   $��40.818��6=   $��25.506,267.935,0,0q�6M   
 �� TextWrapping$

 Wrap=�6i   $	��Top=�6}   $��252.568��6�   ���	#00252525$��Verdana)�6�   $��24(�6�   $��1��6   G� 5.   
   -   5         G�Name$ passBox��5.      $
��Left=�6'   $��25.506,45.488,0,0q�6B   $	��Top=�6]   $��252.568��6u   ���	#00252525
�������$ -1.669,-3.624&�6�   $��40.818��6�   $��24(�6�   $��1��6  G� 5/   
   -   5        $ passConfrimBox��5/      $
��Left=�6.   $��25.506,102.289,0,0q�6I   $	��Top=�6e   $��252.568��6}   ���	#00252525
�������$��40.818��6�   $��24(�6�   $��1��6  �� 50   
   -	   5        $ PasswordLabel2��50      $��<- enter password
��6(   $
��Left=�6L   $��283.216,45.488,0,0q�6g   $	��Top=�6�   
�������$��ONE DAY)�6�   $��16(�6�   $��49.215��6�   $��155.717��6�   $��1��6�   �� 51   
   -
   5        $ PasswordLabel��51      $��<- Renter password
��6'   $
��Left=�6L   $��283.216,117.464,0,0q�6g   $	��Top=�6�   
�������$��ONE DAY)�6�   $��16(�6�   $��49.215��6�   $��163.209��6�   $��1��6�   �� 52   
   -   5        $ PasswordCheck��52      $��<-Password must contain:
��6'   $
��Left=�6R   $��448.968,44.895,0,0q�6m   $	��Top=�6�   
�������$��ONE DAY)�6�   $��247.032��6�   $��18(�6�   $��49.808��6�   $��1��6�   �� 53   
   -   5        $ 	BigLetter��53      $��- at least one big letter��6#   $
��Left=�6G   $��462.421,101.453,0,0q�6b   $	��Top=�6   
�������$��ONE DAY)�6�   $��255.285��6�   $��16(�6�   $��1��6�   �� 54   
   -   5        $ Number��54      $��- at least one number��6    $
��Left=�6@   $��462.423,152.575,0,0q�6[   $	��Top=�6x   
�������$��ONE DAY)�6�   $��255.285��6�   $��16(�6�   $��1��6�   �� 55   
   -   5        $ Special��55      $!��- at least one special char��6!   $
��Left=�6G   $��462.421,183.575,-5.081,0q�6b   $	��Top=�6�   
�������$��ONE DAY)�6�   $��16(�6�   $��291.965��6�   $��1��6�   �� 56   
   -   5        $ SmallLetter��56      $!��- at least one small letter��6%   $
��Left=�6K   $��462.421,126.575,0,0q�6f   $	��Top=�6�   
�������$��ONE DAY)�6�   $��255.285��6�   $��16(�6�   $��1��6�   �� 57   
   -   5        $ count��57      $��- at least 8 characters��6   $
��Left=�6A   $��462.423,75.703,0,0q�6\   $	��Top=�6x   
�������$��ONE DAY)�6�   $��255.285��6�   $��16(�6�   $��1��6�   �� 58   
   -   5        $ 
PhotoLabel��58      $��<- Photo url ��6$   $
��Left=�6?   $��283.216,267.935,0,0q�6Z   $	��Top=�6w   
�������$��ONE DAY)�6�   $��16(�6�   $��49.215��6�   $��181.568��6�   $��1��6�   F� 59   
   ���Е��� ��ш'�. ��	���	#FFF4F4F5$��1��6E   $��0,88,0,0q�6P    �� Stretch$
 Fill=�6b   
�������$	��Top=�6�   5;      5<      