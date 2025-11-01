class MotionSensor : Device
{

    public MotionSensor(string name)
    {
        Name = name;
        IsOn = false;
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} активований.");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} деактивовано.");
    }
}