namespace HouseSystem
{
    public interface IEnergyConsumer
    {
        string DeviceName { get; }
        int PowerConsumption { get; }
        bool IsOn { get; }
        int GetEnergyUsage(int hours);
    }
}