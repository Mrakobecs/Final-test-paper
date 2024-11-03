using System;

class Program
{
    static void Main()
    {
        string[] initialArray = { "hi", "hello", "yes", "no", "maybe" };
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }
        string[] newArray = new string[count];
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                newArray[index] = initialArray[i];
                index++;
            }
        }
        Console.WriteLine("Новый массив строк, длина которых <= 3:");
        foreach (var str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}
