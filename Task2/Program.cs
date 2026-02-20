class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += amount =>
            Console.WriteLine($"Повідомлення: знято {amount} грн");
        terminal.OnMoneyWithdraw?.Invoke(99999);
    }
}