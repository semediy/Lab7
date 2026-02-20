class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();
        terminal.Withdraw(500);

        terminal.OnMoneyWithdraw = null;

        terminal.Withdraw(1000);

        terminal.OnMoneyWithdraw += amount =>
            Console.WriteLine($"Повідомлення: знято {amount} грн");
        terminal.OnMoneyWithdraw?.Invoke(99999);
    }
    
}
