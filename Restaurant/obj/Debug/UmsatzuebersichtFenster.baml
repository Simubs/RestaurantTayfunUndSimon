   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	   (    "Restaurant.UmsatzuebersichtFenster   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	   $	��450��5   
   $	��800��6   .��5	      � .+�5   
   �� -   5          ��Name$  UmsatzTextBox��5      $
��0€��6+   $
��Left=�65   $	��Top=�6P   $��509,152,0,0q�6h   $	��250��6}   $��38��6�   
���   �{�.  $��24(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DatumPicker��5      $
��Left=�6*   $	��Top=�6E   $��	76,71,0,0q�6]   $	��155��6p   $��28��6|   6�   �� 5   
   -   5        $��TrinkgeldListView��5      $
��Left=�6,   $	��Top=�6G   $��
10,149,0,0q�6_   $	��400��6s   $	��275��6    �� IsTextSearchEnabled .   �� View 5      �� 5      .P�5      �� $��Vorname��6%    �� Width$	 160��6_    �� DisplayMemberBinding 66   �� *	vorname+6_   �� 5      $��Nachname��6%   $	 160��6a    67   �� *
nachname+6a   �� 5      $��	Trinkgeld��6%   $ 80��6c    68   �� *	trinkgeld+6c   5      5      �� 5   
   -   5         ��Name$ ZurueckButton��5      $��Zurück��6(   $
��Left=�69   $	��Top=�6T   $��
688,10,0,0q�6l   $��32��6�   $	��102��6�   6�   �� 5   
   -   5        $ AktualisierenButton��5      $��Aktualisieren��6.   $
��Left=�6F   $��32��6a   $��
489,10,0,0q�6m   $	��Top=�6�   $	��176��6�   6�   �� 5   
   $��Umsatzübersicht��6   $
��Left=�6*   $��29��6E   $��	17,10,0,0q�6Q   $	��Top=�6d   $	��273��6|   $��16(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $��Datum:��6   $
��Left=�6!   $��27��6<   $��	17,72,0,0q�6H   $	��Top=�6[   $��54��6s   �� 5    
   $��Umsatz:��6   $
��Left=�6"   $��27��6=   $��436,157,0,0q�6I   $	��Top=�6^   $��53��6v   �� 5!   
   $$��Im Vergleich zu letztem Monat:��6   $
��Left=�69   $��32��6T   $��436,199,0,0q�6`   $	��Top=�6u   $	��182��6�   �� 5"   
   -   5        $$  ProzentualeVeraenderungTextBox��5"      $
��Left=�6<   $��32��6W   $��618,199,0,0q�6c   $
��Wrap=�6x   $��0%��6�   $	��Top=�6�   $	��162��6�   {�.  $��24(�6�   5$      5&      