   M S B A M L   `   `   `  ���� G  CBabySchedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BabyScheduleBabySchedule      BabySchedule.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  &localclr-namespace:BabySchedule    � Title$  Baby Schedule��$	��420��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 	Resources    MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�   &	        &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$ 60Q�  $ 0:0:0.5��$	 180Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 180Q�  $ 0:0:0.5��$ 60Q�	 � Triggers	 :� 
 :� RoutedEvent$
 ButtonBase.Click�� :� 
SourceName$ ButtonOpenMenu��.[��� #��[  :� $
 ButtonBase.Click��$ ButtonCloseMenu��.[��� #��[ .��� .+�� -   $��60��$	��Top=����	#FFF7D1FF.+��� -    ��Name$ AppTitle��$��Baby Schedule��$��Center=�$��Center=�$��22(�$
��Bold"�� -    �Name$ GridMenu��$��60��$
��Left=����	#FFD4A1D4.+��� .+�� $��60��
�������.+��� -    ��Name$ ButtonCloseMenu��$��60��$��60��$	��Top=�$��Right=�$y�	Collapsed=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  ���	#FFD4A1D4   Kind$ 	ArrowLeft=�$��25��$��25���� -   $ ButtonOpenMenu��$��60��$��60��$	��Top=�$��Right=���Z� ��Z� .��  ���	#FFD4A1D4$
 Menu=�$��25��$��25���� $��Disabled=�.@��� $��60��
�������.���� -   $ 
ButtonHome��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .����  �� Orientation$ 
Horizontal=�$��37��.+�  $ BabyFace=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -   $ ButtonLabelHome��$
��Home��$��Center=�$��30 10q��� $��60��
�������.���� -   $ 
ButtonNext��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .���� $ 
Horizontal=�$��37��.+�  $ 
BabyBottle=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -	   $ ButtonLabelNextTask��$��	Next task��$��Center=�$��30 10q��� $��60��
�������.���� -
   $ ButtonToday��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .���� $ 
Horizontal=�$��37��.+�  $ Schedule=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -   $ ButtonLabelSchedule��$��Schedule��$��Center=�$��30 10q��� $��60��
�������.���� -   $ ButtonSettings��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .���� $ 
Horizontal=�$��37��.+�  $ Settings=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -   $ ButtonLabelSettings��$��Settings��$��Center=�$��30 10q��� -    ��Name$ ItemQuit��$��60��
�������.���� -   $ 
ButtonQuit��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .���� $ 
Horizontal=�$��37��.+�  $ Power=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -   $ ButtonLabelQuit��$
��Quit��$��Center=�$��30 10q��� $��60��
�������.���� -   $ ButtonAbout��$��0q�
������ $��10,0,0,0q�$
��Left=�$��0q���Z� .���� $ 
Horizontal=�$��37��.+�  $ About=�$��25��$��25��$��-1,0,0,0q�$��Center=��� -   $ ButtonLabelAbout��$��About��$��Center=�$��30 10q�� -   $ 	GridAbout��$
��Left=�$	��360��$��	60,60,0,0q�$	��Top=�$	��740��$y�Hidden=�.+��� -   $ textBlockAbout��$
��Left=�$��	60,50,0,0q�$
��Wrap=�$	��Top=�$��16(�$	��620��wuBaby Schedule allows your baby to follow daily routines which can result in a better sleep at night for both parents!�� �� ^\Baby's birthdate is used to calculate suggested daily routine and changes as the baby grows.�� �� ��Baby Schedule is only an alert application, parents are responsible to take the decisions and meet baby's needs. Please check with a doctor if you need medical advices.� -   $ GridSettings��$
��Left=�$	��360��$��	60,60,0,0q�$	��Top=�$	��740��$y�Hidden=�.+��� -    ��Name$ LabelBithday��$��Baby birthdate:��$
��Left=�$��	60,30,0,0q�$	��Top=�$��16(�(  "System.Windows.Controls.DatePicker  -     Name$ DatePickerBirthday��$��25��$
��Left=�$��	60,60,0,0q�$	��Top=�$	��120���� -   $ LabelWakeUp��$��Wake up time:��$
��Left=�$��
60,120,0,0q�$	��Top=�$��16(�)  #MaterialDesignThemes.Wpf.TimePicker  -     Name$ TimePickerWakeUp��$
��Left=�$��60, 150,0,0q�$	��Top=�$	��120��   	Is24Hours . �� -    ��Name$ CheckBoxBath��$
��Left=�$��
60,217,0,0q�$	��Top=��� -   $ 	LabelBath��$��
Bath time:��$
��Left=�$��
75,210,0,0q�$	��Top=�$��16(�  -   $ TimePickerBath��$
��Left=�$��60, 240,0,0q�$	��Top=�$	��120�� . �� -   $ LabelBathExplaination��$<��6Activate/Deactivate bath reminder at your desired time��$
��Left=�$��
60,270,0,0q�$	��Top=�$��12(��� -   $ LabelLanguage��$��	Language:��$
��Left=�$��
400,30,0,0q�$	��Top=�$��16(�	� -    	�Name$ RadioButtonEn�� 	� 	GroupName$ Language��$��English��$
��Left=�$��
400,60,0,0q�$	��Top=� d� 	IsChecked$
 TrueY�	� -    $ RadioButtonJp��$ Language��$��	日本語��$
��Left=�$��
400,90,0,0q�$	��Top=��� -!   $ ButtonSaveSettings��$
��Save��$
��Left=�$��605,262,0,0q�$	��Top=�$��75��� -"   $ 	GridToday��$
��Left=�$	��360��$��	60,60,0,0q�$	��Top=�$	��740��$y�Hidden=�.+��� -#   $ TextTodayTitle��$
��Left=�$	��Top=�$��	60,30,0,0q�$��Today's schedule:��$��16(�$
��Bold"��� -$   $��	ListToday��$��60,60,60,30q����� *TodayroutineList+ �� View �� .P��� -%   
ColumnTask��$
��Task�� �� Width$	 300�� �� DisplayMemberBinding ��  �� Path$ TaskName��� -&   
ColumnTime��$
��Time��$	 200�� �� $
 Time��� -'   
ColumnDone��$
��Done��$ 80�� �� $ 	Completed�� -(   $ GridNext��$
��Left=�$	��360��$��	60,60,0,0q�$	��Top=�$	��740��$y�Hidden=�.+��� -)   $ TextNext��$
��Left=�$	��Top=�$��	60,30,0,0q�$��
Next task:��$��16(�$
��Bold"��� -*   $ TextNextTaskName��$��Center=�$	��Top=�$��0,49,0,0q�$�� ��$��40(�$
��Bold"�$
��auto���� -+   $ TextNextTime��$��Center=�$��Bottom=�$�� h  min  sec left��$��32(�$��0,0,0,30q�$
��auto���� -,    ��Name$ 	ImageNext��$	��150��$	��150��$��Center=�$��Center=�$��	empty.png��$��281,105,309,105q�� --   $ GridHome��$
��Left=�$	��360��$��	60,60,0,0q�$	��Top=�$	��740��$y�Visible=�.+��� -.   $ TextCurrent��$
��Left=�$	��Top=�$��	60,30,0,0q�$��Current task:��$��16(�$
��Bold"��� -/   $ TextCurrentTaskName��$��Center=�$	��Top=�$��0,49,0,0q�$�� ��$��40(�$
��Bold"�$
��auto���� -0   $ ButtonCompleted��$��	Completed��$��Center=�$��Bottom=�$��295,0,325,30q�$	��120��{�.  �� -1   $ ImageCurrent��$	��150��$	��150��$��Center=�$��Center=�$��	empty.png��$��281,105,309,105q�