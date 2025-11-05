namespace SmartHouseSystem
{
    public interface ISwitchable
    {
        bool IsOn { get; }
        void TurnOn();
        void TurnOff();
    }
}