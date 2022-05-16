using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp91.Entity
{
    class ManagementOfLibrary
    {
        /// <summary>
        /// giao dien dang nhap
        /// </summary>
        public static void loginInterface()
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            int[,] arr = new int[5, 18];
            Console.WriteLine("\n\n\n\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\t\t\t\t\t\t\t\t");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == arr.GetLength(0) - 1 || j == 0 || j == arr.GetLength(1) - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        if (i == 2)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }

                    }

                    if (i == 2 && j == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t\t  DANG NHAP HE THONG");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                Console.WriteLine();

            }


        }






        public static  void input()
        {
            Console.Write("\n\t\t\t\t\t\t\t\tUSER:");
            userName();
            Console.ReadKey();
            Console.Write("\n\t\t\t\t\t\t\t\tPASSWORD:");
            password();
            Console.ReadKey();
        }





        /// <summary>
        ///ten nguoi dung
        /// </summary>
        /// <returns></returns>
        public static string userName()
        {
            string listOfKey = "";
            char key = '\0';
            //Console.Write("\n\t\t\t\t\t\t\t\tUSER:");

         




            do
            {

                key = Console.ReadKey(false).KeyChar;
                if (key != (char)ConsoleKey.Enter && key != (char)ConsoleKey.Backspace)
                {
                    listOfKey += key;

                }


                if (key == (char)ConsoleKey.Backspace && listOfKey.Length > 0)
                {
                    Console.Write("\b \b");
                    if (listOfKey.Length != 0)
                    {
                        listOfKey = listOfKey.Remove(listOfKey.Length - 1, 1);

                    }
                }


                if (key == (char)ConsoleKey.Enter && listOfKey.Length <= 7)
                {

                    Console.Clear();
                    Console.Write("hay nhap mat khau co 6 chu so tro len!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("USER");

                }




            } while (key != (char)ConsoleKey.Enter || listOfKey.Length <= 7);


            Console.WriteLine("\n" + listOfKey);
            return listOfKey;




        }

        /// <summary>
        /// mat khau nguoi dung
        /// </summary>
        /// <returns></returns>
        public static string password()
        {


            //Console.Write("PASSWORD:");
            char key = '\0';
            string listOfKey = null;
            do
            {

                key = Console.ReadKey(true).KeyChar;
                if (key != (char)ConsoleKey.Enter && key != (char)ConsoleKey.Backspace)
                {
                    listOfKey += key;
                    Console.Write("*");
                }


                if (key == (char)ConsoleKey.Backspace && listOfKey.Length > 0)
                {
                    Console.Write("\b \b");
                    if (listOfKey.Length != 0)
                    {
                        listOfKey = listOfKey.Remove(listOfKey.Length - 1, 1);

                    }
                }


                if (key == (char)ConsoleKey.Enter && listOfKey.Length <= 7)
                {

                    Console.Clear();
                    Console.Write("hay nhap mat khau co 6 chu so tro len!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("PASSWORD:");

                }




            } while (key != (char)ConsoleKey.Enter || listOfKey.Length <= 7);

            Console.WriteLine("\n" + listOfKey);
            return listOfKey;
        }





    }
}

















