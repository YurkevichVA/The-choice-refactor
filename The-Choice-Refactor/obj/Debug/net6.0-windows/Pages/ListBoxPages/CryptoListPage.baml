   M S B A M L   `   `   `  ????N  JThe-Choice-Refactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:The_Choice_Refactor.Pages.ListBoxPages&The_Choice_Refactor.Pages.ListBoxPages  5      ;    5The_Choice_Refactor.Pages.ListBoxPages.CryptoListPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:The_Choice_Refactor.Pages.ListBoxPages     5        N? Title$  CryptoListPage??5	       ? 	Resources 5
       ?? Source?? 5   
   $( "..\..\Resources\Styles\Styles.xaml??6   %    6K   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ Crypto_LstBx??5      $??Hidden=?5      $??Hidden=?5      $??0q?5      $??0??5      
?????? ??5      ?? *
cryptoes+ ?? SelectedItem 5      ?? *
Selected+??5      ?? 5      .R?5      ?? $??50??6   .+?5      ??  ??Name$ favorite_ChBx??5      -   5        $??20??5          favoriteTemplate#??[  5!       d? 	IsChecked 5"      ??  ?? Path$ 
isFavorite?5$      ?? 5%        TextBlock_Style#??[ 5&      $??Center=?5'      $??50??5(      $??14(?5)      ??5*      ?? $ number??? 5+      #??[ 5,      $??Center=?5-      $	??140??5.      $??14(?5/      ??50      ?? $ asset_id?	 ?? StringFormat$
	 0.00???? 51      #??[ 52      $??Center=?53      $	??180??54      $??14(?55      ??56      ?? $
 name?$
	 0.00???? 57      #??[ 58      $??Center=?59      $	??200??5:      $??14(?5;      ??5<      ?? $ price?$	 
0.########???? 5=      #??[ 5>      $??Center=?5?      $	??200??5@      $??14(?5A      ??5B      ?? $ 
volume_24h?$	 ### ### ### ###.???? 5C      #??[ 5D      $??Center=?5F      $	??220??5G      $??14(?5H      ??5E      ?? $ color_change_1h???5I      ?? $ 	change_1h?$
	 0.00???? 5J      #??[ 5K      $??Center=?5M      $	??200??5N      $??14(?5O      ??5L      ?? $ color_change_24h???5P      ?? $ 
change_24h?$
	 0.00???? 5Q      #??[ 5R      $??Center=?5T      $	??150??5U      $??14(?5V      ??5S      ?? $ color_change_7d???5W      ?? $ 	change_7d?$
	 0.00??5X      5Y      5[      5\      5]      