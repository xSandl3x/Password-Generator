   M S B A M L   `   `   `  ����L  HPasswordGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PasswordGeneratorPasswordGenerator  5   	   "    PasswordGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PasswordGenerator     5   	     � Title$  Password generator��5   	   $	��450��6$   $	��800��61   .��5	      � -   5         �Name$
 grid��5	      .+�5
   
   �� $��Password generator��6   $��Center=�6-   $��0,40,0,0q�6J   $��20(�6\   $��DemiBold"�6j   $	��Top=�6�   �� 5   
   $,��&Generate a complex and secure password��6   $��Center=�6A   $��0,80,0,0q�6^   $��15(�6p   $	��Top=�6~   �� 5   
   -   5         ��Name$ lengthMessage��5      $��Length: ��6'   $��Center=�6:   $��	0,210,0,0q�6W   $��15(�6j   $	��Top=�6x   �� 5   
   -   5        $ actionMessage��5      $�� ��6'   $��Center=�62   $��	0,280,0,0q�6O   $��12(�6b   $	��Top=�6p   �� 5   
   -   5         ��Name$ 
resultLine��5      $��Center=�6&   $��25��6C   $��	0,120,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��260��6�   $��15(�6�   {�.  6�   �� 5   
   -   5         ��Name$ checkBox��5      $��Numbers��6%   $
��Left=�67   $��270,160,0,0q�6R   $	��Top=�6g   $��13(�6   �� 5   
   -   5        $ 	checkBox2��5      $��
Characters��6&   $��Center=�6;   $��	0,160,0,0q�6X   $	��Top=�6k   $��13(�6�   �� 5   
   -   5        $ 	checkBox3��5      $��Symbols��6&   $��Right=�68   $��0,160,270,0q�6T   $	��Top=�6i   $��13(�6�   �� 5   
   -   5        $��Center=�5      $��	0,240,0,0q�6.   $	��Top=�6A    � Minimum$ 4Q�6Y    � Maximum$ 32Q�6e   $	��230��6�   �� 5   
   -	   5        $��Generate��5      $
��Left=�6$   $��235,320,0,0q�6?   $	��Top=�6T   
�������$	��150��6�   $��35��6�   6�   �� 5   
   -
   5        $
��Copy��5      $��Right=�6    $��0,320,235,0q�6<   $	��Top=�6Q   
�������$	��150��6�   $��35��6�   6�   5      5      