using System;

namespace loveprocent
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int love = rnd.Next(19,101);/*tova e random chislo ot 20 do 100*/
            string a, b;
            
           
            Console.WriteLine("Мъж:");
            a=Console.ReadLine();
            char last = a[a.Length - 1]; //tova e poslednata bukva na promenlivata a!
            Console.WriteLine("Жена:");
            b=Console.ReadLine();
            if (a=="koko" && b=="mariq goshkina")
            {
                love = 100;
            }
            if (a=="" || b=="")
            {
                Console.WriteLine("WRONG");
            }
            else
            {
                Console.WriteLine("Любов:" + love + "%");
                
            }
        
           
            
        }
    }
}
