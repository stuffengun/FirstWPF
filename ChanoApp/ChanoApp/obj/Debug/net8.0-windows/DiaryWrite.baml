   M S B A M L   `   `   `  ����C  ?ChanoApp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ChanoAppChanoApp  5   	       ChanoApp.DiaryWrite   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ChanoApp     5   	     � Title$  Diary��5   	   $	��400��6   $	��800��6$   $	��400��60   $	��400��6?   .��5
      � .+�5   
   � �� 5   
   $��Right=�6   $��88��60   $��	0,10,10,0q�6<   $	��Top=�6O   $	��176��6g   ���	#FFF0F0F0$��3��6�   �� 5   
   -   5         ��Name$ 	diaryText��5      $��10,60,196,10q�6%    �� TextWrapping$
 Wrap=�6;   $��NPS font Regular)�6O   $��20(�6m   ���	#FFF0F0F0 �� AcceptsReturn$
 True��6�   ��6�   Z� 6�   �� 5   
   -   5        $ 	titleText��5      $��10,10,196,0q�6%   $
 Wrap=�6:   $��NPS font Regular)�6N   $��36(�6l   $��43��6z   $	��Top=�6�   
���   ����	#FFF0F0F0��6�   Z� 6�   �� 5   
   -   5         ��Name$ 
newFileBtn��5      $��
새 파일��6%   $��Right=�64   $��	0,16,17,0q�6P   $	��162��6c   $��21��6o   $	��Top=�6{   $��NPS font Regular)�6�   6�   �� 5   
   -   5        $ 	newTabBtn��5      $��새 창��6$   $��Right=�62   $��	0,42,17,0q�6N   $	��162��6a   $��21��6m   $	��Top=�6y   $��NPS font Regular)�6�   6�   �� 5   
   -   5        $ saveBtn��5      $��저장��6"   $��Right=�6/   $��	0,68,17,0q�6K   $	��162��6^   $��21��6j   $	��Top=�6v   $��NPS font Regular)�6�   6�   �� 5   
   -   5         ��Name$ WorkLog��5      $!��변경사항 저장 안 됨��6!   $��Right=�67   $��
0,103,10,0q�6S   $	��176��6g    J� Opacity$ 0.995Q�6s   ���	#FF9D9D9D$��NPS font Regular)�6�   $��20��6�   $	��Top=�6�   $��0,0,0,0q�6�   5      5      