using System;

namespace _28122022_Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[0];
            string option;
            do
            {
                Console.WriteLine("1. Notebook Elave et");
                Console.WriteLine("2. NoteBook List");
                Console.WriteLine("3. Notebooklar uzre Search");
                Console.WriteLine("0. Menyudan Cix");
                option = Console.ReadLine();
                if (option == "1")
                {

                    try
                    {
                        Notebook newnotebook = CreateNotebook();
                        notebooks = AddNotebook(ref notebooks, newnotebook);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta " + e.Message.ToString());
                    }
                }
                else if (option == "2")
                {
                    try
                    {
                        ListNotebook(notebooks);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta " + e.Message.ToString());
                    }

                }
                else if (option == "3")
                {
                    try
                    {
                        SearchNotebook(notebooks);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta" + e.Message.ToString());
                    }
                }
                else if (option != "1" && option != "2" && option != "3" && option != "0")
                {
                    Console.WriteLine("Duzgun Daxil edin");
                }

            } while (option != "0");

        }

        static Notebook CreateNotebook()
        {

            Console.WriteLine("Notebook yarat:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || name.Length < 4)
            {
                throw new NameFormatException("Name deyeri minimum 4 uzunlquda olmalidir!");
            }

            double price;
            bool check = true;
            do
            {
                Console.WriteLine("Qiymeti Daxil edin:");
                string priceStr = Console.ReadLine();
                check = double.TryParse(priceStr, out price);

                if (check == false)
                    Console.WriteLine("Price deyeri IsDigit olmalidir");

            } while (!check);


            byte ram;

            do
            {
                Console.WriteLine("Ram:");
                string ramStr = Console.ReadLine();
                check = byte.TryParse(ramStr, out ram);

                if (check == false)
                    Console.WriteLine("Ram olmasa olmur");

            } while (!check);



            return new Notebook(name, price, ram );
           
        }

        static Notebook[] AddNotebook(ref Notebook[] nots, Notebook value)
        {
            Notebook[] nots1 = new Notebook[nots.Length + 1];
            for (int i = 0; i < nots.Length; i++)
            {
                nots1[i] = nots[i];
            }
            nots1[nots1.Length - 1] = value;
            return nots1;
        }

        static void SearchNotebook(Notebook[] nots)
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
        static void ListNotebook(Notebook[] nots)
        {
            for (int i = 0; i < nots.Length; i++)
            {
                
                ShowNotebooks(nots);
            }
        }

        static void ShowNotebooks(Notebook[] nots)
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
