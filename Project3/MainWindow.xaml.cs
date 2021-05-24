using System;
using System.Collections.Generic;
using System.IO;
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
using Schedule;

namespace Project3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string filePath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Teams.csv";

        static int countLines = GetCount(filePath); //get quantity of lines in file for length of array

        Team[] team = GetTeam(filePath, countLines);

        public MainWindow()
        {
            InitializeComponent();




        }

         string chosen;

        //string ScheduleFile = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Schedule.csv";
        string Week1 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week1.txt";
        string Week2 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week2.txt";
        string Week3 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week3.txt";
        string Week4 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week4.txt";
        string Week5 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week5.txt";
        string Week6 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week6.txt";
        string Week7 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week7.txt";
        string Week8 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week8.txt";
        string Week9 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week9.txt";
        string Week10 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week10.txt";
        string Week11 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week11.txt";
        string Week12 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week12.txt";
        string Week13 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week13.txt";
        string Week14 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week14.txt";
        string Week15 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week15.txt";
        string Week16 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week16.txt";
        string Week17 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week17.txt";
        string Week18 = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Week18.txt";



        private void cboConference_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void cboTeam_Loaded(object sender, RoutedEventArgs e)
        {


            

        }

        private void cboConference_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem chosenItem = (ComboBoxItem)cboConference.SelectedItem;
            chosen = chosenItem.Content.ToString();
            cboTeam.Items.Clear();
            addTeams(chosen, cboTeam);
        }

        public static void addTeams(string chosen, ComboBox cboTeam)
        {
            //MessageBox.Show(chosen);

            if (chosen.ToUpper() == "AFC WEST")
            {
                cboTeam.Items.Add("Denver Broncos");
                cboTeam.Items.Add("Kansas City Chiefs");
                cboTeam.Items.Add("Las Vegas Raiders");
                cboTeam.Items.Add("Los Angeles Raiders");
            }

            else if (chosen.ToUpper() == "AFC EAST")
            {
                cboTeam.Items.Add("Buffalo Bills");
                cboTeam.Items.Add("Miami Dolphins");
                cboTeam.Items.Add("New England Patroits");
                cboTeam.Items.Add("New York Jets");
            }
            
            else if (chosen.ToUpper() == "AFC SOUTH")
            {
                cboTeam.Items.Add("Houston Texans");
                cboTeam.Items.Add("IndianaPolis Colts");
                cboTeam.Items.Add("Jacksonville Jaguars");
                cboTeam.Items.Add("Tennessee Titans");
            }
            
            else if (chosen.ToUpper() == "AFC NORTH")
            {
                cboTeam.Items.Add("Baltimore Ravens");
                cboTeam.Items.Add("Cincinnati Bengals");
                cboTeam.Items.Add("Cleveland Browns");
                cboTeam.Items.Add("Pittsburgh Steelers");
            } 
            
            else if (chosen.ToUpper() == "NFC WEST")
            {
                cboTeam.Items.Add("Arizona Cardinals");
                cboTeam.Items.Add("Los Angeles Rams");
                cboTeam.Items.Add("San Francisco 49ers");
                cboTeam.Items.Add("Seattle Seahawks");
            }
            
            else if (chosen.ToUpper() == "NFC EAST")
            {
                cboTeam.Items.Add("Dallas Cowboys");
                cboTeam.Items.Add("New York Giants");
                cboTeam.Items.Add("Philadelphia Eagles");
                cboTeam.Items.Add("Washington Football Team");
            }
            
            else if (chosen.ToUpper() == "NFC SOUTH")
            {
                cboTeam.Items.Add("Atlanta Falcons");
                cboTeam.Items.Add("Carolina Panthers");
                cboTeam.Items.Add("New Orleans Saints");
                cboTeam.Items.Add("Tampa Bay Buccaneers");
            }
            else 
            {
                cboTeam.Items.Add("Chicago Bears");
                cboTeam.Items.Add("Detroit Lions");
                cboTeam.Items.Add("Green Bay Packers");
                cboTeam.Items.Add("Minnesota Vikings");
            }



        }// addTeam

        private void cboTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //string teamName = cboTeam.SelectedItem.ToString();

            //MessageBox.Show(teamName);
        }

        private void cboSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem chosenItem = (ComboBoxItem)cboSchedule.SelectedItem;
            string weekSchedule = chosenItem.Content.ToString();
            


            //MessageBox.Show(weekSchedule);

            if (weekSchedule == "Week1")
            {
                string week1Schedule = getSchedule(Week1);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week1Schedule);
            }
            else if (weekSchedule == "Week2")
            {
                string week2Schedule = getSchedule(Week2);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week2Schedule);
               
            }
            else if (weekSchedule == "Week3")
            {
                string week3Schedule = getSchedule(Week3);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week3Schedule);
            }
            else if (weekSchedule == "Week4")
            {
                string week4Schedule = getSchedule(Week4);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week4Schedule);
            }
            else if (weekSchedule == "Week5")
            {
                string week5Schedule = getSchedule(Week5);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week5Schedule);
            } 
            else if (weekSchedule == "Week6")
            {
                string week6Schedule = getSchedule(Week6);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week6Schedule);
            }
            else if (weekSchedule == "Week7")
            {
                string week7Schedule = getSchedule(Week7);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week7Schedule);
            }
            else if (weekSchedule == "Week8")
            {
                string week8Schedule = getSchedule(Week8);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week8Schedule);
            }
            else if (weekSchedule == "Week9")
            {
                string week9Schedule = getSchedule(Week9);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week9Schedule);
            }
            else if (weekSchedule == "Week10")
            {
                string week10Schedule = getSchedule(Week10);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week10Schedule);
            }
            else if (weekSchedule == "Week11")
            {
                string week11Schedule = getSchedule(Week11);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week11Schedule);
            }
            else if (weekSchedule == "Week12")
            {
                string week12Schedule = getSchedule(Week12);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week12Schedule);
            }
            else if (weekSchedule == "Week13")
            {
                string week13Schedule = getSchedule(Week13);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week13Schedule);
            }

            else if (weekSchedule == "Week14")
            {
                string week14Schedule = getSchedule(Week14);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week14Schedule);
            }

            else if (weekSchedule == "Week15")
            {
                string week15Schedule = getSchedule(Week15);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week15Schedule);
            }

            else if (weekSchedule == "Week16")
            {
                string week16Schedule = getSchedule(Week16);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week16Schedule);
            }
            else if (weekSchedule == "Week17")
            {
                string week17Schedule = getSchedule(Week17);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week17Schedule);
            }

            else
            {
                string week18Schedule = getSchedule(Week18);
                ScheduleBox.Items.Clear();
                ScheduleBox.Items.Add(week18Schedule);
            }
        }


        public string getSchedule(string textFile)
        {
            string result = "";
            if (File.Exists(textFile))
            {
                //Read text line by line
                string[] texts = File.ReadAllLines(textFile);
                foreach (string text in texts)
                    result += $"{text}\r\n";
            }


            return result;

        }// get schedule

        static Team[] GetTeam(string filePath, int count)
        {
            string strRead; //holds line that is read

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readerTeam = new StreamReader(fs);

            strRead = readerTeam.ReadLine();  //first read the header - not doing anything with it

            Team[] teamCreate = new Team[count];

            for (int counter = 1; counter < count; ++counter) //header has already been read
            {
                strRead = readerTeam.ReadLine();  //read the whole line
                //MessageBox.Show(strRead);   // to test
                string[] Parts = strRead.Split(',');  //each element = a field value of that prez

               teamCreate[counter] = new Team();

               
                //MessageBox.Show(prez[counter].Number.ToString());   //to test

                teamCreate[counter].Name = Parts[1];
                teamCreate[counter].HeadCoach = Parts[2];
                teamCreate[counter].Stadium = Parts[3];
                //MessageBox.Show(prez[counter].Last);  //to test

                teamCreate[counter].Owners = Parts[4];
                teamCreate[counter].yearEstablished = Parts[5];
                

            } //for

            readerTeam.Close();
            fs.Close();

            return teamCreate;
        }// getTeams

        static int GetCount(string file)
        {
            int count = 0;
            string strRead;
            FileStream sr = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader readerCount = new StreamReader(sr);

            strRead = readerCount.ReadLine();  //read the header
                                               //header is not part of the count
            while (strRead != null)
            {
                ++count;
                strRead = readerCount.ReadLine(); //read the next line
            }

            readerCount.Close();
            sr.Close();

            return count;
        }//GetCount

        private void btnTeam_Click(object sender, RoutedEventArgs e)
        {
            MakeVisible(TeamInfoBox);
            MakeVisible(ScheduleBox);
            string teamName = cboTeam.SelectedItem.ToString();
            string message = $"The Selected team is {teamName} \n";


            var queryResults = from p in team
                               where p?.Name == teamName
                               select p;


            foreach(var name in queryResults)
            {

                //message += $"The name of the Head coach is {name.HeadCoach} \n The Stadium is {name.Stadium} \n ";
                //TeamInfoBox.Items.Add(message);

                TeamInfoBox.Items.Add(new Team()
                {
                    Name = name.Name,
                    HeadCoach = name.HeadCoach,
                    Stadium = name.Stadium,
                    Owners = name.Owners,
                    yearEstablished = name.yearEstablished
                });

            }
            //MessageBox.Show(message);
        }//

        private void TeamInfoBox_Loaded(object sender, RoutedEventArgs e)
        {
            TeamInfoBox.Visibility = Visibility.Hidden;
        }

        static void MakeVisible(ListView box)
        {
            if(box.Visibility == Visibility.Hidden)
            {
                box.Visibility = Visibility.Visible;
            }
        }

        private void ScheduleBox_Loaded(object sender, RoutedEventArgs e)
        {
            ScheduleBox.Visibility = Visibility.Hidden;
        }
    }
}
