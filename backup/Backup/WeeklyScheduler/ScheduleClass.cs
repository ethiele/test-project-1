using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WeeklyScheduler
{
    [Serializable()]
    public class ScheduleClass
    {
        public int Sch;
        public int Subject;
        public int Index;
        public String Title;
        public int Credits;
        public List<ClassSection> Sections = new List<ClassSection>();
    }

    [Serializable()]
    public class ClassSection
    {
        public ScheduleClass parentClass;
        public string Section;
        public string RegistrationIndex;
        public List<TimeFrame> Times = new List<TimeFrame>();
    }
}
