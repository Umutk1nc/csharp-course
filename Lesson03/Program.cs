//Arrays
Console.WriteLine("------------Arrays------------");
//Array Definition
string[] names=["Umut", "Mehmet", "Berk", "Kıvanç", "Ali"];

int[] numbers={100,200,300,400,500};
Console.WriteLine(names[2]);
Console.WriteLine(numbers[2]);

//Array Methods
Console.WriteLine("------------Array Methods------------");
string[] cities={"Adana","Mersin","Ankara","İzmir","İstanbul"};
// Replace the city at index 1.
cities.SetValue("Sakarya",1);
Console.WriteLine("Length:"+cities.Length);
Console.WriteLine("Index number of İstanbul:"+Array.IndexOf(cities,"İstanbul"));
// Sorts the cities alphabetically.
Array.Sort(cities);//It sorts alphabetical order
Console.WriteLine("----Alphabetical Order----");
Console.WriteLine(cities.GetValue(0));
Console.WriteLine(cities.GetValue(1));
Console.WriteLine(cities.GetValue(2));
Console.WriteLine(cities.GetValue(3));
Console.WriteLine(cities.GetValue(4));
// Reverses the sorted order.
Array.Reverse(cities);
Console.WriteLine("----Reverse----");
Console.WriteLine(cities.GetValue(0));
Console.WriteLine(cities.GetValue(1));
Console.WriteLine(cities.GetValue(2));
Console.WriteLine(cities.GetValue(3));
Console.WriteLine(cities.GetValue(4));
// Clears every element in the array.
Array.Clear(cities);
Console.WriteLine("----Clear----");
Console.WriteLine(cities.GetValue(0));// Clear sets each element to null (default value for strings)
// Array Slicing
// Copy elements from index 0 up to, but not including, index 3.
Console.WriteLine("----Array Slicing----");
Console.WriteLine("Default Array");
foreach(var i in numbers){
    Console.Write(i+" ");
}
var slicingNumbers=numbers[0..3];
Console.WriteLine("\nSlicing Array[0..3]");
foreach(var i in slicingNumbers){
    Console.Write(i+" ");
}