//CONDITIONAL STATEMENTS
Console.WriteLine("-------Conditional Statements-------");
//If Else Statement
Console.Write("Enter your weight in kg: ");
int weight=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your height in centimeters: ");
int height=Convert.ToInt32(Console.ReadLine());
double bmi=weight/(height/100.0*height/100.0);
Console.WriteLine("BMI: "+bmi);
if (bmi < 18.5){
    Console.WriteLine("Underweight");
}
else if (bmi >= 18.5 && bmi < 25){
    Console.WriteLine("Normal weight");
}
else if (bmi >= 25 && bmi < 30){
    Console.WriteLine("Overweight");
}
else{
    Console.WriteLine("Obesity");
}
//Switch Statement
int day = (int)DateTime.Now.DayOfWeek;
switch(day){//Switch statement to print the day of the week
    case 0:
        Console.WriteLine("Today is Sunday");//Day of the week is Sunday 7th day and mod 7 is 0
        break;//Break statement to exit the switch statement
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;
    default://Default case to handle invalid day values
        Console.WriteLine("Invalid day");
        break;
}