using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();


    static void Main()
    {
        while (true)
        {
            Console.Clear();

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{tasks[i]}");
            }

            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Remover tarefa");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Digite a nova tarefa: ");
                tasks.Add(Console.ReadLine());
            }
            else if (choice == "2")
            {
                Console.Write("Digite o número da tarefa para remover: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                }

            }
            else if (choice == "3")
            {
                break;
            }
            
        }
    }
}