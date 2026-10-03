//LOOPS
Console.WriteLine("---------LOOPS---------");

//For Loop
Console.WriteLine("For Loop");
for (int i = 0; i <= 5; i++){
    Console.WriteLine($"For {i}");
}

//While Loop
Console.WriteLine("While Loop");
int j = 0;
while (j <= 5){
    Console.WriteLine($"While {j}");
    j++;
}

//Break and Continue Statements
Console.WriteLine("Break and Continue Statements");
for (int k = 0; k <= 10; k++){
    if (k == 5)
    {
        break;//Break statement to exit the loop when k is 5
    }
    if (k == 3)
    {
        continue;//Continue statement to skip the rest of the loop when k is 3
    }
    Console.WriteLine($"Loop Iteration {k}");
}
Console.WriteLine("End of Loop");

//Do While Loop
Console.WriteLine("Do While Loop");
int l = 0;
do{//It run at least once and then check the condition
    Console.WriteLine($"Do While {l}");
    l++;
} while (l <= 5);

//Foreach Loop
Console.WriteLine("Foreach Loop");
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int n in numbers)//Foreach loop to iterate through the array
{
    Console.WriteLine($"Foreach {n}");
}