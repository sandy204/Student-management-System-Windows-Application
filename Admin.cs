using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace pizza_management_system
{
    class Admin: model
    {
     internal void adminPinal()
        {

            // File.WriteAllText(, All_details);
           string alldetl=File.ReadAllText("D:\\sandy\\All_details.txt");
            Console.Write(alldetl);


        }  
    }
}
