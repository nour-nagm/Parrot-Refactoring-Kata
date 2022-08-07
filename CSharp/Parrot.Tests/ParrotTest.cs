namespace Parrot.Tests;

public class ParrotTest
{
    [Fact]
    public void GetSpeedNorwegianBlueParrot_nailed()
    {
        Parrot parrot = new NorwegianBlue(voltage: 0, isNailed: true);

        Assert.Equal(0.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedNorwegianBlueParrot_not_nailed()
    {
        Parrot parrot = new NorwegianBlue(isNailed: false, voltage: 1.5);
        Assert.Equal(18.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
    {
        Parrot parrot = new NorwegianBlue(voltage: 4, isNailed: false);
        Assert.Equal(24.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfAfricanParrot_With_No_Coconuts()
    {
        Parrot parrot = new African(numberOfCoconuts: 0);
        Assert.Equal(12.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfAfricanParrot_With_One_Coconut()
    {
        Parrot parrot = new African(numberOfCoconuts: 1);
        Assert.Equal(3.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
    {
        Parrot parrot = new African(numberOfCoconuts: 2);
        Assert.Equal(0.0, parrot.GetSpeed());
    }

    [Fact]
    public void GetSpeedOfEuropeanParrot()
    {
        Parrot parrot = new European();
        Assert.Equal(12.0, parrot.GetSpeed());
    }
}