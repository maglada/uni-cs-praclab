namespace HouseSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public int PowerConsumption { get; set; } = 60;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} засвітилася.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} вимкнена.");
        }

        public int GetEnergyUsage(int hours)
        {
            if (IsOn)
            {
                return (PowerConsumption * hours) / 1000;
            }
            return 0;
        }
    }
}