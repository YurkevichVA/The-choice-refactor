   M S B A M L   `   `   `  ????N  JThe-Choice-Refactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:The_Choice_RefactorThe_Choice_Refactor  5   	   $    The_Choice_Refactor.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:The_Choice_Refactor     5   	     ? Title$  
MainWindow??5   	   $
??1080??6   $
??1920??6*   ??5
      ?? 5   
    ?? ImageSource$+ %Resources\Pictures\BackgroundDark.jpg??6    ? 	Resources 5       ?? Source?? 5   
   $" Resources\Styles\Styles.xaml??6   %    6E   .??5      ? -   5         ?Name$ MainGrid_Grd??5      ??5   
   ?? 5      $0 *Resources\Pictures\LinesBackgroundDark.png??6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ?? 5!      $
??auto ?6    ? RowDefinitions 5#   
   ?? 5$      $
??auto ?6   ?? 5%      .+?5'   
   ?? -   5         ??Name$ MainPage_Btn??5(      $??0??5)      $??0??5*      $??2??5+      $	??150??5,      $
??25,0q?5-      $??0,10,0,0q?5.      $??Bottom=?5/      .??51      ?? -   5         ??Name$
 Logo??52      $!??Resources\Pictures\Logo.png??53      54      ?? 55      -   5        $ CryptoPage_Btn??56      $??2??57      $??0??58      $??Cryptoes??59      $
??auto??5:      $
??25,0q?5;      $??Bottom=?5<      5=      ?? 5>      -   5        $ CurrencyPage_Btn??5?      $??3??5@      $??0??5A      $??
Currencies??5B      $
??25,0q?5C      $??Bottom=?5D      5E      ?? 5F      -   5        $ MetalPage_Btn??5G      $??4??5H      $??0??5I      $??Metals??5J      $
??25,0q?5K      $??Bottom=?5L      5M      ?? 5N      -   5        $ SharePage_Btn??5O      $??5??5P      $??0??5Q      $??Shares??5R      $??25,0 q?5S      $??Bottom=?5T      5U      ?? 5V   
   -   5        $ Options_Btn??5W      $??12??5X      $??0??5Y      $??Center=?5Z      $
??25,0q?5[      .??5]      ?? -	   5        $ OptionsIcon??5^      $??30??5_      $*??$Resources\Pictures\Icons\Options.png??5`      5a       ? 5b   
   -
   5        	  ?Name$	 PageFrame_Frm??5c      $??0??5d      $??0??5e      $??13??5f      $??2??5g      $??Stretch=?5h      $??Stretch=?5i      
  ? NavigationUIVisibility$
 Hidden=?5j      5k      5l      