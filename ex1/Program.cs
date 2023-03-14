using System;
using System.Collections;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
        try
        {
            //------------------------------Array List-----------------------------------------------
            Console.WriteLine("Enter a number of gamers: ");
            int number = Int32.Parse(Console.ReadLine());
            ArrayList gamers = new ArrayList();
            int i, index = 0;
            for (i = 1; i < number + 1; i++)
            {
                gamers.Add(i);
            }

            int[] survive = (int[])gamers.ToArray(typeof(int));
            Console.WriteLine(String.Join(' ', survive));
            do
            {
                for (i = 0; i < survive.Length; i++)
                {
                    index += 1;
                    if (index % 2 == 0)
                    {
                        gamers.Remove(survive[i]);
                        index = 0;
                        foreach (var person in gamers)
                        {
                            Console.Write(person + " ");
                        }

                        Console.WriteLine();
                    }
                }

                survive = (int[])gamers.ToArray(typeof(int));
                if (survive.Length == 1)
                    break;
            } while (true);

            Console.WriteLine("Gamer №{0} win", survive[0]);
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }

        //------------------------------Linked List----------------------------------------------
        try
        {
            Console.WriteLine("Enter a number of gamers: ");
            int number = Int32.Parse(Console.ReadLine());
            LinkedList<int> gamers = new LinkedList<int>();
            gamers.AddFirst(1);
            for (int i = 2; i < number + 1; i++) //заповнення списку послідовними номерами гравців
            {
                gamers.AddLast(i);
            }

            var part = gamers.First;
            var item = part;
            int index = 0;
            do
            {
                for (int i = 0; i < gamers.Count; i++)
                {
                    index += 1;
                    if (index % 2 == 0)
                    {
                        if (gamers.Count == 2) break;
                        if (item.Next == null)
                            item = gamers.First;
                        else item = item.Next;
                        if (item.Next == null)
                            part = gamers.First;
                        else part = item.Next;
                        gamers.Remove(item);


                        item = part;
                        Console.WriteLine(String.Join(' ', gamers));
                        index = 0;
                    }
                }

                if (gamers.Count == 2) break;
            } while (true);

            Console.WriteLine($"Gamer №" + gamers.First.Value + " win");
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }

    }
    }