   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restaurant.ConstantsRestaurant.Constants  5   	        Restaurant.RechnungAnsicht   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8	constants"clr-namespace:Restaurant.Constants     5   	   ���	#FF4545F5$	��450��5	      $	��800��6   .��5
      � .+�5   
   �� -   5          ��Name$  Titel��5      $��
Rechnungen��6   $
��Left=�64   $��41��6O   $��	18,17,0,0q�6[   $	��Top=�6n   $	��302��6�   $��18(�6�   $
��Bold"�6�   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$  OffeneBestellungenDataGrid��5      $
��Left=�67   $	��323��6R   $��	18,88,0,0q�6_   $	��Top=�6r   $	��281��6�      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      CanUserResize .     CanUserReorder .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6�   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *KartenElement.ElemName+6�     5      $ Preis��6%   $ 40 6\   	 64   �� *KartenElement.Preis+6i     5      $ Hinweise��6%   $ 91 6T   	 67   �� *
Hinweise+6a   5        5   
   -   5        $&  AusgewaehlteBestellungenDataGrid��5      $
��Left=�6=   $	��323��6X   $��
370,88,0,0q�6e   $	��Top=�6y   $	��262��6�    .  .   5        5      $
 Name��6%    .   .  $	 150 6�   	 63   �� *KartenElement.ElemName+6�     5      $ Preis��6%   $ 40 6\   	 64   �� *KartenElement.Preis+6j     5      $ Hinweise��6%   $ 72 6T   	 67   �� *
Hinweise+6a   5      �� 5   
   -   5        
 ��Name$
 BezahlenButton��5      $��Bezahlen��6)   $
��Left=�6<   $��47��6W   $��645,305,0,0q�6c   $	��Top=�6x   $	��145��6�   6�   �� 5   
   -   5        $  TrinkgeldLabel��5      $��0 €��6(   $
��Left=�66   $��42��6Q   $��645,175,0,0q�6]   $	��Top=�6r   $	��145��6�   {�.  
�������$��20(�6�   
���   �$��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ zehnCheckBox1��5      $	��10%��6*   $
��Left=�68   $��20��6S   $��655,102,0,0q�6_   $	��Top=�6t   $��85��6�   6�   �� 5   
   -   5        $ fuenfzehnCheckBox��5      $	��15%��6.   $
��Left=�6<   $��21��6W   $��655,127,0,0q�6c   $	��Top=�6x   $��85��6�    d� 	IsChecked$
 TrueY�6�   6�   �� 5   
   -   5        $ zwanzigCheckBox��5      $	��20%��6,   $
��Left=�6:   $��17��6U   $��655,153,0,0q�6a   $	��Top=�6v   $��85��6�   6�   �� 5   
   -	   5        $
 zurueckButton��5      $��Zurück��6(   $
��Left=�69   $��41��6T   $��
645,17,0,0q�6`   $	��Top=�6t   $	��145��6�   6�   �� 5    
   -
   5        $
 elementhinzufuegen��5       $��->��6-   $
��Left=�6=   $��33��6X   $��313,217,0,0q�6d   $	��Top=�6y   $��42��6�   6�   �� 5!   
   -   5        $
 loeschen��5!      $��<-��6#   $
��Left=�63   $��33��6N   $��313,266,0,0q�6Z   $	��Top=�6o   $��42��6�   6�   �� 5"   
   -   5        $  BetragLabel��5"      $��0 €��6%   $
��Left=�63   $��44��6N   $��645,255,0,0q�6Z   $	��Top=�6o   $	��145��6�   {�.  
�������$��20(�6�   
���   �$��Center=�6�   $��Center=�6�    J� RenderTransformOrigin$ 0.503,0.501&�6  �� 5#   
   $��	Trinkgeld��6   $
��Left=�6$   $��34��6?   $��
645,68,0,0q�6K   $	��Top=�6_   $	��145��6w   $
��Bold"�6�   $��14(�6�   
�������6�   �� 5$   
   $��Zu zahlender Betrag��6   $
��Left=�6.   $��34��6I   $��645,221,0,0q�6U   $	��Top=�6j   $	��145��6�   $
��Bold"�6�   $��14(�6�   
�������6�   �� 5%   
   -   5        $
 BezahlenDruckButton��5%      $��Bezahlen und Drucken��6.   $
��Left=�6M   $��52��6h   $��645,357,0,0q�6t   $	��Top=�6�   $	��145��6�   6�   (  "System.Windows.Controls.WebBrowser  5&   
   -   5          Name$ 
WebBrowser��5&      $y�Hidden=�6)   5'      5(      