using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class MainClock
    {
        public delegate void AlarmHandler(object sender, Time args);
        public delegate void TickHanlder(object sender, Time args);
        public class Time
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Second { get; set; }
        }
        public class Clock
        {
            private int hour, minute, second, aHour, aMinute, aSecond;
            public event AlarmHandler OnAlarm;
            public event TickHanlder OnTick;


            public Clock(int hour, int minute, int second)
            {
                if (hour < 24 && minute < 60 && second < 60)
                {
                    this.hour = hour;
                    this.minute = minute;
                    this.second = second;
                }
                else
                {
                    this.hour = this.minute = this.second = 0;
                }

            }
            public void SetClock(int hour, int minute, int second)
            {
                aHour = hour;
                aMinute = minute;
                aSecond = second;
            }
            public void RunTime()
            {
                while (true)
                {
                    if (this.second < 59) { this.second++; }
                    else
                    {
                        this.second = 0;
                        this.minute++;
                        if (this.minute == 60)
                        {
                            this.minute = 0;
                            this.hour++;
                        }
                    }
                    Time CurrentTime = new Time() { Hour = hour, Minute = minute, Second = second };
                    if (this.hour == this.aHour && this.minute == this.aMinute && this.second == this.aSecond)
                    {
                        OnAlarm(this, CurrentTime);
                    }
                    else
                    {
                        OnTick(this, CurrentTime);
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }
        public class MyClock
        {
            public Clock myClock;
            public MyClock(int hour, int minute, int second)
            {

                myClock = new Clock(hour, minute, second);
                myClock.OnTick  += OnTick;
                myClock.OnAlarm += OnAlarm;

            }
            public void OnTick(object sender, Time args)
            {
                Console.WriteLine("Tick!：" + args.Hour + ":" + args.Minute + ":" + args.Second + "");
            }
            public void OnAlarm(object sender, Time args)
            {
                Console.WriteLine("Alarm!：" + args.Hour + ":" + args.Minute + ":" + args.Second + "");
            }
        }
    }
}
