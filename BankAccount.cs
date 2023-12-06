class BankAccount{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber){
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    public void Deposit(decimal amount){
        balance += amount;
    }

    public void Withdraw(decimal amount){
        if (amount <= balance){
            balance -= amount;
        }
        else{
            Console.WriteLine("Insufficent Amount.");
        }
    }

    public decimal GetBalance(){
        return balance;
    }
}

//class Program
//{
//    static void Main()
//    {
//        BankAccount myAccount = new BankAccount("69 Hari");
//        myAccount.Deposit(1000);
//        myAccount.Withdraw(500);

//        Console.WriteLine("Final Balance: " + myAccount.GetBalance());
//    }
//}