class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[]{0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[birdsPerDay.Length -1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length -1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(var n in birdsPerDay ){
            if(n == 0){
                return true;
                break;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {  int count = 0;
       for(int i = 0; i < numberOfDays; i++){
           count = count + birdsPerDay[i];
       }
         return count;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach(var n in birdsPerDay ){
            if(n >= 5)
                busyDays++;
        }
        return busyDays;
    }
}
