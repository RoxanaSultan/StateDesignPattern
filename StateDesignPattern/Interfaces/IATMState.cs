using StateDesignPattern.Entities;

namespace StateDesignPattern.Interfaces;

public interface IATMState
{
    void InsertDebitCard(ATMMachine atmMachine);
    void EjectDebitCard(ATMMachine atmMachine);
    void EnterPin(ATMMachine atmMachine);
    void WithdrawMoney(ATMMachine atmMachine);
}
