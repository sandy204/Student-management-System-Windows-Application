using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;
namespace pizza_management_system
{      
    class Program
    {
        
        static void Main(string[] args)
        {
/*
           int x=Console.Read();
            if (x.Equals(65))
            {
                string id;
                int pass;
                string lg = File.ReadAllText("D:\\sandy\\lOGIN.txt");

                Console.WriteLine("===============================================================================");
                while (true)
                {
                    Console.Write("Enter Admin id:");
                    id = Console.ReadLine();
                    Console.Write("Enter Admin password:");
                    pass = int.Parse(Console.ReadLine());
                    //matching pass
                    lg.Trim();
                    string[] passid = lg.Split('\n');
                    string fid = passid[0];
                    string Rid = fid.Substring(fid.IndexOf('=') + 1);
                    string fpass = passid[1];
                    int rpass = int.Parse(fpass.Substring(fpass.IndexOf('=') + 1));
                    if (id == Rid && pass == rpass)
                    {
                        int print;
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\t\t\tRecipt print Sucsesfully..");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.Write("Prase 1 then Print all Detals:");
                        Console.Write("Prase 2 then Print all Detals:");
                        print = int.Parse(Console.ReadLine());
                        if (print == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(lg);
                        }
                        else
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.Write("Password incracte Plesse re Enter your pass.");
                        continue;
                    }
                }

            }
            else
            {


            */

                model m = new model();
                m.minu();
                Console.WriteLine("\t\t\tOrder now");
                Console.Write("Order now press 1 :");
                int y = int.Parse(Console.ReadLine());

                if (y == 1)
                {
                    Console.Clear();
                    m.setBacicDetails();
                    m.order_pizza();
                    m.getBacicDetails();
                    Console.Write("\tPrint your recipt then prase 1:");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {

                        string print_details = m.reciptprint();
                        if (!File.Exists("D:\\sandy\\abc.txt"))
                        {
                            File.Create("D:\\sandy\\abc.txt");
                        }
                        Thread.Sleep(100);
                        File.WriteAllText("D:\\sandy\\abc.txt", print_details);
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\t\t\tRecipt print Sucsesfully..");

                        File.AppendAllText("D:\\sandy\\All_details.txt", print_details);
                        File.AppendAllText("D:\\sandy\\All_details.txt", "===================================================\r\n");

                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("\n\n\n\n\t\t\t\tThis Aplication is Close...");
                }
          

            /* if(!File.Exists("D:\\sandy\\abc.txt"))
             {
                 Console.Write(File.Create("D:\\sandy\\abc.txt"));
             }
             else
             {
                 Console.Write("hfghf");
             }

             Console.ReadKey();


  string str1 = "my name is sandeep++ kumar maurya"+"\r\n"+"khjfjwehfu";

             {

             }
             string[] a = Environment.GetLogicalDrives();
             foreach(string b in a)
             {
                 Console.WriteLine(b);
             }
             File.WriteAllText("D:\\sandy\\abc.txt", str1);

             File.AppendAllText("D:\\sandy\\abc.txt", str1);
             string str = File.ReadAllText("D:\\sandy\\abc.txt");
             File.
             Console.Write(str);*/

        }
    }
}
