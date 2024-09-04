using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoApp 
    {
        public void Start()
        {
            ToDoList todolist = new ToDoList(); 

            while (true)
            {
                Console.Clear();
                Console.WriteLine("To-Do List v1.0");
                Console.WriteLine("---------------");
                Console.WriteLine("Vyberte akci, kterou chcete provést:");
                Console.WriteLine("(1) Přidat položku");
                Console.WriteLine("(2) Odebrat položku");
                Console.WriteLine("(3) Ukázat seznam");
                Console.WriteLine("(4) Ukončit program");

                int userChoice;
                bool isValidInput = int.TryParse(Console.ReadLine(), out userChoice);

                if (!isValidInput)
                {
                    Console.WriteLine("Neplatná volba, zkuste to znovu.");
                    continue;
                }

                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        todolist.AddItem();
                        break;
                    case 2:
                        Console.Clear();
                        todolist.DeleteItem();
                        break;
                    case 3:
                        Console.Clear();
                        todolist.ShowList();
                        Console.WriteLine("Stiskněte libovolnou klávesu pro návrat do hlavního menu.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Program ukončen.");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Neplatná volba, zkuste to znovu.");
                        break;
                }
            }
        }
    }
}
