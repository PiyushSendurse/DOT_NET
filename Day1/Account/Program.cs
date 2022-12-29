// See https://aka.ms/new-console-template for more information
using Banking;

Account account=new Account();
account.Deposit(2000);
Console.WriteLine(account.GetBalance());

