//Folder Management
Console.WriteLine("--------Folder Management--------");
//Create Folder
Console.WriteLine("Folder Creation...");
Directory.CreateDirectory("temp");
Console.WriteLine("Folder Created Successfully!");

//File Management
Console.WriteLine("--------File Management--------");

//File Writing
Console.WriteLine("File Writing...");
using (StreamWriter sw = File.CreateText("temp/test.txt"))
{
    sw.WriteLine("Hello, World!\nHello, C#!");
}//automatically closes/disposes sw, even if an exception occurs

//File Reading
Console.WriteLine("File Reading...");
using (StreamReader sr = File.OpenText("temp/test.txt"))
{
    var s="";
    while((s=sr.ReadLine())!=null)
    {
        Console.WriteLine(s);
    }
}

//File Appending
Console.WriteLine("File Appending...");
using (StreamWriter sw1 = File.AppendText("temp/test.txt"))
{
    sw1.WriteLine("Appended Text!");
}