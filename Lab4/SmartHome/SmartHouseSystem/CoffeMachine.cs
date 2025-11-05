namespace SmartHouseSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int PowerConsumption { get; set; } = 1000;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (IsOn)
            {   
                return (PowerConsumption * hours) / 1000.0;
            }
            return 0;
        }

    }
}
