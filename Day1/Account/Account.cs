namespace Banking;
public class Account {
    private float balance;

    //Default Constructor
    public Account(){
        this.balance=0;
    }

    //Parameterized Constructor
    public Account(float amount){
        this.balance=amount;
    }

    //Getter
    public float GetBalance(){
        return this.balance;
    }

    //Setter
    public void SetBalance(float amount){
        this.balance=amount;
    }

    //Deposit Function
    public void Deposit(float amount){
        this.balance+=amount;
    }

    //Withdraw Function
    public void Withdraw(float amount){
        if(amount==0){
            throw new Exception("Withdrawn Amount cananot be zero!!");
        }
        else if(balance==0){
            throw new Exception("Amount cannot withdraw from empty Account");
        }
        this.balance-=amount;
    }
}