   M S B A M L   `   `   `  ���� C  ?Gas Laws, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Gas_Laws.PagesGas_Laws.Pages  9!clr-namespace:Gas_Laws.ViewModelsGas_Laws.ViewModels      Gas_Laws.Pages.Porshen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Gas_Laws.Pages     8
viewmodels!clr-namespace:Gas_Laws.ViewModels       � Icon$  ../Icons/book.png�� � Title$ Визуализатор��$	��380��$	��420�� � WindowStyle$
 None=�
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=� � DataContext �� *
BoylesVM+   ViewModelLocator �� Source# [  .���� 
���   �$��1q�._��  � RowDefinitions �� $��6* ��� $	��59* �.+�� -   $��Header��$��0��$��Center=�$��40�����#3a032d.+��� $��Right=�$��RightToLeft=� �� Orientation$ 
Horizontal=�.+��� -     HeaderImage#��[ 	 � 	Resources	   Img  Img2��%Q   &	       &	      ��../Icons/Cross_Na.png����../Icons/Cross_A.png���� -   #��[ 	 ��%M   &	       &	      ��../Icons/min_Na.png����../Icons/min_A.png��� $��1��
�������
 � ColumnDefinitions
 �� $
��283* ��� $
��135* �.+��� $��Center=�$��Center=�$	��300��$	��200��
���   �$��4,0,4,4q�._�� $	��300��$	��200��.+��� $ Vertical=�$��Bottom=�.+�� $��50�� �� $	��29* ��� $	��21* �.+��� $��1��$��10��
���   �$��2q�
���   ��� $��10��
���   �$��60��$��Bottom=�$��2q�
���   �� $��50��
�������.+��� 
���   �$��2q�$��0,0,8,0q�� ���� *	Vlength+���� *Color+
 �� $	��13* ��� $	��37* ��� $��1��$��1��$ Vertical=�$��Bottom=�.+��� $ 
Horizontal=�.+��� $��25(�$��30��$/��)Output Sans, Helvetica, Arial, sans-serif)�p:�� $��25(�$
��AUTO��$/��)Output Sans, Helvetica, Arial, sans-serif)����� *Y+�� $��
0,15,0,125q�$ 
Horizontal=�.+��� $��25(�$��30��$/��)Output Sans, Helvetica, Arial, sans-serif)�V:�� $��25(�$
��AUTO��$/��)Output Sans, Helvetica, Arial, sans-serif)����� *Ex+�� $��25(�$/��)Output Sans, Helvetica, Arial, sans-serif)�
pV = const�� $��25(�$��	0,15,0,21q�$/��)Output Sans, Helvetica, Arial, sans-serif)�	T = const