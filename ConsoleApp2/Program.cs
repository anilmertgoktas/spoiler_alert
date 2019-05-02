using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Thor dies");

            display display = new display();
            Console.WriteLine( display.Type("night king"));


        }
    }

     

    public class display : Display
    {
    
        public string Type(string type)
        {
            type = "mount";
            return "arya stark kills the " + type;
        }

       
    }


    

}
