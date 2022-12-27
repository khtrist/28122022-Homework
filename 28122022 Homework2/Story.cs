using System;
using System.Collections.Generic;
using System.Text;

namespace _28122022_Homework2
{
    internal class Store 
    {

        public Store(string name)
        {
            Name = name;
        }
        public readonly string Name;
        public Notebook[] Products;
        public void SearchNotebook(Notebook[] nots)
        {
            Console.Write("Axtar :Daxil Et: ");
            string search = Console.ReadLine();
            for (int i = 0; i < nots.Length; i++)
            {
                if (nots[i].Name.Contains(search))
                {
                    ShowNotebooks(nots);
                }
            }
        }

        public Notebook[] AddNotebook(ref Notebook[] nots, Notebook value)
        {
            Notebook[] nots1 = new Notebook[nots.Length + 1];
            for (int i = 0; i < nots.Length; i++)
            {
                nots1[i] = nots[i];
            }
            nots1[nots1.Length - 1] = value;
            return nots1;
        }

        public void ShowNotebooks(Notebook[] nots)
        {
            for (int i = 0; i < nots.Length; i++)
            {
                Console.WriteLine("Name: " + nots[i].Name);
                Console.WriteLine("Price: " + nots[i].Price);
                Console.WriteLine("Ram: " + nots[i].RAM);
               
            }
        }
    }
}
