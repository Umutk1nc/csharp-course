using System;
namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        //Creating an object of the Student class
        Student firstStudent=new Student("1453", "Umut Kılınç", "10/B");

        Student secondStudent=new Student("99", "Eyüp Kılınç", "5/A");

        Student thirdStudent=new Student("100", "Ahmet Yılmaz", "6/C");

        Student[] students=new Student[]{firstStudent,secondStudent,thirdStudent};
        //Creating an array of Student objects and looping through the array to call the ShowInfo method for each student
        foreach(var student in students)
        {
            student.showInfo();//called via object, object is needed
        }
        Console.WriteLine($"\nTotal students created: {Student.GetTotalStudents()}");//called via class name, no object needed
    }
}

class Student
{
    //Access Modifier - private it means that this property can only be accessed within the class, it cannot be accessed from outside the class
    private string? StudentNumber {get;set;}//this is a property, it is a member of the class, it is a variable that belongs to the class
    private string? Name {get;set;}
    private string? Classroom {get;set;}

    private static int totalStudents=0;

    //Access Modifier - public it means that this method can be accessed from anywhere
    public void showInfo()
    {
        Console.WriteLine($"\nName: {this.Name} \nStudent Number: {this.StudentNumber} \nClassroom: {this.Classroom}");
    }
    //Constructor
    public Student(string studentNumber, string name, string classroom)
    {//Constructor is a special method that is called when an object is created, it has the same name as the class, it does not have a return type, it can have parameters
        this.StudentNumber=studentNumber;
        this.Name=name;    
        this.Classroom=classroom;
        totalStudents++;
        Console.WriteLine("Student object is created");
    }

    // static Method
   public static int GetTotalStudents()
    {
        return totalStudents;
    }

}