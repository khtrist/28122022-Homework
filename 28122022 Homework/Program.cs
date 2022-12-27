using System;

namespace _28122022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[0];
            string option;
            do
            {
                Console.WriteLine("1. User Elave et");
                Console.WriteLine("2. Userlere Bax");
                Console.WriteLine("3. Userler uzre axtaris");
                Console.WriteLine("0. Menyudan Cix");
                option = Console.ReadLine();
                if (option == "1")
                {

                    try
                    {
                        User newuser = CreateUser();
                        users = AddUser(ref users, newuser);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta" + e.Message.ToString());
                    }
                }
                else if (option == "2")
                {
                    try
                    {
                        ListUsers(users);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta" + e.Message.ToString());
                    }

                }
                else if (option == "3")
                {
                    try
                    {
                        SearchUsers(users);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Xeta" + e.Message.ToString());
                    }

                }


            } while (option != "0");

        }

        static User CreateUser()
        {
            User newUser = new User(null);
            do
            {
                Console.WriteLine("Username Daxil Et: ");
                string usernameStr = Console.ReadLine();
                newUser.UserName = (usernameStr);

            } while (newUser.UserName == null);
            do
            {
                Console.WriteLine("Password Daxil et: ");
                string passwordStr = Console.ReadLine();
                newUser.Password = (passwordStr);

            } while (newUser.Password == null);
            newUser.DateTime = DateTime.Now.ToString();
            return newUser;
        }
        static User[] AddUser(ref User[] usr, User newuser)
        {
            User[] usrr = new User[usr.Length + 1];
            for (int i = 0; i < usr.Length; i++)
            {
                usrr[i] = usr[i];
            }
            usrr[usrr.Length - 1] = newuser;
            return usrr;
        }
        static void SearchUsers(User[] usr)
        {
            Console.Write("Axtar :Daxil Et: ");
            string search = Console.ReadLine();
            for (int i = 0; i < usr.Length; i++)
            {
                if (usr[i].UserName.Contains(search))
                {
                    Console.WriteLine("Username: " + usr[i].UserName);
                    Console.WriteLine("Yaranma tarixi: " + usr[i].DateTime);
                }
            }
        }
        static void ListUsers(User[] usr)
        {
            for (int i = 0; i < usr.Length; i++)
            {
                Console.WriteLine("Username: " + usr[i].UserName);
                Console.WriteLine("Yaranma tarixi: " + usr[i].DateTime);
            }
        }
    }
}
