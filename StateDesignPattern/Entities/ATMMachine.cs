using StateDesignPattern.Interfaces;
using StateDesignPattern.States;

namespace StateDesignPattern.Entities;

public class ATMMachine
{
    public IATMState AtmMachineState { get; private set; }
    public ATMMachine()
    {
        AtmMachineState = new DebitCardNotInsertedState();
    }

    public void SetState(IATMState newState)
    {
        AtmMachineState = newState;
        Console.WriteLine($"ATM Machine internal state has been changed to: {newState.GetType().Name}");
    }

    public void InsertDebitCard()
    {
        AtmMachineState.InsertDebitCard(this);
    }

    public void EjectDebitCard()
    {
        AtmMachineState.EjectDebitCard(this);
    }

    public void EnterPin()
    {
        AtmMachineState.EnterPin(this);
    }

    public void WithdrawMoney()
    {
        AtmMachineState.WithdrawMoney(this);
    }
}