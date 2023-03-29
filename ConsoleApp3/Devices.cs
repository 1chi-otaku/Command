using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TV
    {
        public void On() => Console.WriteLine("TV is on!");
        public void Off() => Console.WriteLine("TV is off!");
    }
    class Microwave
    {
        public void StartCooking (int time)
        {
            Console.WriteLine("\"Warming up food...");
            Thread.Sleep(time);
        }
        public void StopCooking() => Console.WriteLine("The food is warmed up");
    }
}
