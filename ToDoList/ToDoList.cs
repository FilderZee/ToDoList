using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoList
    {
        List<string> itemList = new List<string>();
        private int maxItemCount = 10;
   

        public int MaxItemCount { get { return maxItemCount; } set { maxItemCount = value; } }

        public void AddItem()
        {
            if (itemList.Count >= maxItemCount)
            {
                Console.WriteLine("Nelze přidat více položek. Seznam je plný.");
                return;
            }

            Console.Write("Napište název položky, kterou chcete přidat: ");
            string item = Console.ReadLine();
            itemList.Add(item);
        }


        public void ShowList()
        {
            int itemIndex = 1; 
            foreach (string item in itemList)
            {
                Console.WriteLine(itemIndex + ". " + item);
                itemIndex++;
            }
        }


        public void DeleteItem()
        {
            ShowList();
            Console.Write("Napište index položky, kterou chcete odstranit: ");
            int userDeleteChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (userDeleteChoice >= 0 && userDeleteChoice < itemList.Count)
            {
                itemList.RemoveAt(userDeleteChoice);
                Console.WriteLine("Položka byla úspěšně odstraněna.");
            }
            else
            {
                Console.WriteLine("Neplatný index.");
            }
        }

    }
}
