class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();
        terminal.Withdraw(500);

        terminal.OnMoneyWithdraw += amount =>
            Console.WriteLine($"Повідомлення: знято {amount} грн");
    }
    
}
