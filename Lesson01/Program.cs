// Variables
using System.Numerics;

Console.WriteLine("------------Variables------------");
// Value types: store data directly, fixed size
int age=20;
string name="Umut";// string is a reference type, but acts like a value here
double doubleNumber=6.02;// double: decimal numbers with high precision
bool isStudent=true;// bool: true/false only
string city="Adana";
char character='@';// char: single character, uses single quotes
Console.WriteLine("Age:"+age);
Console.WriteLine("Hello "+name+", you are student:"+isStudent);
Console.WriteLine("Double number:"+doubleNumber);
Console.WriteLine("You are from "+city);
Console.WriteLine("character:"+character);
Console.Write("First Number: ");

// Console.ReadLine() always returns string, so we convert it to int
int firstNumber =Convert.ToInt32(Console.ReadLine());
Console.Write("Second Number: ");
// 'var' lets the compiler infer the type — here it becomes int automatically
var secondNumber=Convert.ToInt32(Console.ReadLine());
int total= firstNumber+secondNumber;
Console.WriteLine("Total:"+total);
// Explicit cast: converts double to int, decimal part is truncated (not rounded)
int convertingNumber=(int)doubleNumber;
Console.WriteLine("Converting Number:"+ convertingNumber);

// Nullable Types
// Adding '?' allows a value type (normally non-nullable) to also hold null
int? firstSalary=null;
int? secondSalary=null;
secondSalary=28000;
// HasValue checks whether the nullable variable actually holds a value or is null
Console.WriteLine(firstSalary.HasValue);// false, still null
Console.WriteLine(secondSalary.HasValue);// true, has a value now