// Strings
Console.WriteLine("Strings");
Console.Write("Name:");
var name=Console.ReadLine();
Console.Write("Age:");
var age=Console.ReadLine();
string greeting="Hello";
string message=greeting+" "+name+" you are "+age+" years old.";
Console.WriteLine(message);
string secondMessage=$"{greeting} {name} you are {age} years old.";//string interpolation
Console.WriteLine(secondMessage);

int length=message.Length;
string upperMessage=message.ToUpper();
string lowerMessage=message.ToLower();
var split=message.Split(" ");//It splits every given value
var indexOf=message.IndexOf("years");
var contains=message.Contains("years");
Console.WriteLine($"Length:{length}");
Console.WriteLine($"Upper:{upperMessage}");//UPPERCASE
Console.WriteLine($"Lower:{lowerMessage}");//lowercase
Console.WriteLine($"Split:{string.Join(", ", split)}");//joins array items into one string
Console.WriteLine($"Split[3]:{split[3]}");// value at index 3
Console.WriteLine($"IndexOf:{indexOf}");// return index of "years"
Console.WriteLine($"Contains:{contains}");// if contain value return true if not return false.

// DateTime
Console.WriteLine("\nDateTime");
var now=DateTime.Now;
Console.WriteLine("Now:"+now);
Console.WriteLine("Year:"+now.Year);
Console.WriteLine("Month:"+now.Month);
Console.WriteLine("Day of week:"+now.DayOfWeek);
Console.WriteLine("Day:"+now.Day);

DateTime dt=new(2024,12,27);
Console.WriteLine("Another date:"+dt);
var difference=now-dt;
Console.WriteLine("Difference:"+difference);





