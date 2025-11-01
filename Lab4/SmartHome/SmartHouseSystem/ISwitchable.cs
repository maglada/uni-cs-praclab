namespace HouseSystem
{
    public interface ISwitchable
    {
        bool IsOn { get; }
        void TurnOn();
        void TurnOff();
    }
}