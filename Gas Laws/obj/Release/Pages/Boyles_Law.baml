   M S B A M L   `   `   `  ���� C  ?Gas Laws, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Gas_Laws.PagesGas_Laws.Pages  9!clr-namespace:Gas_Laws.ViewModelsGas_Laws.ViewModels  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf     Gas_Laws.Pages.Boyles_Law   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:Gas_Laws.Pages     8
viewmodels!clr-namespace:Gas_Laws.ViewModels     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf       N� Title$  
Boyles_Law�� � DataContext �� *
BoylesVM+   ViewModelLocator �� Source# [  .��� 
������� � ColumnDefinitions �� $
��380* ��� $
��200* � � RowDefinitions �� $
��330* ��� $	��50* �.+�� $��0��
�������.+�#  LiveCharts.Wpf.CartesianChart  $��1��$��5,5,5,5q�&   LiveCharts.Wpf.Charts.Base.Chart   Series   LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   Fill
 ����    Values �� *
MyValues+   Title �� *Series+	   AxisY	   LiveCharts.Wpf.Axis  
   FontSize$
 15Q�   
Foreground
 �   �   Title �� *axisY+   AxisX   $
 15Q�
 �   � �� *axisX+   Labels �� *Labels+��  �� Orientation$ Vertical=�$��1��
�������$��1��.+��� $��
Объём��$��SemiBold"�$��18(�$/��)Output Sans, Helvetica, Arial, sans-serif)����#121212$��
15,15,15,0q��� $��3q����#3A032D �� CornerRadius$ 4��$��	15,5,15,0q�._��� $��30��$��16(�$��Medium"�$��0q�$��1q�$/��)Output Sans, Helvetica, Arial, sans-serif)�$��Center=����#3A032D$��10,0,0,0q�{��� *Vis1+���� *V+ J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 7Q�   Opacity$
 0.25Q�   Color$ #000000��   	Direction$	 270Q�   ShadowDepth$ 4Q��� $��Давление��$��SemiBold"�$��18(�$/��)Output Sans, Helvetica, Arial, sans-serif)����#121212$��
15,10,15,5q��� $��3q����#3A032D$ 4��$��	15,5,15,0q�._��� $��30��$��16(�$��Medium"�$��0q�$��1q�$/��)Output Sans, Helvetica, Arial, sans-serif)�$��Center=����#3A032D$��10,0,0,0q�{��� *Vis2+���� *P+   $ 7Q�$
 0.25Q�$ #000000��$	 270Q�$ 4Q��� $y�Hidden=�$3��-Оценимаемая погрешность��$��SemiBold"�$��18(�$/��)Output Sans, Helvetica, Arial, sans-serif)����#121212$��
15,22,15,0q��� $��Что делаем?��$��SemiBold"�$��18(�$/��)Output Sans, Helvetica, Arial, sans-serif)����#121212$��	15,0,15,0q��� $��3q����#3A032D$ 4��$��	15,5,15,0q�._��� $��30��$��16(�$��Medium"�$��0q�$��1q�$/��)Output Sans, Helvetica, Arial, sans-serif)�$��Center=����#3A032D$��10,0,0,0q�{��� *Vis3+ �� SelectedIndex �� *Mode+.@��� .���� .+��� $��16(�#!Отпускаем поршень�� .���� .+��� $��16(�Сжимаем поршень   $ 7Q�$
 0.25Q�$ #000000��$	 270Q�$ 4Q��� $��Шаг изменения��$��SemiBold"�$��18(�$/��)Output Sans, Helvetica, Arial, sans-serif)����#121212$��
15,14,15,0q��� $��3q����#3A032D$ 4��$��	15,5,15,0q�._��� $��30��$��16(�$��Medium"�$��0q�$��1q�$/��)Output Sans, Helvetica, Arial, sans-serif)�$��Center=����#3A032D$��10,0,0,0q�{��� *Vis4+���� *Shag+   $ 7Q�$
 0.25Q�$ #000000��$	 270Q�$ 4Q�� $��1��$��0,0,0,8q�$��2��
������� �� $
��251* ��� $
��139* ��� $
��139* �.+��� $��0��$��5,5,5,0q�  StartBtn#��[ $��
СТАРТ��{��� *Vis5+���� *	DataAdd+�� $��1��$��5,5,5,0q�  StopBtn#��[ $��СТОП��{��� *Vis6+���� *Stop+�� $��2��$��5,5,5,0q�#��[ $��ОЧИСТИТЬ��{��� *Vis7+���� *Clear+