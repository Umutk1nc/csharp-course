using System;
using System.Collections;

namespace Lesson09;
class Program
{
    static void Main(string[] args)
    {
        //COLLECTIONS
        Console.WriteLine("--------------COLLECTIONS--------------");

        //ArrayList
        Console.WriteLine("====ArrayList====");
        ArrayList firstList=new ArrayList();
        firstList.Add(10);
        firstList.Add("Umut");
        firstList.Add(true);

        int[] numbers={10,20,30};
        firstList.AddRange(numbers);

        foreach(var item in firstList)
        {
            Console.WriteLine(item);
        }
        firstList.RemoveAt(0);//removes the first element so the list:Umut, true,10, 20, 30
        firstList.Remove(20);//removes the element with value 20 so the list:Umut, true,10, 30
        firstList.RemoveRange(2,2);//removes 2 elements starting from index 2 so the list:Umut, true
        Console.WriteLine("After removing elements");
        foreach(var item in firstList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"List contains 'Umut':{firstList.Contains("Umut")}");//true
        
        //Generic List
        Console.WriteLine("====Generic List====");
        List<int> intList=new List<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);

        foreach(var item in intList)
        {
            Console.WriteLine(item);
        }
        
        List<Product> productList=new List<Product>()
        {
            new Product(){Id=1,Name="Laptop",Price=30000},
            new Product(){Id=2,Name="Mouse",Price=500},
            new Product(){Id=3,Name="Keyboard",Price=1000}
        };

        Console.WriteLine("Product List:");
        foreach(var product in productList)
        {
            Console.WriteLine($"Id:{product.Id}, Name:{product.Name}, Price:{product.Price}");
        }

        //Dictionary
        Console.WriteLine("====Dictionary====");
        Dictionary<int,string> dictionary=new Dictionary<int,string>();
        dictionary.Add(34,"Istanbul");
        dictionary.Add(35,"Izmir");
        dictionary.Add(16,"Bursa");
        dictionary.Add(44,"Malatya");
        dictionary.Add(41,"Kocaeli");

        Console.WriteLine("Dictionary:");
        foreach(var item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }
}
class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
}