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

string result = isAuthenticated ? "You are logged in." : "You are not logged in";
Console.WriteLine(result);

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
