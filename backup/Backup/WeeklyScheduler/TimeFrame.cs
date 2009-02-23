using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyScheduler
{
    [Serializable()]
    public class TimeFrame:IComparable
    {
        public TimeFrame()
        {
            _startTime = new WeeklyTime();
            _endTime = new WeeklyTime();
        }

        public TimeFrame(WeeklyTime start, WeeklyTime end)
        {
            _startTime = start;
            _endTime = end;
        }

        public TimeFrame DeepClone()
        {
            return new TimeFrame(_startTime.DeepClone(), _endTime.DeepClone());
        }

        private WeeklyTime _startTime;

        public WeeklyTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        private WeeklyTime _endTime;

        public WeeklyTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
	    
        // 1  1.5  2  2.5  3  3.5  4
        // |-----------|
        //           |------------|
        public bool DoesOverlap(TimeFrame otherTimeFrame)
        {
            if (_startTime.GetTickNumber() <= otherTimeFrame._startTime.GetTickNumber())
            {
                if (_endTime.GetTickNumber() >= otherTimeFrame._startTime.GetTickNumber())
                {
                    return true;
                }
            }

            if (_startTime.GetTickNumber() <= otherTimeFrame._endTime.GetTickNumber())
            {
                if (_endTime.GetTickNumber() >= otherTimeFrame._endTime.GetTickNumber())
                {
                    return true;
                }
            }

            if (otherTimeFrame._startTime.GetTickNumber() <= _startTime.GetTickNumber())
            {
                if (otherTimeFrame._endTime.GetTickNumber() >= _startTime.GetTickNumber())
                {
                    return true;
                }
            }

            if (otherTimeFrame._startTime.GetTickNumber() <= _endTime.GetTickNumber())
            {
                if (otherTimeFrame._endTime.GetTickNumber() >= _endTime.GetTickNumber())
                {
                    return true;
                }
            }

            return false;
        }


        #region IComparable Members

        int IComparable.CompareTo(object obj)
        {
            TimeFrame tf = (TimeFrame)obj;
            return this.StartTime.GetTickNumber().CompareTo(tf.StartTime.GetTickNumber());
        }

        #endregion
    }
    [Serializable()]
    public class WeeklyTime
    {
        public WeeklyTime()
        {
            _Day = DayOfWeek.Monday;
            _hour = 0;
            _minute = 0;
        }

        public WeeklyTime(DayOfWeek d, int h, int m)
        {
            _Day = d;
            _hour = h;
            _minute = m;
        }

        public WeeklyTime DeepClone()
        {
            return new WeeklyTime(_Day, _hour, _minute);
        }

        private DayOfWeek _Day;

        public DayOfWeek Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        private int _hour;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value <= 23 && value >= 0)
                {
                    _hour = value;
                }
                else
                {
                    throw new Exception("Out of range error. Hour must be < 23 and > 0");   
                }
            }
        }

        private int _minute;

        public int Minute
        {
            get { return _minute; }
            set 
            {
                if (value <= 59 && value >= 0)
                {
                    _minute = value;
                }
                else
                {
                    throw new Exception("Out of range. Minute must be >= 0 and <= 59");
                }
            }
        }

        public int GetTickNumber()
        {
            //1 min  == 1 tick
            //1 hour == 60 ticks
            //1 day  == 1440 ticks
            return _minute + _hour * 60 + getDoWNumber(_Day) * 1440;
        }
        
        private int getDoWNumber(DayOfWeek d)
        {
            switch (d)
            {
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                default:
                    return 0;
            }
        }

        public override string ToString()
        {
            return _Day.ToString() + " at " + _hour.ToString() + ":" + _minute.ToString();
        }
	
	
    }
}
