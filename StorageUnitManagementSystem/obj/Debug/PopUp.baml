   M S B A M L   `   `   `  ����  StorageUnitManagementSystem'    !StorageUnitManagementSystem.PopUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9custom,http://metro.mahapps.com/winfx/xaml/controls  5        � Title$  PopUp��5	      $	��500��6   $	��400��6     � WindowStartupLocation$ CenterScreen=�6-      AccentBaseColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6R   $��2q�5
         ShowMaxRestoreButton .     RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��About Us��6   5       � 	Resources 5        MetroTabItem �� BasedOn �� 
TargetType+  %MahApps.Metro.Controls.ControlsHelper �� Property	 �� Value��%o   '��       7  �� 5   
   8   " ��68   .�5      ��  �@ HeaderFontSize$	 20Q�6E   6R   5      5      .��5      � $	��400��6   .+�5   
   �� $��Update Details��6   $
��Bold"�6)   $��18(�6;   $��Center=�6I   $	��Top=�6f   $��0,0,0,50q�6~   6�   �� 5   
   $��LeaseID:��6   $��25��6#   $��10,0,0,402.4q�6/   $
��Left=�6E   $��80��6`   $��Bottom=�6k   �� 5   
   -   5        
 ��Name$
 LeaseIDTxtBox��5      $��20��6)   $��105,39,0,401.4q�65   $	��154��6M   $
��Left=�6Y   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ LeaseID��6t   �� 5   
   $��
Client ID:��6   $��25��6%   $��10,80,299,361.4q�61   �� 5   
   -   5        $
 ClientIDTxtBox��5      $	��154��6*   $��20��66   $
��Left=�6B   $��105,79,0,361.4q�6]   $ ClientID��6u   �� 5   
   $��Name:��6   $��25��6    $��10,124,299,317.4q�6,   �� 5    
   -   5        $
 LeaseNameTxtBox��5       $	��154��6+   $��20��67   $
��Left=�6C   $��105,125,0,315.4q�6^   $ Only Letters��6w   �� 5!   
   $��Surname:��6   $��25��6#   $��10,170,299,271.4q�6/   �� 5"   
   -   5        $
 LeaseSurnameTxtBox��5"      $��20��6.   $��105,169,0,271.4q�6:   $
��Left=�6S   $	��154��6n   $ Only Letters��6z   �� 5#   
   $��Amount Owed:��6   $��25��6'   $��10,210,290,231.4q�63   �� 5$   
   -   5        $
 LeaseOwedTxtBox��5$      $	��154��6+   $��20��67   $
��Left=�6C   $��105,209,0,231.4q�6^   $ R��6�   �� 5%   
   $��Amount Paid:��6   $��25��6'   $��10,256,299,185.4q�63   �� 5&   
   -   5        $
 LeasePaidTxtBox��5&      $	��154��6+   $��20��67   $
��Left=�6C   $��105,255,0,185.4q�6^   $ R��6�   �� 5'   
   $��
Date Paid:��6   $��25��6%   $��10,297,313,144.4q�61   �� 5(   
   $��Months Paid:��6   $��25��6'   $��10,344,299,97.4q�63   �� 5)   
   -   5        $
 MonthspaidTxtBox��5)      $	��154��6,   $��20��68   $
��Left=�6D   $��105,343,0,97.4q�6_   $ Only Numbers��6w   �� 5*   
   -   5         ��Name$ 	UpdateBtn��5*      $��Update��6$   $	��100��65   $��30��6A   $��51,400,249,36.4q�6M     AccentedSquareButtonStyle#��[ 6f   #���   6�   $��1q�6�      ContentCharacterCasing$ Normal=�6�   6  �� 5+   
   -	   5        $ 	Terminate��5+      $��	Terminate��6$   $	��100��68   $��30��6D   $��211,400,89,36.4q�6P     btnStyleRed#��[ 6i   $��0q�6�   $ Normal=�6�   6�   (  "System.Windows.Controls.DatePicker  5,   
   -
   5          Name$ LeaseDateTxtBox��5,      $
��Left=�6.   $��105,297,0,0q�6I   $	��Top=�6^   $	��154��6v   5-      5.      