using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMate_doubleM
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("--- MentorMate project ---");

            mGenerator genM = new mGenerator();
            Console.Write("Enter boldness value:");
            int bold = int.Parse(Console.ReadLine());
            genM.Set_Thickness(bold);
            genM.Get_Thickness();
            genM.Draw_MM();

            


        } 
    }
}
