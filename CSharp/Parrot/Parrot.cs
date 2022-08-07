using System;

namespace Parrot;

public abstract class Parrot
{
    protected double LoadFactor { get; } = 9.0;
    
    public abstract double GetSpeed();
    protected double GetBaseSpeed() => 12.0;
    protected double GetBaseSpeed(double voltage) => Math.Min(24.0, GetBaseSpeed() * voltage);
}
