namespace Parrot;

public class African : Parrot
{
    /// <summary>
    /// Cocount Weight
    /// </summary>
    private readonly double _loadFactor = 9.0;
    private readonly int _numberOfCoconuts;
    
    public African(int numberOfCoconuts)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public override double Speed => System.Math.Max(0, BaseSpeed - _loadFactor * _numberOfCoconuts);
}
