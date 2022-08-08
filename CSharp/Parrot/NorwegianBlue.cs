namespace Parrot;

public class NorwegianBlue : Parrot
{
    private readonly double _voltage;
    private readonly bool _isNailed;

    public NorwegianBlue(double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
    }

    public override double Speed => _isNailed ? 0.0 : System.Math.Min(24.0, BaseSpeed * _voltage);
}
