   M S B A M L   `   `   `  ���� C  ?Gas Laws, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Gas_LawsGas_Laws  9!clr-namespace:Gas_Laws.ViewModelsGas_Laws.ViewModels      Gas_Laws.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Gas_Laws     8
viewmodels!clr-namespace:Gas_Laws.ViewModels       � Icon$  Icons/book.png�� � Title$ Gas Laws��$	��450��$	��950�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=� � DataContext �� *MainViewModel+   ViewModelLocator �� Source# [  .���� $��1q�
���   �._��  � ColumnDefinitions �� $
��230* ��� $
��710* �	 � RowDefinitions	 �� $	��45* ��� $
��415* �.+�� -   $��Header��$��0��$��2�����#3a032d.+��� $��Gas Laws��  Logo#��[ $��90���� $��Right=�$��RightToLeft=�
 �� Orientation$
 
Horizontal=�.+��� -     HeaderImage#��[  � 	Resources   Img  Img2��%K   &	       &	      ��Icons/Cross_Na.png����Icons/Cross_A.png���� -   #��[  ��%G   &	       &	      ��Icons/min_Na.png����Icons/min_A.png����   	HeaderBtn#��[ |�.  ���� *OpenAP+.��О программе�� #��[ $y�Visible=�|�.  ���� *	OpenVis+.��Визуализатор� -   $��	Left_Side��$��1��$��0�����#f7f7f7.+��� $
 Vertical=�.+���   
LSImageBtn#��[ |�.  ���� *GoToBrowser+ ��%D   &	       &	      ��Icons/Book.png����Icons/Book.png���� $-��'Рабочее пространство��  LSlabel#��[ �� $��Законы��  LSlabelB#��[ ��  		 LSbtn#��[	 $.��(Закон Бойля - Мариотта������ *GoToBoylesPage+�� #��[	 {�. $&�� Закон Гей-Люссака������ *GoToLussacsPage+�� #��[	 {�. $��Закон Шарля������ *GoToCharlesPage+� -   $��	Main_Side��$��1��$��1�����#ffffff.+� � -   $��	MainFrame��
����ح�  � NavigationUIVisibility$ Hidden=����� *
CurentPage+