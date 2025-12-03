using NoStateDesignPattern.Enums;

namespace NoStateDesignPattern.Entities;

public class ATMMachine
{
    private State _state = State.DebitCardNotInserted;

    public void InsertDebitCard()
    {
        if (_state == State.DebitCardInserted)
        {
            Console.WriteLine("You cannot insert a card - there is already a card inserted.");
            return;
        }

        Console.WriteLine("Debit card inserted successfully.");
        _state = State.DebitCardInserted;
        Console.WriteLine($"ATM Machine internal state has been changed to : {_state}");
    }

    public void EjectDebitCard()
    {
        if (_state == State.DebitCardNotInserted)
        {
            Console.WriteLine("You cannot eject a card — there’s no card inserted.");
            return;
        }

        Console.WriteLine("Debit Card ejected.");
        _state = State.DebitCardNotInserted;
        Console.WriteLine($"ATM Machine internal state has been Changed to : {_state}");
    }

    public void EnterPin()
    {
        if (_state == State.DebitCardNotInserted)
        {
            Console.WriteLine("You cannot enter a PIN — there’s no card inserted.");
            return;
        }

        Console.WriteLine("Pin number entered successfully");
    }

    public void WithdrawMoney()
    {
        if (_state == State.DebitCardNotInserted)
        {
            Console.WriteLine("You cannot withdraw money — there’s no card inserted.");
            return;
        }

        Console.WriteLine("Money withdrawn successfully.");
    }
}
