using System.Collections.Generic;

namespace SmartHouseSystem
{
    public class SmartHomeController

    {
        private List<ISwitchable> devices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            devices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (var device in devices)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double total = 0;

            foreach (var device in energyDevices)
            {
                double usage = device.GetEnergyUsage(hours);
                total += usage;
                Console.WriteLine($"{device.DeviceName}: {usage.ToString("F2", new System.Globalization.CultureInfo("uk-UA"))} кВт·год (потужність: {device.PowerConsumption} Вт)");

            }

            Console.WriteLine($"Загальне споживання: {total.ToString("F2", new System.Globalization.CultureInfo("uk-UA"))} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {(total * 4).ToString("F2", new System.Globalization.CultureInfo("uk-UA"))} грн");
        }
    }
}