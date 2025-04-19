static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch {
            < 0 => 3.213f,
            >= 0 and < 1_000 => 0.5f,
            >= 1_000 and < 5_000 => 1.621f,
            >= 5_000 => 2.475f
    };

    public static decimal Interest(decimal balance)
    {
      return balance * (decimal)InterestRate(balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (targetBalance >= balance ){
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
