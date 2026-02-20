using System;

public class BankTerminal
{
    public event  Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Знято {amount} грн");
        OnMoneyWithdraw?.Invoke(amount);
        
    }
}