using System;

namespace Parrot;

public class African : Parrot
{
    private readonly int _numberOfCoconuts;

    public African(int numberOfCoconuts)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public override double GetSpeed() => Math.Max(0, GetBaseSpeed() - LoadFactor * _numberOfCoconuts);
}
