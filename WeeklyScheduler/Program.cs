using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WeeklyScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Creating class and writing files...");
            //ScheduleClass sc = new ScheduleClass();
            //sc.Sch = 1;
            //sc.Index = 123;
            //sc.Subject = 332;
            //sc.Title = "Test class 1";
            //sc.Credits = 3;
            //sc.Times.Add(new TimeFrame(new WeeklyTime(DayOfWeek.Monday, 9, 20)
            //    , new WeeklyTime(DayOfWeek.Monday, 10, 30)));
            //sc.Times.Add(new TimeFrame(new WeeklyTime(DayOfWeek.Thursday, 9, 20)
            //    , new WeeklyTime(DayOfWeek.Thursday, 10, 30)));
            //BinaryFormatter bf = new BinaryFormatter();
            //System.IO.FileStream fs = new System.IO.FileStream("fs.bi", System.IO.FileMode.Create);
            //bf.Serialize(fs, sc);
            //fs.Close();

            //Console.WriteLine("Conducting file read test...");
            //sc = null;
            //fs = new System.IO.FileStream("fs.bi", System.IO.FileMode.Open);
            //sc = (ScheduleClass)bf.Deserialize(fs);
            //fs.Close();
            //Console.WriteLine("Start Hour" + sc.Times[0].StartTime.Hour.ToString());
            //Console.WriteLine("Done. Press any key to continue...");
            //Console.ReadLine();

            ScheduleMaster sm = new ScheduleMaster();
            while (1==1)
            {
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "makeclass":
                        sm.MakeClass();
                        break;
                    case "list":
                        sm.PrintClasses();
                        break;
                    case "listtitle":
                        sm.PrintClassTitles();
                        break;
                    case "saveclasslist":
                        sm.SaveClassList();
                        break;
                    case "loadclasslist":
                        sm.LoadClassList();
                        break;
                    case "scheduleclass":
                        sm.AddClass();
                        break;
                    case "viewschedule":
                        sm.ViewSchedule();
                        break;
                    case "unscheduleclass":
                        sm.UnscheduleClass();
                        break;
                    case "smartschedule":
                        sm.SmartScheduleClasses();
                        break;
                    case "smartscheduleex":
                        sm.AllSmartSchedules();
                        break;
                    case "sexyview":
                        sm.SexyViewSchedule();
                        break;
                    case "savelistxml":
                        sm.CommandSaveClassListXML();
                        break;
                    case "loadlistxml":
                        sm.CommandLoadXMLClassList();
                        break;
                    case "viewscheduleoptions":
                        sm.ViewScheduleOptions();
                        break;
                    case "smartschedulewitherror":
                        sm.AllSmartSchedulesWithError();
                        break;
                    case "savereginfo":
                        sm.CommandSaveRegistrationInfo();
                        break;
                    default:
                        Console.WriteLine("command not found");
                        break;
                }
            }
        }
    }
}
