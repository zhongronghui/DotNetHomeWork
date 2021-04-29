using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    
    class Program
    {

        static void Main(string[] args)
        {

            MainClock.MyClock myClock = new MainClock.MyClock(10, 30,50);   //设置时间
            myClock.myClock.SetClock(10, 31,0);     //设置闹钟；
            myClock.myClock.RunTime();

        }
    }
}
