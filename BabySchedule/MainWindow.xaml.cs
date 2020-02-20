using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Media;

namespace BabySchedule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class RoutineTask
        {
            public string TaskName { get; set; }
            public string Time { get; set; }
            public string Completed { get; set; }

            public RoutineTask(string TaskName, string Time, string Completed)
            {
                this.TaskName = TaskName;
                this.Time = Time;
                this.Completed = Completed;
            }
        }

        public List<RoutineTask> TodayroutineList { get; set; }

        public static List<RoutineTask> Routine(int age, DateTime wakeupTime, DateTime bathtimeTime, string language, Boolean bath = false)
        {
            var routineList = new List<RoutineTask>() { };
            string feedmilk = String.Empty;
            string nap = String.Empty;
            string wake = String.Empty;
            string water = String.Empty;
            string feedmilkfood = String.Empty;
            string feedfood = String.Empty;
            string feedmilkfoodjuice = String.Empty;
            string no = String.Empty;
            string bathstring = String.Empty;

            if (language == "EN")
            {
                feedmilk = "Feeding (Milk)";
                nap = "Nap";
                wake = "Wake up";
                water = "Feeding (Lukewarm water)";
                feedmilkfood = "Feeding (Milk/Food)";
                feedfood = "Feeding (Food)";
                feedmilkfoodjuice = "Feeding (Milk/Water/Juice)";
                no = "No";
                bathstring = "Bath";
            }
            else
            {
                feedmilk = "ミルクタイム";
                nap = "お昼寝タイム";
                wake = "お昼寝終了";
                water = "湯冷ましタイム";
                feedmilkfood = "ミルク/離乳食タイム";
                feedfood = "離乳食タイム";
                feedmilkfoodjuice = "ミルク/ジュース/離乳食タイム";
                no = "x";
                bathstring = "お風呂タイム";
            }


            if (age < 14)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(1).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime feedTime1 = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(wake, feedTime1.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(3).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(4).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime napTime3 = wakeupTime.AddHours(8).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime3.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(10);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime6 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime6.ToString("H:mm"), no));
            }
            else if (age >= 14 && age < 28)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime feedTime1 = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(wake, feedTime1.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(3).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(4).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime napTime3 = wakeupTime.AddHours(9);
                routineList.Add(new RoutineTask(nap, napTime3.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(10);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime6 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime6.ToString("H:mm"), no));
            }
            else if (age >= 28 && age < 42)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime feedTime1 = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(feedmilk, feedTime1.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(3).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(4).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime wakeup1 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(wake, wakeup1.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime napTime3 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(nap, napTime3.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(10);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime6 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime6.ToString("H:mm"), no));
            }
            else if (age >= 42 && age < 56)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime feedTime1 = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(feedmilk, feedTime1.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(3).AddMinutes(45);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(5);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime wakeup1 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(wake, wakeup1.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime waterTime1 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(water, waterTime1.ToString("H:mm"), no));
                DateTime napTime3 = wakeupTime.AddHours(9).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime3.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(10);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime6 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime6.ToString("H:mm"), no));
            }
            else if (age >= 56 && age < 84)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime wakeup = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(wake, wakeup.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(3).AddMinutes(45);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(5);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime wakeup1 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(wake, wakeup1.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime waterTime1 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(water, waterTime1.ToString("H:mm"), no));
                DateTime napTime3 = wakeupTime.AddHours(9).AddMinutes(45);
                routineList.Add(new RoutineTask(nap, napTime3.ToString("H:mm"), no));
                DateTime wakeup2 = wakeupTime.AddHours(10);
                routineList.Add(new RoutineTask(wake, wakeup2.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
            }
            else if (age >= 84 && age < 168)
            {
                routineList.Add(new RoutineTask(feedmilk, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime wakeup = wakeupTime.AddHours(3);
                routineList.Add(new RoutineTask(wake, wakeup.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(4);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(5);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime wakeup1 = wakeupTime.AddHours(7);
                routineList.Add(new RoutineTask(wake, wakeup1.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime3.ToString("H:mm"), no));
                DateTime waterTime1 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(water, waterTime1.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(11).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(15);
                routineList.Add(new RoutineTask(feedmilk, feedTime5.ToString("H:mm"), no));
            }
            else if (age >= 168 && age < 252)
            {
                routineList.Add(new RoutineTask(feedmilkfood, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime wakeup = wakeupTime.AddHours(2).AddMinutes(30);
                routineList.Add(new RoutineTask(wake, wakeup.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(4);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(5);
                routineList.Add(new RoutineTask(feedfood, feedTime3.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(5).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime4.ToString("H:mm"), no));
                DateTime waterTime1 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(water, waterTime1.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11);
                routineList.Add(new RoutineTask(feedfood, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
                DateTime feedTime6 = wakeupTime.AddHours(15).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilk, feedTime6.ToString("H:mm"), no));
            }
            else
            {
                routineList.Add(new RoutineTask(feedmilkfood, wakeupTime.ToString("H:mm"), no));
                DateTime napTime1 = wakeupTime.AddHours(2).AddMinutes(15);
                routineList.Add(new RoutineTask(nap, napTime1.ToString("H:mm"), no));
                DateTime wakeup = wakeupTime.AddHours(2).AddMinutes(30);
                routineList.Add(new RoutineTask(wake, wakeup.ToString("H:mm"), no));
                DateTime feedTime2 = wakeupTime.AddHours(4);
                routineList.Add(new RoutineTask(feedmilk, feedTime2.ToString("H:mm"), no));
                DateTime feedTime3 = wakeupTime.AddHours(5);
                routineList.Add(new RoutineTask(feedfood, feedTime3.ToString("H:mm"), no));
                DateTime napTime2 = wakeupTime.AddHours(5).AddMinutes(30);
                routineList.Add(new RoutineTask(nap, napTime2.ToString("H:mm"), no));
                DateTime feedTime4 = wakeupTime.AddHours(7).AddMinutes(30);
                routineList.Add(new RoutineTask(feedmilkfoodjuice, feedTime4.ToString("H:mm"), no));
                DateTime waterTime1 = wakeupTime.AddHours(9).AddMinutes(15);
                routineList.Add(new RoutineTask(water, waterTime1.ToString("H:mm"), no));
                DateTime feedTime5 = wakeupTime.AddHours(11);
                routineList.Add(new RoutineTask(feedfood, feedTime5.ToString("H:mm"), no));
                DateTime napTime4 = wakeupTime.AddHours(12);
                routineList.Add(new RoutineTask(nap, napTime4.ToString("H:mm"), no));
            }

            // Inserts bath time in the schedule at the right place
            if (bath)
            {
                String bathhour = bathtimeTime.ToString("H:mm");

                for (int i = 0; i < routineList.Count - 1; i++)
                {
                    Console.WriteLine(i);
                    if ((i == 0) && (DateTime.Parse(bathhour).CompareTo(DateTime.Parse(routineList[i].Time)) < 1))
                    {
                        routineList.Insert(i, new RoutineTask(bathstring, bathhour, no));
                        break;
                    }
                    else if ((DateTime.Parse(bathhour).CompareTo(DateTime.Parse(routineList[i].Time)) == 1) && (DateTime.Parse(bathhour).CompareTo(DateTime.Parse(routineList[i + 1].Time)) < 1))
                    {
                        routineList.Insert(i + 1, new RoutineTask(bathstring, bathhour, no));
                        break;
                    }
                    else if (i == routineList.Count - 2)
                    {
                        routineList.Add(new RoutineTask(bathstring, bathhour, no));
                        break;
                    }
                }
            }

            return routineList;
        }

        public static Boolean isSettingsValid()
        {
            string filename = "config.txt";

            if (File.Exists(filename))
                return true;
            return false;
        }

        public static Boolean isSaveValid()
        {
            string filename = "save.txt";

            if (File.Exists(filename))
                return true;
            return false;
        }

        public void uitoEN()
        {
            AppTitle.Text = "Baby Schedule";
            ButtonLabelHome.Text = "Home";
            ButtonLabelNextTask.Text = "Next task";
            ButtonLabelSchedule.Text = "Schedule";
            ButtonLabelSettings.Text = "Settings";
            ButtonLabelQuit.Text = "Quit";
            ButtonLabelAbout.Text = "About";
            textBlockAbout.Text =
                "Baby Schedule allows your baby to follow daily routines which can result in a better sleep at night for both parents!\n\n" +
                "Baby's birthdate is used to calculate suggested daily routine and changes as the baby grows.\n\n" +
                "Baby Schedule is only an alert application, parents are responsible to take the decisions and meet baby's needs. Please check with a doctor if you need medical advices.";
            TextTodayTitle.Text = "Today's schedule:";
            TextNext.Text = "Next task:";
            TextCurrent.Text = "Current task:";
            TextNextTime.Text = "h  min  sec left";
            LabelBithday.Content = "Baby birthdate:";
            LabelWakeUp.Content = "Wake up time:";
            LabelBath.Content = "Bath time:";
            LabelBathExplaination.Content = "Activate/Deactivate bath reminder at your desired time";
            LabelLanguage.Content = "Language:";
            ButtonSaveSettings.Content = "Save";
            ButtonCompleted.Content = "Completed";
            ColumnTask.Header = "Task";
            ColumnTime.Header = "Time";
            ColumnDone.Header = "Done";
        }

        public void uitoJP()
        {
            AppTitle.Text = "ベイビースケジュール";
            ButtonLabelHome.Text = "ホーム";
            ButtonLabelNextTask.Text = "次のタスク";
            ButtonLabelSchedule.Text = "スケジュール";
            ButtonLabelSettings.Text = "設定";
            ButtonLabelQuit.Text = "終了";
            ButtonLabelAbout.Text = "アプリについて";
            textBlockAbout.Text =
                "ベイビースケジュールに従うことで赤ちゃんの生活リズムが整い、夜通し眠ることができるようになるため、結果としてパパとママの睡眠時間の確保にもつながります。\n\n" +
                "生後週数に基づいた生活スケジュールを提案し、成長に合わせてスケジュールを調整していきます。\n\n" +
                "ベイビースケジュールはリマインダーアプリです。お子様の個性やニーズに合わせて保護者の方の最終判断でご利用くださいますようお願いいたします。必要に応じて医療機関にご相談ください。";
            TextTodayTitle.Text = "今日のスケジュール";
            TextNext.Text = "次のタスク";
            TextCurrent.Text = "現在のタスク";
            TextNextTime.Text = "残り　時　分　秒";
            LabelBithday.Content = "赤ちゃんの誕生日";
            LabelWakeUp.Content = "起床時間";
            LabelBath.Content = "お風呂の時間";
            LabelBathExplaination.Content = "お風呂タイムリマインダーのOn/Off(希望の時間に設定可能)";
            LabelLanguage.Content = "言語";
            ButtonSaveSettings.Content = "保存";
            ButtonCompleted.Content = "完了";
            ColumnTask.Header = "タスク";
            ColumnTime.Header = "時間";
            ColumnDone.Header = "完了";
        }

        public static void createSaveFile(List<RoutineTask> list)
        {
            string filename = "save.txt";
            File.WriteAllText(filename, String.Empty);
            string fileContent = String.Empty;
            fileContent = fileContent + DateTime.Now.ToString() + Environment.NewLine;
            foreach (RoutineTask routine in list)
            {
                fileContent = fileContent + routine.TaskName + Environment.NewLine;
                fileContent = fileContent + routine.Time + Environment.NewLine;
                fileContent = fileContent + routine.Completed + Environment.NewLine;
            }
            File.WriteAllText(filename, fileContent);
        }

        public void loadConfFile()
        {
            var configfs = new FileStream("config.txt", FileMode.Open, FileAccess.Read);
            var configsr = new StreamReader(configfs, Encoding.UTF8);

            // Loads configuration from config file and fills application settings
            DatePickerBirthday.Text = configsr.ReadLine();

            TimePickerWakeUp.Text = configsr.ReadLine();

            string line = configsr.ReadLine();
            if (line == "true")
            {
                CheckBoxBath.IsChecked = true;

                TimePickerBath.Text = configsr.ReadLine();

                line = configsr.ReadLine();
                if (line == "EN")
                {
                    RadioButtonEn.IsChecked = true;
                    RadioButtonJp.IsChecked = false;
                }
                else
                {
                    RadioButtonEn.IsChecked = false;
                    RadioButtonJp.IsChecked = true;
                }

            }
            else
            {
                line = configsr.ReadLine();
                if (line == "EN")
                {
                    RadioButtonEn.IsChecked = true;
                    RadioButtonJp.IsChecked = false;
                }
                else
                {
                    RadioButtonEn.IsChecked = false;
                    RadioButtonJp.IsChecked = true;
                }
            }

            configfs.Close();
        }

        public static int DaysAge(DateTime birthdate)
        {
            TimeSpan age = DateTime.Now - birthdate;

            return (int)Math.Floor(age.TotalDays);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Boolean noTasksLeft = true;
            foreach (RoutineTask routine in TodayroutineList)
            {
                string now = DateTime.Today.ToString().Substring(0, 11) + DateTime.Now.ToString("HH:mm:ss");
                string routineTime = DateTime.Today.ToString().Substring(0, 11) + routine.Time + ":00";

                // There is a task coming
                if ((routine.Completed == "No" || routine.Completed == "x") && (DateTime.Parse(now).CompareTo(DateTime.Parse(routineTime)) < 1))
                {
                    if (RadioButtonEn.IsChecked == true)
                        TextCurrentTaskName.Text = "No current task pending";
                    else
                        TextCurrentTaskName.Text = "完了していないタスクはありません";

                    ButtonCompleted.IsEnabled = false;
                    TextNextTaskName.Text = routine.TaskName;
                    TimeSpan difference = DateTime.Parse(routineTime) - DateTime.Parse(now);
                    if (RadioButtonEn.IsChecked == true)
                        TextNextTime.Text = difference.Hours.ToString() + " h " + difference.Minutes.ToString() + " min " + difference.Seconds.ToString() + " sec left";
                    else
                        TextNextTime.Text = "残り" + difference.Hours.ToString() + "時" + difference.Minutes.ToString() + "分" + difference.Seconds.ToString() + "秒";

                    ImageCurrent.Source = new BitmapImage(new Uri(@"empty.png", UriKind.Relative));
                    if (routine.TaskName.StartsWith("Feed") || routine.TaskName.StartsWith("ミルク") || routine.TaskName.StartsWith("離乳食"))
                        ImageNext.Source = new BitmapImage(new Uri(@"feeding.png", UriKind.Relative));
                    else if (routine.TaskName == "Nap" || routine.TaskName.StartsWith("お昼寝"))
                        ImageNext.Source = new BitmapImage(new Uri(@"sleep.png", UriKind.Relative));
                    else if (routine.TaskName == "Bath" || routine.TaskName.StartsWith("お風呂"))
                        ImageNext.Source = new BitmapImage(new Uri(@"bath.png", UriKind.Relative));
                    else if (routine.TaskName.StartsWith("Wake") || routine.TaskName.StartsWith("お昼寝終了"))
                        ImageNext.Source = new BitmapImage(new Uri(@"wakeup.png", UriKind.Relative));

                    noTasksLeft = false;
                    break;
                }
                // There is a current taks
                else if ((routine.Completed == "No"　|| routine.Completed == "x") && (DateTime.Parse(now).CompareTo(DateTime.Parse(routineTime)) > -1))
                {
                    TextCurrentTaskName.Text = routine.TaskName;
                    ButtonCompleted.IsEnabled = true;
                    if (RadioButtonEn.IsChecked == true)
                        TextNextTaskName.Text = "Current tasks pending";
                    else
                        TextNextTaskName.Text = "完了されていないタスク";

                    TextNextTime.Text = String.Empty;

                    ImageNext.Source = new BitmapImage(new Uri(@"empty.png", UriKind.Relative));
                    if (routine.TaskName.StartsWith("Feed") || routine.TaskName.StartsWith("ミルク") || routine.TaskName.StartsWith("離乳食"))
                        ImageCurrent.Source = new BitmapImage(new Uri(@"feeding.png", UriKind.Relative));
                    else if (routine.TaskName == "Nap" || routine.TaskName.StartsWith("お昼寝"))
                        ImageCurrent.Source = new BitmapImage(new Uri(@"sleep.png", UriKind.Relative));
                    else if (routine.TaskName == "Bath" || routine.TaskName.StartsWith("お風呂"))
                        ImageCurrent.Source = new BitmapImage(new Uri(@"bath.png", UriKind.Relative));
                    else if (routine.TaskName.StartsWith("Wake") || routine.TaskName.StartsWith("お昼寝終了"))
                        ImageCurrent.Source = new BitmapImage(new Uri(@"wakeup.png", UriKind.Relative));

                    noTasksLeft = false;

                    try
                    {
                        SoundPlayer player = new SoundPlayer();
                        player.SoundLocation = @"C:\Windows\Media\Ring03.wav";
                        player.Play();
                    }
                    finally
                    {
                    }
                    
                    break;
                }
            }

            if (noTasksLeft)
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    TextCurrentTaskName.Text = "No tasks left today";
                    TextNextTaskName.Text = "No tasks left today";
                }
                else
                {
                    TextCurrentTaskName.Text = "今日のタスクはすべて完了しました";
                    TextNextTaskName.Text = "今日のタスクはすべて完了しました";
                }

                TextNextTime.Text = String.Empty;
                ButtonCompleted.IsEnabled = false;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;

            if (isSettingsValid())
            {
                loadConfFile();

                TodayroutineList = new List<RoutineTask>() { };

                String bathtime = TimePickerBath.Text;
                String birthdate = DatePickerBirthday.Text;
                String wakeuptime = TimePickerWakeUp.Text;
                String language = String.Empty;

                if (RadioButtonEn.IsChecked == true)
                {
                    language = "EN";
                    uitoEN();
                }
                else
                {
                    language = "JP";
                    uitoJP();
                }

                Boolean bath = false;

                if (CheckBoxBath.IsChecked == true)
                {
                    bath = true;
                    bathtime = "01.01.2020 " + bathtime + ":00";
                }
                else
                {
                    bathtime = "01.01.2020 00:00:00";
                }  

                int age = DaysAge(Convert.ToDateTime(birthdate));

                // Save file related code
                string filename = "save.txt";

                if (!File.Exists(filename))
                {
                    File.WriteAllText(filename, String.Empty);
                }

                var lines = File.ReadAllLines(filename);

                if (isSaveValid() && (lines.Length > 0) && (lines[0].Substring(0, 10) == DateTime.Now.ToString().Substring(0, 10)))
                {
                    String taskName = String.Empty;
                    String wakeupTime = String.Empty;
                    String completed = String.Empty;

                    for (int i = 1; i < lines.Length; i = i + 3)
                    {
                        taskName = lines[i];
                        wakeupTime = lines[i + 1];
                        completed = lines[i + 2];
                        TodayroutineList.Add(new RoutineTask(taskName, wakeupTime, completed));
                    }
                }
                else
                {
                    TodayroutineList = Routine(age, Convert.ToDateTime("01.01.2020 " + wakeuptime + ":00"), Convert.ToDateTime(bathtime), language, bath);
                    createSaveFile(TodayroutineList);
                }

                DataContext = this;

                timer.Start();
            }
            // If no configuration file exists, redirects the user to settings screen
            else
            {
                GridAbout.Visibility = Visibility.Hidden;
                GridSettings.Visibility = Visibility.Visible;
                GridToday.Visibility = Visibility.Hidden;
                GridNext.Visibility = Visibility.Hidden;
                GridHome.Visibility = Visibility.Hidden;
            }

        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            if (isSettingsValid() == true)
            {
                GridAbout.Visibility = Visibility.Visible;
                GridSettings.Visibility = Visibility.Hidden;
                GridToday.Visibility = Visibility.Hidden;
                GridNext.Visibility = Visibility.Hidden;
                GridHome.Visibility = Visibility.Hidden;
            }
            else
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Please configure settings first", "Settings needed");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定してください", "設定");
                }
            }
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            GridAbout.Visibility = Visibility.Hidden;
            GridSettings.Visibility = Visibility.Visible;
            GridToday.Visibility = Visibility.Hidden;
            GridNext.Visibility = Visibility.Hidden;
            GridHome.Visibility = Visibility.Hidden;
        }

        private void ButtonToday_Click(object sender, RoutedEventArgs e)
        {
            if (isSettingsValid() == true)
            {
                GridAbout.Visibility = Visibility.Hidden;
                GridSettings.Visibility = Visibility.Hidden;
                GridToday.Visibility = Visibility.Visible;
                GridNext.Visibility = Visibility.Hidden;
                GridHome.Visibility = Visibility.Hidden;
            }
            else
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Please configure settings first", "Settings needed");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定してください", "設定");
                }
            }
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            if (isSettingsValid() == true)
            {
                GridAbout.Visibility = Visibility.Hidden;
                GridSettings.Visibility = Visibility.Hidden;
                GridToday.Visibility = Visibility.Hidden;
                GridNext.Visibility = Visibility.Visible;
                GridHome.Visibility = Visibility.Hidden;
            }
            else
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Please configure settings first", "Settings needed");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定してください", "設定");
                }
            }
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            if (isSettingsValid() == true)
            {
                GridAbout.Visibility = Visibility.Hidden;
                GridSettings.Visibility = Visibility.Hidden;
                GridToday.Visibility = Visibility.Hidden;
                GridNext.Visibility = Visibility.Hidden;
                GridHome.Visibility = Visibility.Visible;
            }
            else
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Please configure settings first", "Settings needed");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定してください", "設定");
                }
            }
        }

        private void ButtonSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            string filename = "config.txt";
            string fileContent = String.Empty;
            Boolean isValid = true;

            if (!String.IsNullOrEmpty(DatePickerBirthday.Text))
                fileContent = fileContent + DatePickerBirthday.ToString() + Environment.NewLine;
            else
                isValid = false;

            if (!String.IsNullOrEmpty(TimePickerWakeUp.Text))
                fileContent = fileContent + TimePickerWakeUp.Text + Environment.NewLine;
            else
                isValid = false;

            if (CheckBoxBath.IsChecked == true)
            {
                fileContent = fileContent + "true" + Environment.NewLine;
                if (!String.IsNullOrEmpty(TimePickerBath.Text))
                    fileContent = fileContent + TimePickerBath.Text + Environment.NewLine;
                else
                    isValid = false;
            }
            else
                fileContent = fileContent + "false" + Environment.NewLine;

            if (RadioButtonEn.IsChecked == true)
                fileContent = fileContent + "EN" + Environment.NewLine;
            else
                fileContent = fileContent + "JP" + Environment.NewLine;

            if (isValid)
            {
                File.WriteAllText(filename, fileContent);
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Settings saved", "Settings");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定が保存されました", "設定");
                }

                //Whenever settings are changed, save file must be deleted to create a new schedule based on current configuarion and application restarts
                string save_filename = "save.txt";
                if (File.Exists(save_filename))
                    File.Delete(save_filename);

                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
            else
            {
                if (RadioButtonEn.IsChecked == true)
                {
                    MessageBoxResult result = MessageBox.Show("Please configure　all settings first", "Error");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("設定を完了してください", "エラー");
                }
            }
        }

        private void ButtonCompleted_Click(object sender, RoutedEventArgs e)
        {
            foreach (RoutineTask routine in TodayroutineList)
            {
                string now = DateTime.Today.ToString().Substring(0, 11) + DateTime.Now.ToString("HH:mm");
                string routineTime = DateTime.Today.ToString().Substring(0, 11) + routine.Time;

                if ((routine.Completed == "No" || routine.Completed == "x") && (DateTime.Parse(now).CompareTo(DateTime.Parse(routineTime)) > -1))
                {
                    TextCurrentTaskName.Text = routine.TaskName;

                    if (RadioButtonEn.IsChecked == true)
                        routine.Completed = "Yes";
                    else
                        routine.Completed = "✓";

                    ListToday.Items.Refresh();
                    createSaveFile(TodayroutineList);
                    break;
                }
            }
        }

        private void RadioButtonEn_Click(object sender, RoutedEventArgs e)
        {
            uitoEN();
        }

        private void RadioButtonJp_Click(object sender, RoutedEventArgs e)
        {
            uitoJP();
        }

        private void AppTitle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
