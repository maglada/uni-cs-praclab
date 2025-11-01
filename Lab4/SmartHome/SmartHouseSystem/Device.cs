using System;

namespace HouseSystem
{
    abstract class Device
    {
        public string Name { get; set; }
        public bool IsOn { get; protected set; }
        public abstract void TurnOn();
        public abstract void TurnOff();

        public void PrintStatus()
        {
            Console.WriteLine($"{Name}: увімкнено” або “{Name}: вимкнено");
        }
    }
}