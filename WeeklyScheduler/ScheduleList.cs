using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyScheduler
{
    public class ScheduleList:IComparable
    {
        public List<ClassSection> classes = new List<ClassSection>();

        public List<ClassSection> DoesClassConflict(ClassSection sc)
        {
            Dictionary<string, ClassSection> conflictList = new Dictionary<string, ClassSection>();
            List<ClassSection> ListOfConflicts = new List<ClassSection>();
            foreach (ClassSection c in classes)
            {
                foreach (TimeFrame newTimes in sc.Times)
                {
                    foreach (TimeFrame oldTimes in c.Times)
                    {
                        if (newTimes.DoesOverlap(oldTimes))
                        {
                            if (!conflictList.ContainsKey(c.parentClass.Index.ToString() + ":" + c.parentClass.Subject.ToString()))
                            {
                                conflictList.Add(c.parentClass.Index.ToString() + ":" + c.parentClass.Subject.ToString(), c);
                                ListOfConflicts.Add(c);
                            }
                        }
                    }
                }
            }
            return ListOfConflicts;
            
        }

        public ClassSection GetClassAtTime(WeeklyTime wt)
        {
            foreach (ClassSection cs in classes)
            {
                if (cs.DoesOverlap(new TimeFrame(wt, wt)))
                {
                    return cs;
                }
            }
            return null;
        }

        public int getCredits()
        {
            int cred = 0;
            foreach (ClassSection c in classes)
            {
                cred += c.parentClass.Credits;
            }
            return cred;
        }


        #region IComparable Members

        public string computeHash()
        {
            StringBuilder sb = new StringBuilder();
 
            foreach (ClassSection cs in classes)
            {
                sb.Append(cs.parentClass.Index.ToString());
                sb.Append(":");
                sb.Append(cs.parentClass.Subject.ToString());
                sb.Append(",");
                sb.Append(cs.Section);
                sb.Append(";");
            }
            return sb.ToString();
        }

        public int CompareTo(object obj)
        {
            ScheduleList sl2 = (ScheduleList)obj;
            if (sl2.computeHash() == this.computeHash())
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        #endregion
    }
}
