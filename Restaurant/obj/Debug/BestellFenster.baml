   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	   7 clr-namespace:Restaurant.EntitysRestaurant.Entitys  5   	       Restaurant.BestellFenster   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	   4Entitys clr-namespace:Restaurant.Entitys     5   	   $	��450��5	   	   $	��800��6   .��5
      � .+�5   
   �� -   5          ��Name$  zurueck��5      $��Zurück��6"   $
��Left=�63   $��33��6N   $��
678,10,0,0q�6Z   $	��Top=�6n   $	��112��6�   6�   �� 5   
   -   5        $  TischWechselnButton��5      $��Tisch übergeben��6.   $
��Left=�6H   $��82��6c   $��664,217,0,0q�6o   $	��Top=�6�   $	��126��6�   6�   �� 5   
   -   5        $   BestellungAbschickenButton��5      $��Bestellung abschicken��65   $
��Left=�6U   $	��104��6p   $��664,310,0,0q�6}   $	��Top=�6�   $	��126��6�   6�   �� 5   
   -   5         ��Name$ hinweiseTextBox��5      $
��Left=�6+   $	��103��6F   $��
664,99,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $��Hinweise��6{   $	��Top=�6�   $	��126��6�   �� 5   
   -   5        $  AbrechnenButton��5      $��	Abrechnen��6*   $
��Left=�6>   $��29��6Y   $��
456,48,0,0q�6e   $	��Top=�6y   $	��203��6�   6�   �� 5   
   $��Bestellfenster��6   $
��Left=�6)   $��33��6D   $��	23,10,0,0q�6P   $	��Top=�6c   $	��416��6{   $��16(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ KartenElementeGridView��5      $
��Left=�63   $	��315��6N   $��	23,99,0,0q�6[   $	��Top=�6n   $	��285��6�      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 225 6P   
   CanUserResize
 .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
ElemName+6t     5      $ Preis��6%   $	 60 6N   
 .   64   �� *Preis+6q   5        5   
   -   5        $ BestellungenDataGrid��5      $
��Left=�61   $	��315��6L   $��
360,99,0,0q�6Y   $	��Top=�6m   $	��285��6�    .   5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Fertig?��6)    6:   �� *
Erledigt+6Y     5      -   5        BestellungDataGrid��$
 Name��5   A   $	 80 6z   
 .     CanUserReorder .     
IsReadOnly .  6O   �� *KartenElement.ElemName+6�     5      $ Hinweise��6%   $		 118 67    6C   �� *
Hinweise+6b     5      $ Preis��6%   $	 40 64    .  6?   �� *KartenElement.Preis+6{   5      �� 5   
   -	   5        $  elementhinzufuegen��5      $��->��6-   $
��Left=�6=   $��33��6X   $��313,217,0,0q�6d   $	��Top=�6y   $��42��6�   6�   �� 5    
   -
   5        $  loeschen��5       $��<-��6#   $
��Left=�63   $��33��6N   $��313,266,0,0q�6Z   $	��Top=�6o   $��42��6�   6�   �� 5!   
   -   5         ��Name$ ElementArtAuswahlComboBox��5!      $
��Left=�66   $��29��6Q   $��	23,48,0,0q�6]   $	��Top=�6p   $	��416��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   6�   5#      5$      