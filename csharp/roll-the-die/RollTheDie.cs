public class Player
{
    public int RollDie()
    {
        return new System.Random().Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        return new System.Random().NextDouble() * 100;
    }
}
