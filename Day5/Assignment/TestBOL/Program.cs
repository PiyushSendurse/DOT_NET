
using BOL;
using System.Runtime.Serialization;
using System.Text.Json;

Student s1=new Student(002, "Anvesh",new DateTime(1999,09,27),"PCM",90000);
Student s2=new Student(003, "Aman",new DateTime(1997,01,26),"PCMB",110000);
Student s3=new Student(004, "Rutvik",new DateTime(1999,02,22),"PCM",95000);
Student s4=new Student(005, "Tejas",new DateTime(1997,02,13),"PCMB",97000);
Student s5=new Student();

// Console.WriteLine(s1.Id +" "+ s1.Name +" "+ s1.Dob +" "+ s1.Branch +" "+ s1.Fees);

List<Student> students=new List<Student>();
students.Add(s5);
students.Add(s1);
students.Add(s2);
students.Add(s3);
students.Add(s4);


bool exit=false;
while(!exit) {
    Console.WriteLine("Choose Options \n 1:Insert 2:Update 3.Delete 4.GetMyId 5.Get All");
    int choice=Convert.ToInt32(Console.ReadLine());

    switch(choice) {
        case 1:
        Console.WriteLine("Enter Student Details As :- ID, Name, Dob, Branch, Fees");
        int sid=Convert.ToInt32(Console.ReadLine());
        // DateTime sdob=new DateTime();
        string sname=Console.ReadLine();
        string sbranch=Console.ReadLine();
        // double sfees=Convert.ToDouble(get);
        Student newStudent=new Student(sid, sname, dob, sbranch, sfees);
        students.Add(newStudent);
        //Serialization of List?
        break;

        case 2:
        Console.WriteLine("Enter Student's ID");
        int roll=Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<students.Count; i++) {
            if(students.Id==roll)
        }
        break;

        case 3:
        break;

        case 4:
        break;

        case 5:
        break;
        
    }

}
// var json=JsonSerializer.Serialize(students);
// Console.WriteLine(json);