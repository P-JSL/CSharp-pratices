namespace consoleApp_pratices;

public class thisKeyword
{
    
}

public class BankAccount
{
    private double money = 0;

    public void Deposit(double money)
    {
        this.money += money;
    }

    public void Withdraw(double money)
    {
        this.money -= money;
    }

    public double GetBalance()
    {
        return this.money;
    }
}