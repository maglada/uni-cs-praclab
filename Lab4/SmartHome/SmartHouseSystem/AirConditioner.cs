namespace HouseSystem
{
    public class AirConditioner : Device, IEnergyConsumer

    {
        public int PowerConsumption { get; set; } = 2000;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почав охолодження.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} зупинено.");
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