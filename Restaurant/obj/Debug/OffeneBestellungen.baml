   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	   #    Restaurant.OffeneBestellungen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	   $	��450��5   	   $	��800��6   .��5	      � .+�5
   
   �� -   5          ��Name$  reiterTabControl��5
      .@�5      �� $	��Bar��6   .��5      &   System.Windows.Controls.DataGrid  -   5        $��barDataGrid��5   7      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6-      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *KartenElement.ElemName+  5      $ Hinweise��6-    .  6Q   �� *
Hinweise+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Fertig��61    6A   �� *
Erledigt+5      5      �� 5      $��Küche��6   .��5        -   5        $��kuecheDataGrid��5   7    .   5        5      $
 Name��6-    .  6M   �� *KartenElement.ElemName+  5      $ Hinweise��6-    .  6Q   �� *
Hinweise+  5      $ Fertig��61    6A   �� *
Erledigt+5      5      5      �� 5    
   -   5         ��Name$ zurueck��5       $��Zurück��6"   $��88��63   $��22��6>   $��Right=�6J   $	��Top=�6f   6~   5!      5"      