   M S B A M L   `   `   `  ���� C  ?Gas Laws, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Gas_Laws.PagesGas_Laws.Pages  9!clr-namespace:Gas_Laws.ViewModelsGas_Laws.ViewModels  "    Gas_Laws.Pages.About_Program   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Gas_Laws.Pages     8
viewmodels!clr-namespace:Gas_Laws.ViewModels       � Icon$  ../Icons/book.png�� � Title$ About the Program��$	��380��$	��420�� � WindowStyle$
 None=�
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=� � DataContext �� *MainViewModel+   ViewModelLocator �� Source# [  .���� 
���   �$��1q�._��  � RowDefinitions �� $��6* ��� $	��59* �.+�� -   $��Header��$��0��$��Center=�$��40�����#3a032d.+��� $��Right=�$��RightToLeft=� �� Orientation$ 
Horizontal=�.+��� -     HeaderImage#��[ 	 � 	Resources	   Img  Img2��%Q   &	       &	      ��../Icons/Cross_Na.png����../Icons/Cross_A.png���� -   #��[ 	 ��%M   &	       &	      ��../Icons/min_Na.png����../Icons/min_A.png��� $��1��.+��� $ Vertical=����#FFFFFF.+��� $��Gas Laws��  Logo#��[ 
���   �$��25(�$��Center=�$��0,0,0,0q�$��0,8,0,0q��� $��ver. 2-0��$/��)Output Sans, Helvetica, Arial, sans-serif)�
�������$��16(�$��Center=�$��0,8,0,0q��� $
��Wrap=�$����Данная программа предназначена для работы с газовыми законами. Здесь вы можете ввести первоначальные параметры и проследить динамику их изменения.��$2��,Output Ssatans, Helvetica, Arial, sans-serif)�
���   �$��16(�$
��Left=�$��
50,55,50,0q�$	��316���� $��	50,45,0,0q�$ 
Horizontal=�.+��� $��NoWrap=�$��50��$��Email:��
���   �$��16(�$
��Left=��� $��NoWrap=�$&�� nikita_shapovalov_ivt221@mail.ru��$��SemiBold"�
���   �$��16(�$
��Left=�$��10,0,0,0q��� $��	50,15,0,8q�$ 
Horizontal=�.+��� $��NoWrap=�$��50��$
��Git:��
���   �$��16(�$
��Left=��� $��NoWrap=�$��Github.com/ShapikNya��$��SemiBold"�
���   �$��16(�$
��Left=�$��10,0,0,0q�