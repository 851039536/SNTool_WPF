   M S B A M L   `   `   `  ����A  =SNTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SNTool.videoSNTool.video  5          SNTool.video.VideoUI   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SNTool.video     5      S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  60     N� Title$  Page1��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"   $��Center=�62   .+�5      �� -   5        $	��150��5      $��清空数据��6!   6C   �� 5      -   5         ��Name$ 	myListBox��5      $	��150��6)   5      �� 5   
   $��1��6   $��1��6"   .+�5       �� 
���   �$��3q�6(   $��Center=�6<   $	��340��5!      $	��Top=�6#   $	��620��6;    J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         Color$ 	#FFE4CC8D��6'   ��5%      �� 5&       �� 
StartPoint$	 1,0&�6*    �� EndPoint$	 1,1&�6;   .��5'      �  � Offset$ 0Q�6'   	 � Color$	 White��62   � 5(      $	 0.5Q�6'   $
	 Gold��64   5)      ._�5+      r� -   5        $��me��5+      
 r� LoadedBehavior$
 Manual=�6)    r� 
SpeedRatio$ 1Q�5,       r� Stretch$
 Fill=�5-       r� UnloadedBehavior$
 Stop=�5.       r� ScrubbingEnabled$
 True��5/       r� Balance$	 0.6Q�51       r� Volume 50      ��  �� ElementName$ volumeSlider�� �� Path$ Value�53      54      �� 55      $��0,10,0,0q�6    �� Orientation$ 
Horizontal=�6+   $��Center=�6D   .+�56      �� $��进度��6   
�������$��5q�68   �� 57      -   5         ��Name$ 	posSlider��57       � Minimum$ 0Q�6,   $	��340��6:    �� IsMoveToPointEnabled$
 True��6u    � Value 6F   �� $ me��$ Position�6�   �� 58      -   5        $��lblTime��58      $��70��6'   $��25��62   $��00:04��6>   6P   �� 59      $��音量��6   
�������$��20,0,0,0q�68   �� 5:      -   5        $ volumeSlider��5:      $
��10,0q�6/   $ 0Q�6=    � Maximum$ 1Q�6I   $	 0.5Q�6U   $	��100��6a   5;      �� 5=      $ 
Horizontal=�6   $��Center=�63   $��Bottom=�6P   $	��0,7q�6k   .+�5>      �� -   5         ��Name$ openBtn��5>      $��打开��6*   69   �� 5@      -   5        $ playBtn��5@      $��播放��6*   67   �� 5B      -	   5        $ stopBtn��5B      $��停止��6*   67   �� 5D      -
   5        $ backBtn��5D      $��快退��6*   69   �� 5F      -   5        $ 
forwardBtn��5F      $��快进��6-   6;   5I      �� 5J      $ 
Horizontal=�6   $��Center=�62   $��Bottom=�6O   .+�5K      �� -   5        $ openBtn1��5K      $��	前定位��6+   $��25��69   6F   �� 5M      -   5         ��Name$ lblTime1��5M      $��70��6*   $��25��65   $��00:00:00��6A   �� 5N      -   5        $ playBtn1��5N      $��	后定位��6+   $��25��69   6E   �� 5P      -   5        $ lblTime2��5P      $��70��6*   $��25��65   $��00:00:00��6A   �� 5Q      -   5        $	 cut��5Q      $��截取��6&   $��25��63   6?   �� 5S      -   5        $��合并��5S      $��25��6&   62   5T      �� 5U      .+�5V      �� -   5        $��截取目录��5V      $��Right=�6(   $	��0,1q�6D   6Q   �� 5W      -   5        $��合并目录��5W      $��Right=�6(   $	��0,1q�6D   6Q   5X      5\      5a      5b      