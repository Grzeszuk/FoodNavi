   M S B A M L   `   `   `  ���� O  KFoodNavigator - View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FoodNavigator___View.Register_window$FoodNavigator___View.Register_window  9    3FoodNavigator___View.Register_window.RegisterWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:FoodNavigator___View.Register_window     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls     AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �    � Title$ RegisterWindow��$��630.208��$��636.458��.��� -   ����  �� ImageSource$A ;/FoodNavigator - View;component/Welcome Page/background.jpg�� j� Stretch$ UniformToFill=� � ColumnDefinitions �� $
��372* ��� �� $	��72* ��� $��4* ��� $
��119* ��� $	��61* �.+��� ���	#B2000000
���   �$��Right=�$��766.236��$��6��$��-30.457,0,-107.321,0q�!  MahApps.Metro.Controls.Glow  $	��100��$��-165,499,-572.542,0q�$	��Top=�
���  ��   	GlowBrush �	#FF1700FF J� RenderTransformOrigin$ 0.5,0.5&�$��6��  $	��100��$��-189,0,-548.542,0q�$	��Top=�
���  �� �	#FF1700FF$ 0.5,0.5&�$��6��z�V� .~��� �� ��  �� Angle$
 -180Q�T� �� -    ��Name$ label1��$��
register:
��$
��Left=�$��24.861,-59.482,0,0q�$	��Top=�
�������$��ONE DAY)�$��72(�$��159.778��$��325.907��G� -   	 G�Name$	 passwordBox��$
��Left=�$��24.861,190.036,0,0q�$	��Top=�$��190.609��$��43.168��$��ONE DAY)�$��24(�
������ 
�������
�������
 G� 
CaretBrush

 ����� G� SelectionBrush �	#7F3AFF00*  $MahApps.Metro.Controls.TextBoxHelper   UseFloatingWatermark .    	Watermark$ password���� -   $ 	UserLabel��$��<- enter username
��$
��Left=�$��210.757,115.98,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��48.758��$��163.78��$��3���� -   $ PasswordLabel2��$��<- enter password
��$
��Left=�$��216.135,183.989,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��160.752��$��3���� -    ��Name$ registerButton��$��register��$��24.861,510.129,70.412,0q�$	��Top=�$��75.533��
����������	#000097FF
�������$��ONE DAY)�$��24(�$��3���� -   $ PasswordLabel��$��<- Renter password
��$
��Left=�$��216.135,255.965,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��168.709��$��3���� -   $ 	MailLabel��$��<- Enter Email��$
��Left=�$��215.792,324.742,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��155.717���� -	    ��Name$ Check��$��I am not a robot��$
��Left=�$��114.426,465.325,0,0q�$	��Top=�$��18��$��86.372��
�������
�������$��ONE DAY)�$��6(�$ 0.5,0.5&����	#FFBBBBBBz�V� .~���  �� ScaleX$ 3Q� �� ScaleY$ 3Q��� �� T� G� -
   $	 confirmPassword��$
��Left=�$��24.861,263.18,0,0q�$	��Top=�
������ 
�������
�������$��ONE DAY)�$��24(�$��190.609��$��42��

 ����� �	#7F3AFF00$ confirm �� . �� -    ��Name$ emailBox��$
��Left=�$��42��$��24.861,331.957,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��190.609��
������ 
�������
�������$��ONE DAY)�$��24(� �� 
CaretBrush
 ����� �� SelectionBrush �	#7F3AFF00 . $ email���� -   $ PasswordCheck��$��<-Password must contain:
��$
��Left=�$��9.294,183.396,-0.547,0q�$	��Top=�
�������$��ONE DAY)�$��247.032��$��18(�$��49.808��$��4��$��2���� -   $ 	NameLabel��$��<- At least 5 characters��$
��Left=�$��6.314,115.98,0,0q�$	��Top=�
�������$��ONE DAY)�$��240.012��$��18(�$��49.808��$��4��$��2���� -   $ 	BigLetter��$��- at least one big letter��$
��Left=�$��21.514,233.204,-21.02,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��4��$��2��$��16(��� -   $ Number��$��- at least one number��$
��Left=�$��21.516,285.204,-21.022,0q�$	��Top=�
�������$��ONE DAY)�$��4��$��2��$��255.285��$��16(��� -   $ Special��$!��- at least one special char��$
��Left=�$��21.514,311.204,-57.7,0q�$	��Top=�
�������$��ONE DAY)�$��4��$��2��$��16(�$��291.965���� -   $ SmallLetter��$!��- at least one small letter��$
��Left=�$��21.516,259.204,-21.022,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��4��$��2��$��16(��� -   $ 
PhotoLabel��$��<- Photo url (optional)��$
��Left=�$��215.792,389.525,0,0q�$	��Top=�
�������$��ONE DAY)�$��16(�$��49.215��$��185.068��$��3���� -   $ photoURL��$
��Left=�$��42��$��24.861,396.74,0,0q�$
 Wrap=�$	��Top=�$��190.609��
������ 
�������
�������$��ONE DAY)�$��24(�
 ����� �	#7F3AFF00 . $ 	photo url���� -   $ usernameBox��$
��Left=�$��42��$��24.861,122.738,0,0q�$
 Wrap=�$	��Top=�$��190.609��
������ 
�������
�������$��ONE DAY)�$��24(�
 ����� �	#7F3AFF00 . $ username���� -   $ count��$��- at least 8 characters��$
��Left=�$��21.514,207.204,-21.02,0q�$	��Top=�
�������$��ONE DAY)�$��255.285��$��4��$��2��$��16(�