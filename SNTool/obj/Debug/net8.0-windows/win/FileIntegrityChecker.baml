   M S B A M L   `   `   `  ����A  =SNTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SNTool.win
SNTool.win  5      %    SNTool.win.FileIntegrityChecker   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SNTool.win     5      S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5        N� Title$  FileIntegrityChecker��5
      .��5      � .+�5   
   '  !HandyControl.Controls.SimplePanel  $��10,2,10,292q�6   .+�5      �� -   5        $��选择��5      $��
724,43,0,0q�6"   $��28��66   $��48��6B   $	��Top=�6M   $
��Left=�6e   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $$��计算文件的MD5哈希值：��6G   $	��Top=�6[   $��	11,19,0,0q�6s   $��17��6�   $	��124��6�   #  HandyControl.Controls.TextBox  5      -   5        $��TFile2��5      $
��Left=�6'    �� TextWrapping$
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $��9,42,0,0q�6v   $	��463��6�   �� 5      -   5        $��校验��5   *   $��
776,43,0,0q�67   $��28��6K   $��48��6W   $	��Top=�6b   $
��Left=�6z     5      -   5        $��TFile��5   4   $
��Left=�6   $
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $��
11,103,0,0q�6u   $	��461��6�   �� 5      -   5        $��选择��5      $��724,103,0,0q�6"   $��28��67   $��48��6C   $	��Top=�6N   $
��Left=�6f   6�   �� 5      -   5        $��校验��5      $��776,103,0,0q�6#   $��28��68   $��48��6D   $	��Top=�6O   $
��Left=�6g   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $!��校验文件的完整性：��6G   $	��Top=�6X   $��	11,80,0,0q�6p   $��17��6�   $	��124��6�     5      -   5        $��TFileMd5��5      $
��Left=�6)   $
 Wrap=�6D   $�� ��6X   $	��Top=�6`   $��477,103,0,0q�6x   $	��242��6�   �� 5      $
��Left=�6   $
��Wrap=�63   $��比对MD5的哈希值：��6G   $	��Top=�6Y   $��
479,80,0,0q�6q   $��17��6�   $	��124��6�     5      -   5          Name$ 	TFileMd55��5      $
��Left=�6,   $
 Wrap=�6G   $�� ��6[   $	��Top=�6c   $��
477,43,0,0q�6{   $	��242��6�   �� 5      $
��Left=�6   $
��Wrap=�63   $��生成MD5的哈希值：��6G   $	��Top=�6Y   $��
479,20,0,0q�6q   $��17��6�   $	��124��6�   5      5      5      