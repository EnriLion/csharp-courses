using Coursera_Csharp_Programming_Projects;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Let's learn C# Programming");

//string name = "King Kochhar";
int age = 23;
float discount = 1000.50F;
double contactNumber = 1234567890;
char gender = 'M';
Boolean isValid = true;

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Age: " + age);
//Console.WriteLine("Discount: " + discount);
//Console.WriteLine("Contact Number: " + contactNumber);
//Console.WriteLine("Gender: " + gender);
//Console.WriteLine("IsValid: " + isValid);

//OPERATORS AND OPERATORS PRECEDENCE

float baseSalary = 5000;
float hra = 0.30F;
float netSalary = (baseSalary - (baseSalary*hra));

Console.WriteLine("Base Salary: " + baseSalary);
Console.WriteLine("Net Salary: " + netSalary);

//OTHER OPERATORS

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its Very Cold Outside");
else
    Console.WriteLine("Its Moderate Outside");

//BOOL  OPERATOR AND CONDITIONALS

bool isloggedIn = false;
bool isEmailVerified = true;
bool cardInfo = true;

if (isloggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
    Console.WriteLine("Stop purchase");


//BOOL CONDITIONAL STATEMENTS

bool isAuthenticated = true;

if (isAuthenticated)
    Console.WriteLine("You are logged in");
else
    Console.WriteLine("You are not logged in");

//TERNARY OPERATION

string result1 = isAuthenticated ? "You are logged in." : "You are not logged in";
Console.WriteLine(result1);

//int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its Very Cold Outside");
else if (temperature >= 20 && temperature <= 50)
    Console.WriteLine("It's Moderate Outside");
else
    Console.WriteLine("It's too hot outside");

//SWITCH CASE
string userType = "admin";
switch (userType)
{
    case "admin":
        Console.WriteLine("You have full access");
        break;

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can create access the courses.");
        break;

    default:
        Console.WriteLine("You can create access the courses.");
        break;
}



string [] names = { "King Kochhar","Sarah Bowling", "John Smith", "James Lee" };

//int i = 1;   
int i = 100;
do
{
    Console.WriteLine("Hi");
    //Console.WriteLine(names[i]);
    i++;
    //while(i<names.Length); 
} while (i < 5);

Console.WriteLine();

// FOREACH used to array list and collections
// You can print array values in reverse order

foreach (string name in names) 
        Console.WriteLine(name);

Console.WriteLine();
// LOOPS

string[] cars = new string[5] {"Volvo", "BMW", "Ford", "Mazda", "Tesla"};


//for (int j = 0; j < 5; j++) // iterates all through the indexes to print the array
int j;
for (j = 0; j < names.Length; j++)
    Console.WriteLine(names[j]);

Console.WriteLine();

for (j = 4; j >= 0 ; j--)
    Console.WriteLine(cars[j]);

Console.WriteLine();

j = 0;
while (j < names.Length)
{
    Console.WriteLine(names[j]);
    j++;
}

//Jump Statements
//i = 0;
//for (i = 0; i <= 10; i++)
//{
//    if (i == 5) break;
//    Console.WriteLine("Hello World " + i);
//}

//Used of  continue

for (i = 0; i <= 10; i++)
{
    if (i == 5) continue;
    Console.WriteLine("Hello World " + i);
}

//Used of goto

userType = "admin";
switch (userType)
{
    case "admin":
        Console.WriteLine("You have full access");
        goto case "user";

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can create access the courses.");
        break;

    default:
        Console.WriteLine("You can create access the courses.");
        break;
}

//MANIPULATING ARRAYS

//SINGLE DIMENSION ARRAY

//int[] marks = new int[5];
int[] marks3 = new int[5] {45,56,65,67,78};
//marks[0] = 25;
//marks[1] = 50;
//marks[2] = 55;
//marks[3] = 60;
//marks[4] = 40;

foreach (int mark in marks3)
    Console.WriteLine(mark);

for (i = 0; i < marks3.Length; i++)
    Console.WriteLine(marks3[0]);


Console.WriteLine();

//MULTI DIMENSION ARRAY

int[,] multiArray = new int[3, 4]
{ { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} };


for (i = 0; i <=2; i++)
{
    for (j = 0; j <= 3; j++)
    {
        Console.Write(multiArray[i,j]+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

//JAGGED ARRAY

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];

//MANIPULATING STRINGS

string str1 = "Hello World";
string str2 = "C# Programming";

Console.WriteLine(str1);
Console.WriteLine(str1.Length);
string str3 = string.Concat(str1, str2);
Console.WriteLine(str3);
Console.WriteLine(str1.Equals(str2));


//Immutable strings

string s1 = "C# Programming";
string s2 = "Java Programming";

//Mutable strings

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("C# Programming");
stringBuilder.Append("Java Programming");

Console.WriteLine();

//OOP Classes and Objects

Student student = new Student();
/*student.acceptDetails();
*/
student.displayDetails();
//Console.WriteLine(student.studentId);

Console.WriteLine();

Student student1 = new Student(102, "Karthik");
student1.displayDetails();

Console.WriteLine();

//INHERITANCE


Marks marks = new Marks();
marks.acceptDetails();
marks.displayDetails();


Console.WriteLine();

//ABSTRACT CLASS
SavingAccount savingAccount = new SavingAccount(); //creating an instance
savingAccount.getMessage();
savingAccount.deposit();
savingAccount.withdraw();
savingAccount.balance();

Console.WriteLine();

//INTERFACE 

SavingAcc savingAcc = new SavingAcc(); //creating an instance
savingAcc.openAccount();
savingAcc.deposit();
savingAcc.withdraw();
savingAcc.balance();
savingAcc.closeAccount();

Console.WriteLine();

//INTERFACE 

Console.WriteLine(Calculate.count);
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());


Console.WriteLine(Calculate.decrement());
Console.WriteLine();

/*Demonstrating Extension Methods: */

int number = 100;

/*bool result = number.isGreaterThan(1000);*/
bool result = number.isGreaterThan(10);
Console.WriteLine(result);

Console.WriteLine();

/*Partial class  and Partial method*/

var employeee = new Employee();
Console.WriteLine(employeee.EmpId);
Console.WriteLine(employeee.EmpName);
employeee.DisplayDetails();

//make a constructor to initialize value

Console.WriteLine();

//Demonstrating Properties: //

User user = new User();
user.Name = "King Kochhar";
user.Age = 25;
//user.CompanyName = "kajdla"; can't be assigned due to is read only
/*Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);
Console.WriteLine(user.Age);
*/
Console.WriteLine();

/*Demonstrating Indexers:*/

StringIndexerType stringIndexerType = new StringIndexerType();
stringIndexerType[0] = "String One";
stringIndexerType[1] = "String Two";
stringIndexerType[2] = "String Three";
stringIndexerType[3] = "String Four";
stringIndexerType[4] = "String Five";
stringIndexerType[5] = "String Six";
stringIndexerType[6] = "String Seven";
stringIndexerType[7] = "String Eight";
stringIndexerType[8] = "String Nine";
stringIndexerType[9] = "String Ten";
/*stringIndexerType[10] = "String Four"; // Will throw an error due to the condition in StringIndexerType
*/
for (i = 0; i < 10; i++)
    Console.WriteLine(stringIndexerType[i]);

Console.WriteLine();
Console.WriteLine();

/*Demonstrating Enumations */

EnumDemo enumDemo = new EnumDemo();
enumDemo.display();

Console.WriteLine();

// coreAdvancedConcepts

Calculation calculation = new Calculation();
//calculation.calculate(100, 0);
calculation.calculateAnother();

Console.WriteLine();

var obj = new
{
    firstName = "King",
    lastName = "Kochhar",
    salary = 12000,
    address = new {streetName = "Civil Lines", city = "Delhi"},
    projects = new[]
    {
        new { projectName = "ECommerce", projectDuration = "40 Hours"},
        new { projectName = "Admin Portal", projectDuration = "25 Hours"},
        new { projectName = "Accounting", projectDuration = "30 Hours"}
    }
};

Console.WriteLine(obj.firstName);
Console.WriteLine(obj.lastName);
Console.WriteLine(obj.salary);
Console.WriteLine(obj.address.streetName);
Console.WriteLine(obj.address.city);

foreach (var project in obj.projects)
{
    Console.WriteLine(project.projectName + ": " + project.projectDuration); 
}

Console.WriteLine();

//MultiCast Delegates

/*CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

c1(100);

Console.WriteLine(DelegateExample.getNumber());

c2(200);

Console.WriteLine(DelegateExample.getNumber());
*/

//Single Cast Delegates

Console.WriteLine();

CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);

c1(100);
Console.WriteLine(DelegateExample.getNumber());
c1 += new CalculateDelegate(DelegateExample.addition);
c1 += new CalculateDelegate(DelegateExample.multiplication);

c1(100);
Console.WriteLine(DelegateExample.getNumber());
