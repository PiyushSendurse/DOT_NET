using School;
using System.Runtime.Serialization;
using System.Text.Json;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var contact= new {Contact = "Piyush - 9404053276"}; 
var students=new List<Student>();

students.Add(new Student(){Id=01, FirstName="Shamshuddin", LastName="Mallik", Email="sm@gmail.com",Phone="234324432"});
students.Add(new Student(){Id=02, FirstName="Mainuddin", LastName="Mallik", Email="mm@gmail.com",Phone="3284972387"});
students.Add(new Student(){Id=03, FirstName="Qutubuddin", LastName="Mallik", Email="qm@gmail.com",Phone="2349083294"});
students.Add(new Student(){Id=04, FirstName="Salma", LastName="Mallik", Email="sm@gmail.com",Phone="234i329324"});
students.Add(new Student(){Id=05, FirstName="Sucklenuddin", LastName="Mallik", Email="sm@gmail.com",Phone="32432324234"});

//Serialization 
var json=JsonSerializer.Serialize(students);
string sString=@"E:\C DAC\Module_7_DOTNET\DOT_NET\Day8\ECommerce\HelloWorldApp\piyushFile.json";
File.WriteAllText(sString,json);

//Desirialzation
string dString=File.ReadAllText(sString);
List<Student> dJson=JsonSerializer.Deserialize<List<Student>>(dString); //We have to specify the type in which we're gonna desrialize ex: <LIST<TYPE>>
foreach(Student stud in dJson) {
    Console.WriteLine(stud);
}

app.MapGet("/", () => "HaldiRam");
app.MapGet("/api/hello",() => "KurKure");
app.MapGet("/contact",() => contact);
app.MapGet("/pilantu",() => students);

app.Run();
