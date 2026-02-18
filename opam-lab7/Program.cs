class BankTerminal
{
    public event Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        OnMoneyWithdraw?.Invoke(amount);
    }
}

class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += amount =>
        {
            Console.WriteLine($"Знято {amount} грн");
        };

        terminal.Withdraw(500);

        terminal.OnMoneyWithdraw = null;
        terminal.OnMoneyWithdraw.Invoke(1000);
    }
}
