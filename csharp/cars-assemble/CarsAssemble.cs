static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed) {
            case 0:
                return 0;
            case int s when s >= 1 && s <= 4:
                return 1;
            case int s when s > 4 && s <= 8:
                return 0.9;
                break;
            case 9 :
                return 0.8;
            case 10 :
                return 0.77;
        }
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
       return (int)ProductionRatePerHour(speed) / 60;
    }
}
