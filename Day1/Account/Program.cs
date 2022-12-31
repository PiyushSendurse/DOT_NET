// See https://aka.ms/new-console-template for more information
using Banking;
using System.Collections.Generic;

Account account=new Account();
account.Deposit(2000);
Console.WriteLine("Shumshuddin credited :"+account.GetBalance());

account.Withdraw(1500);
Console.WriteLine("Shumshuddin debited :"+1500);
Console.WriteLine("Shumshuddin current Balance :"+account.GetBalance());


Account account1=new Account();
account1.Deposit(6000);
Console.WriteLine("Mainuddin credited :"+account1.GetBalance());

account1.Withdraw(2000);
Console.WriteLine("Mainuddin debited :"+2000);
Console.WriteLine("Mainuddin current Balance :"+account1.GetBalance());

//Using Collections
List<Account> accounts=new List<Account>();
accounts.Add(account);
accounts.Add(account1);

foreach(Account theAccount in accounts){
    float bal=theAccount.GetBalance();
    Console.Write(bal+" ");
}


