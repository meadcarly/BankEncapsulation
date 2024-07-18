namespace BankEncapsulation;
//A private field of type double named balance with a value of 0
// Define a method named Deposit that will accept a double and store that value in the balance field
// Define a method named GetBalance that will return the amount stored in the balance field
public class BankAccount
{
    private double _balance = 0;

    public double Deposit(double depositAmount)
    {
        _balance += depositAmount;
        Console.WriteLine($"You deposited ${depositAmount} successfully.");
        return _balance;
    }

    public double GetBalance()
    {
        return _balance;
    }
}