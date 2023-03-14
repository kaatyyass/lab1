using System;
using System.Security.Cryptography;
using System.Text.Json;

class Program
{
    Dictionary<int, string> words = new Dictionary<int, string>();

    static void Main()
    {
        var words = new Dictionary<int, string>()
        {
            { 1, "agenda" },
            { 2, "memory" },
            { 3, "posterity" },
            { 4, "canopy" },
            { 5, "velocity" },
            { 6, "wonder" },
            { 7, "dalliance" },
            { 8, "priority" },
            { 9, "plethora" },
            { 10, "ingenue" },
            { 11, "placebo" }
        };
        try
        {
            string dict = null;
            Console.WriteLine("Enter a value: ");
            int item = Int32.Parse(Console.ReadLine());
            List<int> keys = new List<int>(words.Keys);
            List<string> value = new List<string>(words.Values);
            if (words.ContainsKey(item))
            {
                for (int i = 0; i < keys.Count(); i++)
                {
                    if (keys[i] == item)
                    {
                        for (int j = i; j < value.Count(); j++)
                        {
                            string str = "key: " + keys[j] + " value: " + value[j]+"   ";
                            dict += str;
                            Console.WriteLine(str);
                            
                        }
                        break;
                    }
                }
                using (FileStream fs = new FileStream("C:\\c#\\user.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync<object>(fs, dict);
                }
            }
            else
                Console.WriteLine("This value doesn`t exist!");
        }
        catch
        {
            Console.WriteLine("Wrong value!");
        }
    }
}