using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "7854";
            Console.WriteLine("enter password");
            
            string enteredpassword = Console.ReadLine();
            if (enteredpassword == password)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }

        static void CheatSheet()
        {
            int rod = 18;//ari9mos
            string ass = "i play warcraft";//protash h le3h kai ari9mous sxedon
            bool tits = false;//true or false
            char livrid = 'J';//grammata h xarakthras-symvolo

            Console.WriteLine(rod);
            Console.WriteLine(ass);
            Console.WriteLine(tits);
            Console.WriteLine(livrid);


            string red = Console.ReadLine();
            try//gia error
            {
                int redd = Convert.ToInt32(red);

                if (rod > redd)
                {
                    Console.WriteLine("rod is bigger");
                }
                else
                {
                    Console.WriteLine("rod is smaller");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("i can't do that " + ex);
            }
            Console.ReadLine();
        }
    }
}
