class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int currentMinutes) => ExpectedMinutesInOven() - currentMinutes;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutesOven) => PreparationTimeInMinutes(layers) + minutesOven;
}