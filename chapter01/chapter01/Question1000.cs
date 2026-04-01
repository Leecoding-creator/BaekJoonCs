using System;

public class Program
{
    static void Main()
    {
        /*
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
        */
        string[] str = Console.ReadLine().Split();
        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);

        Console.WriteLine(a + b);

        /* gemini
        // LINQ를 활용하여 한 줄의 모든 숫자를 합산하는 예시
        using System.Linq;

        string[] str = Console.ReadLine().Split();
        int sum = str.Select(int.Parse).Sum();
        Console.WriteLine(sum);
        */
    }
}
