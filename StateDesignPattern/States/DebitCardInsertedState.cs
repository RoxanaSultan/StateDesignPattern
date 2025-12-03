using StateDesignPattern.Entities;
using StateDesignPattern.Interfaces;

namespace StateDesignPattern.States;

public class DebitCardInsertedState : IATMState
{
    public void InsertDebitCard(ATMMachine atmMachine)
    {
        Console.WriteLine("You cannot insert a card - there is already a card inserted.");
    }

    public void EjectDebitCard(ATMMachine atmMachine)
    {
        Console.WriteLine("Debit Card ejected successfully.");
        atmMachine.SetState(new DebitCardNotInsertedState());
    }

    public void EnterPin(ATMMachine atmMachine)
    {
        Console.WriteLine("Pin number entered successfully");
    }

    public void WithdrawMoney(ATMMachine atmMachine)
    {
        Console.WriteLine("Money withdrawn successfully.");
    }
}