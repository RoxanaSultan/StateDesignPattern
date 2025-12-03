using NoStateDesignPattern.Entities;

namespace NoStateDesignPattern;

public static class Application
{
    public static void Run()
    {
        var atmMachine = new ATMMachine();

        Console.WriteLine("ATM Machine Current state : DebitCardNotInserted");
        Console.WriteLine();

        atmMachine.EnterPin();
        atmMachine.WithdrawMoney();
        atmMachine.EjectDebitCard();
        atmMachine.InsertDebitCard();
        Console.WriteLine();

        Console.WriteLine("ATM Machine Current state : DebitCardInserted");
        Console.WriteLine();

        atmMachine.EnterPin();
        atmMachine.WithdrawMoney();
        atmMachine.InsertDebitCard();
        atmMachine.EjectDebitCard();
        Console.WriteLine();

        Console.WriteLine("ATM Machine Current state : DebitCardNotInserted");
        Console.Read();
    }
}