using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static Random random = new Random();

    public static List<int> GenerateRandom(int count,int minValue,int maxValue)
    {
        HashSet<int> numbers = new HashSet<int>();
        while (numbers.Count < count)
        {
            numbers.Add(random.Next(minValue, maxValue));
        }

        List<int> values = new List<int>();
        values.AddRange(numbers);
        values.Sort();

        return values;
    }
    public static void Main()
    {   
        Console.WriteLine("How many do you want?");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Min Value?");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Max Value?");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        List<int> value = GenerateRandom(count,minValue,maxValue);
        value.ForEach(Console.WriteLine);
        Console.ReadLine();
    }
}