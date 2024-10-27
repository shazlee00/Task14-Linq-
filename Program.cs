#region Q1
List<int> numbers = new List<int>() { 2,4,6,7,1,4,2,9,1}; 
var disNum= numbers.Select(x=>x).Distinct();
foreach(var num in disNum){
    System.Console.WriteLine(num);
 }
 System.Console.WriteLine("-----------------------------------------");
var mul= disNum.Select(x=>new{Number=x , Mul=x*x}).OrderBy(x=>x.Number);
foreach(var num in mul){
    System.Console.WriteLine(num);
 }
 System.Console.WriteLine("-----------------------------------------");
#endregion
#region Q2
string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };


var n3=names.Where(x=>x.Length==3);

foreach(var name in n3) System.Console.WriteLine(name);


System.Console.WriteLine("-----------------------------------------");

var n=names.Where(x=>x.ToLower().Contains('a')).OrderBy(x=>x.Length);

foreach(var name in n) System.Console.WriteLine(name);

System.Console.WriteLine("-----------------------------------------");
var n2 = names.Take(2);

foreach(var name in n2) System.Console.WriteLine(name);
#endregion


List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Mohammed",
                Subjects = new List<Subject>
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()
            {
                ID = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new List<Subject>
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 34, Name = "XML" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 3,
                FirstName = "Yara",
                LastName = "Yousf",
                Subjects = new List<Subject>
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Ali",
                Subjects = new List<Subject>
                {
                    new Subject() { Code = 33, Name = "UML" }
                }
            }
        };





var names= students.Select(x=>new{ Name=x.FirstName+' '+x.LastName , NumberOfSubjects=x.Subjects.Count }); 

foreach(var name in names) System.Console.WriteLine(name);


var oderNames=students.OrderByDescending(x=>x.FirstName).ThenBy(x=>x.LastName).Select(x=>new{Name=x.FirstName+' '+x.LastName});

foreach(var name in oderNames) System.Console.WriteLine(name);



public class Subject
{
    public int Code { get; set; }
    public string Name { get; set; }
}

public class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Subject> Subjects { get; set; }
}

