   M S B A M L   `   `   `  ����D  @DashBroad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DashBroad.ComponentsDashBroad.Components  5      &     DashBroad.Components.ProfitTitle   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DashBroad.Components     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Profit��6   �� 5   
   $��1��6   $��Center=�5      $��Center=�5      $��50(�5       �� TextAlignment$ Center=�5      ��5   "   �� *Profit+ �� StringFormat$ {0:C}����5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   �� *
IsPositive+ �� Value True6E   .a�5      ��  �� Property � �� �� Value
 � � �6;   5      �� 5       6&   �� *
IsNegative+ True6E   .a�5      ��  � ��
 �  ��6;   5      5      5       5!      5"      