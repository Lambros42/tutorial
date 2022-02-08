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
            string password = "7854"; //Apothikevoume password stin mnimi
            Console.WriteLine("enter password");//Zitame to password apo ton xristi
            
            string enteredpassword = Console.ReadLine(); //Apothikeuoume to password pou mas edwse o xristis stin mnimi

            while (enteredpassword != password && tries != 0) //loop oso o password den einai swstos
            {
                tries--;//to -- aferei ena kai to ++ pros8eth ena , den xreiazetai na grapsw int mprosta apo to tries giati exw kanei declare panw

                Console.WriteLine("false password entered you have " + tries + " tries");
                enteredpassword = Console.ReadLine();
            }
            if (enteredpassword == password)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine(notriesleft);
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
