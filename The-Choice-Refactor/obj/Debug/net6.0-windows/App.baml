   M S B A M L   `   `   `  ????N  JThe-Choice-Refactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:The_Choice_RefactorThe_Choice_Refactor  5          The_Choice_Refactor.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3local!clr-namespace:The_Choice_Refactor     5        ?? 	Resources  5         Button.MouseOver.Background ?? Color  Button.MouseOver.Border  FocusVisual ?? Property ?? Value ?? StrokeDashArray J? SnapsToDevicePixels  Item.MouseOver.Background  Item.MouseOver.Border " Item.SelectedActive.Background  Item.SelectedActive.Border $  Item.SelectedInactive.Background   Item.SelectedInactive.Border 	 ListBoxItemStyle1 ?? 
TargetType ?? RelativeSource ?? AncestorType	 ?? 
TargetType
 ??Name ?? Padding ?? Triggers ]? 
Conditions ?? Property ?? Value ?? 
TargetName P? Property P? Value 
 Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonTemplate1 ??Name??%?  &	        &	 #     &	 F     &	 ?     &	     &	 ?    &	 b    &	 ?    &	 ?    &		 ?    7  7  7  7  7  7  7  &	
 v    &	 ?    &	 ?    &	 ?    &	     &	 %    7 
 7  7  7  7  ?? 5   
   $ 	#FFBEE6FD??6>   ?? 5	   
   $ 	#FF3C7FB1??6:   ?? 5
   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E   $
 true??6?   $??1??6?   5      5      5      ?? 5   
   $ 	#1F26A0DA??6<   ?? 5   
   $ 	#a826A0Da??68   ?? 5   
   $ 	#3D26A0DA??6A   ?? 5   
   $ 	#FF26A0DA??6=   ?? 5   
   $ 	#3DDADADA??6C   ?? 5   
   $ 	#FFDADADA??6?   ?? 5   
   " ??6*   .?5      ??  ?@J?SnapsToDevicePixels$
 True??64   ?? 5       ? ??$	 4,1q?6(   ?? 5       ? ?? 6;   ?? *HorizontalContentAlignment+ ?? " ???? 5       ? ?? 69   ?? *VerticalContentAlignment+ ?? " ???? 5       ? ??
 ???? 6+   ?? 5       ? ??
 ???? 6,   ?? 5        ? ??$ 1q?60   ?? 5!       ?@?FocusVisualStyle8   61   ?? 5"       ? ?? 5#      ?? 5$      "	 ??6&   .R?5%      ?? $
 Bd??6!   #??z??6-   #??z??6W   #??z??6?   # z??6?   $
 true??6?   ._?5&      ?? #??z??6/   # z 6r   #??z??6?   5'       5(      ]? 5)       5*   "   ?? 5+   &    ?@J?IsMouseOver$
 True??6G   ./?5-   "   ?? $ Bd??6?   8   ? ??6O   ?? 5.   "   $ Bd??6@   8   ? ??6P   5/      ]? 50       51   "   ?? 52   &    ?@??IsSelectionActive$ False??6V   ?? 53   &    ?@??
IsSelected$
 True??6F   ./?55   "   ?? $ Bd??6?   8   ? ??6O   ?? 56   "   $ Bd??6@   8   ? ??6P   57      ]? 58       59   "   ?? 5:   &    ?@??IsSelectionActive$
 True??6V   ?? 5;   &    ?@??
IsSelected$
 True??6F   ./?5=   "   ?? $ Bd??6?   8   ? ??6O   ?? 5>   "   $ Bd??6@   8   ? ??6P   5?      P? 5@       ? {?$ False??6;   . ?5A   "   ?? $ Bd??6K   # ? ??6[    ? ??5B      5D      5F      5G      ?? 5H   
   $ 	#FFC4E5F6??6<   ?? 5I   
   $ 	#FF2C628B??68   ?? 5J   
   $ 	#FFF4F4F4??6=   ?? 5K   
   $ 	#FFADB2B5??69   ?? 5L   
   $ 	#FF838383??6=   ?? 5M   
   "	 ??62   .R?5N      ?? $
 border??6   #??z??6%   #??z??6O   #??z??6{   $
 true??6?   ._?5O      ?? $ contentPresenter??6#   $|?False??6=   #??z??6O   #??z??6?   $
??True??6?   # z 6?   #??z??6  5P       5Q      P? 5R       ?@??IsDefaulted$
 true??68   . ?5S      ?? $ border??64   # ? ??6H    ? ??5T      P? 5U       ? ??$
 true??6/   . ?5V      ?? $ border??63   8    ? ??6G   ?? 5W      $ border??64   8   ? ??6H   5X      P? 5Y       ? {?$ false??6/   . ?5Z      ?? $ border??63   8   ? ??6G   ?? 5[      $ border??64   8   ? ??6H   ?? 5\      $ contentPresenter??6?   8   ? ??6]   5]      5_      5`      5a      