using System;

public class Program 
{
    /*Part of the meaning of the word encapsulation is the idea of "surrounding" an entity, not just to keep what's inside together, but also to protect it.
    C# supports the following access modifiers: public, private, protected, internal, protected internal.
    */
    class BankAccount {
        private double balance = 0;
        public void Deposit(double n) {
            balance += n;
        }
        public void Withdraw(double n) {
            balance -= n;
        }
        public double GetBalance() {
            return balance;
        }
    }
    static void Main()
    {
            /*
                We used encapsulation to hide the balance member from the outside code. Then we provided restricted access to it using public methods. The class data can be read through the GetBalance method and modified only through the Deposit and Withdraw methods
            */
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine(b.GetBalance()); // 157
    }
}