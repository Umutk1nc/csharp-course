//Arithmetical Operators
Console.WriteLine("-----------Arithmetical Operators-----------");
int firstNumber = 8;
int secondNumber = 4;
int? thirdNumber = null;
Console.WriteLine($"Addition: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"Subtraction: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"Multiplication: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"Division: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"Modulus: {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
Console.WriteLine($"Default Value: {thirdNumber ?? 0}");//thirdNumber is null, so it will use default value 0 instead
Console.Write("Number:");
int number = int.Parse(Console.ReadLine()??"0");//Parsing the input to an integer, if null, default to 0
var result = number % 2 == 0 ? "Even" : "Odd";
Console.WriteLine($"Number {number} is {result}.");

//Assignment Operators
Console.WriteLine("-----------Assignment Operators-----------");
int a = 5;
Console.WriteLine($"Initial value of a: {a}");
a += 3; // Equivalent to a = a + 3
Console.WriteLine($"After adding 3: {a}");
a -= 2; // Equivalent to a = a - 2
Console.WriteLine($"After subtracting 2: {a}");
a *= 4; // Equivalent to a = a * 4
Console.WriteLine($"After multiplying by 4: {a}");
a /= 2; // Equivalent to a = a / 2
Console.WriteLine($"After dividing by 2: {a}");
Console.WriteLine("a++: " + a++);//First prints the value of a, then increments it by 1
Console.WriteLine("++a: " + ++a);//First increments the value of a by 1, then prints it
Console.WriteLine("a--: " + a--);//First prints the value of a, then decrements it by 1
Console.WriteLine("--a: " + --a);//First decrements the value of a by 1, then prints it

//Comparison Operators
Console.WriteLine("-----------Comparison Operators-----------");
int x = 5;
int y = 10;
Console.WriteLine($"Is {x} equal to {y}? {x == y}");
Console.WriteLine($"Is {x} not equal to {y}? {x != y}");
Console.WriteLine($"Is {x} less than {y}? {x < y}");
Console.WriteLine($"Is {x} greater than {y}? {x > y}");
Console.WriteLine($"Is {x} less than or equal to {y}? {x <= y}");

//Logical Operators
Console.WriteLine("-----------Logical Operators-----------");
bool valueTrue = true;
bool valueFalse = false;

//AND
Console.WriteLine("-----------AND Operator-----------");
Console.WriteLine($"AND: {valueFalse} && {valueFalse} = {valueFalse && valueFalse}");
Console.WriteLine($"AND: {valueTrue} && {valueFalse} = {valueTrue && valueFalse}");
Console.WriteLine($"AND: {valueTrue} && {valueTrue} = {valueTrue && valueTrue}");

//OR
Console.WriteLine("-----------OR Operator-----------");
Console.WriteLine($"OR: {valueFalse} || {valueFalse} = {valueFalse || valueFalse}");
Console.WriteLine($"OR: {valueTrue} || {valueFalse} = {valueTrue || valueFalse}");
Console.WriteLine($"OR: {valueTrue} || {valueTrue} = {valueTrue || valueTrue}");
    
//NOT
Console.WriteLine("-----------NOT Operator-----------");
Console.WriteLine($"NOT: !{valueTrue} = {!valueTrue}");
Console.WriteLine($"NOT: !{valueFalse} = {!valueFalse}");

//Random Number Generation
Console.WriteLine("-----------Random Number Generation-----------");
Random random = new Random();
string[] teams=["Team A", "Team B", "Team C", "Team D"];
string randomTeam = teams[random.Next(0, teams.Length)];
Console.WriteLine($"Random Team: {randomTeam}");
int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
Console.WriteLine($"Random Number 1-100: {randomNumber}");