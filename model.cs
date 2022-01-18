using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_management_system
{
    class model
    {
       internal String  Custemer_name, address, recipt, order_name, str, str1;
       internal int  Quntity, total_price, rprice , mprice , lprice ,qn;
       internal long mob_no;
       internal char size;
        public model()
        {
            
            total_price = 0;
            Quntity = 1;
            mob_no = 000-0000-000;
            Custemer_name = "";
            address = "";
            order_name = "";
            recipt = "";
            
        }
        internal string reciptprint()
        {
            recipt="Customer Name:" + Custemer_name + "\r\nCustomer Address:" + address + "\r\nCustomer Mobile No:" + mob_no + "\r\nOrder name:" + order_name + "\r\nQuntity:" + Quntity+"\r\nTotal price:" + total_price+"\r\n";

            return recipt;
        }
        internal void minu()
        {
            Console.WriteLine("\t\t\t\t\t1\n");
            Console.Write("\t\t\t\tPANEER MAKHANI\n");
            Console.WriteLine("\t\t\t============================\n");
            Console.Write("\t\t\tPaneer and Capsicum on Makhani Sauce\n");
            Console.Write("\t\t\tRaguler pizza pice:200\n");
            Console.Write("\t\t\tmediam pizza pice:320\n");
            Console.Write("\t\t\tlarge pizza pice:390\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("\t\t\t\t\t2\n");
            Console.Write("\t\t\t\tVEG EXTRAVAGANZA\n");
            Console.WriteLine("\t\t\t============================\n");
            Console.WriteLine("\tA pizza that decidedly staggers under an overload of golden corn, exotic black olives, crunchy onions, crisp capsicum, succulent mushrooms, juicyfresh tomatoes and jalapeno - with extra cheese to go all around.\n");
            Console.Write("\t\t\tRaguler pizza pice:230\n");
            Console.Write("\t\t\tmediam pizza pice:330\n");
            Console.Write("\t\t\tlarge pizza pice:400\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("\t\t\t\t\t3\n");
            Console.Write("\t\t\t\tVEGGIE PARADISE\n");
            Console.WriteLine("\t\t\t============================\n");
            Console.WriteLine("\t\t\tGoldern Corn, Black Olives, Capsicum & Red Paprika\n");
            Console.Write("\t\t\tRaguler pizza pice:150\n");
            Console.Write("\t\t\tmediam pizza pice:210\n");
            Console.Write("\t\t\tlarge pizza pice:270\n");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("\t\t\t\t\t4\n");
            Console.Write("\t\t\t\tCHEESE N CORN\n");
            Console.WriteLine("\t\t\t============================\n");
            Console.WriteLine("\t\t\tCheese I Golden Corn | Cheese n Corn Pizza\n");
            Console.Write("\t\t\tRaguler pizza pice:250\n");
            Console.Write("\t\t\tmediam pizza pice:300\n");
            Console.Write("\t\t\tlarge pizza pice:390\n");
        }
       internal void order_pizza()
        {
            int x;
            Console.Write("Enter Pizza number:");
            x = int.Parse(Console.ReadLine());
            
               if(x==1)
            {
                rprice = 200;
                mprice = 320;
                lprice = 390;
                order_name = "PANEER MAKHANI";
                //==========================================================================
                Console.WriteLine("\t\tYour Piza is:" + order_name);
                Console.WriteLine("\t\tlorge price: " + lprice + "\n\t\tmediam price: " + mprice + "\n\t\traguler price: " + rprice);
                Console.WriteLine("\nEnter size(L=lorge,M=mediam,R=raguler):");
                str = Console.ReadLine();
                str1 = str.ToUpper().Trim();
                size = str1[0];
                Console.Write("Enter Quntity:");
                qn = int.Parse(Console.ReadLine());
                Quntity = qn;
                if (size == 'L' || size == 'M' || size == 'R')
                {
                    if (size == 'R')
                    {
                        total_price = rprice * qn;
                    }
                    else if (size == 'M')
                    {
                        total_price = mprice * qn;
                    }
                    else
                    {
                        total_price = lprice * qn;
                    }
                }
//===========================================================================
            }else if(x==2)
            {
                rprice = 230;
                mprice = 330;
                lprice = 400;
                order_name = "VEG EXTRAVAGANZA";
                //==========================================================================
                Console.WriteLine("\t\tYour Piza is:" + order_name);
                Console.WriteLine("\t\tlorge price: " + lprice + "\n\t\tmediam price: " + mprice + "\n\t\traguler price: " + rprice);
                Console.WriteLine("\nEnter size(L=lorge,M=mediam,R=raguler):");
                str = Console.ReadLine();
                str1 = str.ToUpper().Trim();
                size = str1[0];
               Console.Write("Enter Quntity:");
                qn = int.Parse(Console.ReadLine());
                Quntity = qn;
                if (size == 'L' || size == 'M' || size == 'R')
                {
                    if (size == 'R')
                    {
                        total_price = rprice * qn;
                    }
                    else if (size == 'M')
                    {
                        total_price = mprice * qn;
                    }
                    else
                    {
                        total_price = lprice * qn;
                    }
                }
//===========================================================================
            }else if(x==3)
            {
                rprice = 150;
                mprice = 210;
                lprice = 270;
                order_name = "VEGGIE PARADISE";
                //==========================================================================
                Console.WriteLine("\t\tYour Piza is:" + order_name);
                Console.WriteLine("\t\tlorge price: " + lprice + "\n\t\tmediam price: " + mprice + "\n\t\traguler price: " + rprice);
                Console.WriteLine("\nEnter size(L=lorge,M=mediam,R=raguler):");
                str = Console.ReadLine();
                str1 = str.ToUpper().Trim();
                size = str1[0];
                
                Console.Write("Enter Quntity:");
                qn = int.Parse(Console.ReadLine());
                Quntity = qn;
                if (size == 'L' || size == 'M' || size == 'R')
                {
                    if (size == 'R')
                    {
                        total_price = rprice * qn;
                    }
                    else if (size == 'M')
                    {
                        total_price = mprice * qn;
                    }
                    else
                    {
                        total_price = lprice * qn;
                    }
                }
//===========================================================================
            }else if(x==4)
            {
                rprice = 250;
                mprice = 300;
                lprice = 390;
                order_name = "CHEESE N CORN";
                //==========================================================================
                Console.WriteLine("\t\tYour Piza is:" + order_name);
                Console.WriteLine("\t\tlorge price: " + lprice + "\n\t\tmediam price: " + mprice + "\n\t\traguler price: " + rprice);
                Console.WriteLine("\nEnter size(L=lorge,M=mediam,R=raguler):");
                str = Console.ReadLine();
                str1 = str.ToUpper().Trim();
                size = str1[0];
                Console.Write("Enter Quntity:");
                qn = int.Parse(Console.ReadLine());
                Quntity = qn;
                if (size == 'L' || size == 'M' || size == 'R')
                {
                    if (size == 'R')
                    {
                        total_price = rprice * qn;
                    }
                    else if (size == 'M')
                    {
                        total_price = mprice * qn;
                    }
                    else
                    {
                        total_price = lprice * qn;
                    }
                }
                //===========================================================================
            }else
            {
                Console.Clear();
                Console.Write("Product not available:");
            }
        }
        internal void setBacicDetails()
        {
            Console.Write("Enter Your Name:");
            Custemer_name = Console.ReadLine();
            Console.Write("Enter your Address:");
            address = Console.ReadLine();
            Console.Write("Enter your Mobile Number:");
            mob_no = long.Parse(Console.ReadLine());
        }
       internal void getBacicDetails()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n===============================================================================");

            Console.WriteLine("\t\t\t\t\tOrder Details\n");
            Console.WriteLine("\t\t\t\t\tCustomer Name:"+Custemer_name);
            Console.WriteLine("\t\t\t\t\tCustomer Address:" + address);
            Console.WriteLine("\t\t\t\t\tCustomer Mobile No:" + mob_no);
            Console.WriteLine("\t\t\t\t\tOrder name:" + order_name);
            Console.WriteLine("\t\t\t\t\tQuntity:" + Quntity);
            Console.WriteLine("\t\t\t\t\tTotal price:" + total_price);
            Console.WriteLine("===============================================================================");

        }
        
    }
}
