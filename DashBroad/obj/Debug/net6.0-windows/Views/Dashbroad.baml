   M S B A M L   `   `   `  ����D  @DashBroad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DashBroad.ViewsDashBroad.Views  5      ;"clr-namespace:DashBroad.ComponentsDashBroad.Components  5          DashBroad.Views.Dashbroad   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DashBroad.Views     5      9
components"clr-namespace:DashBroad.Components     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��My shop��6!   $��20(�60   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      &    DashBroad.Components.ProfitTitle  $��0��6%   $��0 0 10 0q�65    � DataContext 6G   �� *ProfitViewModel+'   !DashBroad.Components.RevenueTitle  5      $��1��6&   $��0 0 10 0q�66    6H   �� *RevenueViewModel+$   DashBroad.Components.CostTitle  5      $��2��6#   $��0 0 10 0q�63    6E   �� *CostViewModel+5      +   %DashBroad.Components.RecentScaleTitle  5   
   $��2��6&    63   �� *RecentScaleViewModel+5      5      