namespace BOL;

[Serializable()]
public class Student {
    public int Id{get;set;}
    public string Name{get;set;}
    public DateTime Dob{get;set;}
    public string Branch{get;set;}
    public double Fees{get;set;}

    public Student(){
        this.Id=001;
        this.Name="Piyush";
        this.Dob=new DateTime(2000,11,20);
        this.Branch="PCM";
        this.Fees=100000;
    }
    public Student(int id, string name, DateTime dob, string branch, double fees) {
        this.Id=id;
        this.Name=name;
        this.Dob=dob;
        this.Branch=branch;
        this.Fees=fees;
    }
}
