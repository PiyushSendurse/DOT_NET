namespace Delegate;
public class Account{
    public string Name{get;set;}
    public double Balance{get;set;}

    public Account(string name,double amount){
        this.Name=name;
        this.Balance=amount;
    }
    public void Deposit(double amount){
        this.Balance+=amount;
    }
    public void Withdraw(double amount){
        this.Balance-=amount;
    }
    public override string ToString()
    {
        return base.ToString() + this.Name + " has current Balance ="+ this.Balance;
    }
    public void ProcessTax(){
        if(this.Balance>=250000){

        }
    }
}
