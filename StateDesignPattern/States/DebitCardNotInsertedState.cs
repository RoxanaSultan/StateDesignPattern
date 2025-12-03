using StateDesignPattern.Entities;
using StateDesignPattern.Interfaces;

namespace StateDesignPattern.States;

public class DebitCardNotInsertedState : IATMState
{
    public void InsertDebitCard(ATMMachine atmMachine)
    {
        Console.WriteLine("Debit card inserted successfully.");
        atmMachine.SetState(new DebitCardInsertedState());
    }
    public void EjectDebitCard(ATMMachine atmMachine)
    {
        Console.WriteLine("You cannot eject a card — there’s no card inserted.");
    }
    public void EnterPin(ATMMachine atmMachine)
    {
        Console.WriteLine("You cannot enter a PIN — there’s no card inserted.");
    }
    public void WithdrawMoney(ATMMachine atmMachine)
    {
        Console.WriteLine("You cannot withdraw money — there’s no card inserted.");
    }
}
