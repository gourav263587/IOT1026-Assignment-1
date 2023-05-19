using System;

public class Program
{
    public static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        int number;
        do
        {
            number = AskForNumber(text);
        } while (number < min || number > max);

        return number;
    }

    public static int[] ReplicateArray(int[] original)
    {
        int[] replicatedArray = new int[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            replicatedArray[i] = original[i];
        }
        return replicatedArray;
    }

    public static void Main(string[] args)
    {
        int size = AskForNumberInRange("Enter the size of the array (0-5):", 0, 5);
        int[] userArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            userArray[i] = AskForNumber($"Enter element #{i + 1}:");
        }

        int[] replicatedArray = ReplicateArray(userArray);

        Console.WriteLine("Copied array:");
        foreach (int num in replicatedArray)
        {
            Console.WriteLine(num);
        }
    }
}