   M S B A M L   `   `   `  ���� C  ?Gas Laws, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Gas_Laws.PagesGas_Laws.Pages  9!clr-namespace:Gas_Laws.ViewModelsGas_Laws.ViewModels  $    Gas_Laws.Pages.Gay_Lussacs_Law   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:Gas_Laws.Pages     8
viewmodels!clr-namespace:Gas_Laws.ViewModels       N� Title$  Gay_Lussacs_Law�� � DataContext �� *	LussacsVM+   ViewModelLocator �� Source# [  .��� ���#FFFFFF � RowDefinitions �� $
��260* �.+��� $��0��
��������� $��0�� �� Orientation$ Vertical=�.+���  
 MainTB#��[ $��
Calculator����   Formula#��[ $��V₁ / T₁ = V₂ / T₂��� $��50��$��
50,75,50,0q� �� $	��10* ��� $��3* ��� $	��10* � � ColumnDefinitions �� �� .+��� $��0��$��0��$ 
Horizontal=�.+���   blueText#��[ $��
V₁ (m³)����   TextBox#��[ ���� *Val11+{��� *Vis11+�� $��2��$��0��$ 
Horizontal=�.+��� #��[ $��	T₁ (К)���� #��[ ���� *Val21+{��� *Vis21+�� $��0��$��1��$ 
Horizontal=�$��Right=�.+��� #��[ $��
V₂ (m³)���� #��[ ���� *Val12+{��� *Vis12+�� $��2��$��1��$ 
Horizontal=�$��Right=�.+��� #��[ $��T₂ (K)���� #��[ ���� *Val22+{��� *Vis22+�� $ 
Horizontal=�$��0,30,0,0q�$��Center=�.+���   CalcBtn#��[ $��	Calculate��|�.  ���� *	ShowRes+��  
 Answer#��[ |�.  ���� *Ex+ � 	Resources �� %    