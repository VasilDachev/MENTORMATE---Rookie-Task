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
          
            
            Console.Write("Enter boldness value:");
            
            int boldness = int.Parse(Console.ReadLine());
            if (boldness % 2 == 0 || boldness <= 2 || boldness >= 10_000) 
            {
                Console.WriteLine("Enter odd value between 2 and 10 000!");
                return;
            }

            int Changer=0;

            int stopper = (boldness / 2) + 1;

            int helper = 1;
            int moreHelp = 1;
            int br = boldness/2 ;

            

            for (int row = 0; row <= boldness; row++) 
            {
                if (row>=stopper)
                {
                    moreHelp++;
                    
                }
                if (row>stopper)
                {
                    br++;
                }

                
                for (int column = 0; column <= 6*boldness-1; column++)
                {
                    
                    if (row<stopper)
                    {
                        if (column < boldness - Changer)
                        {
                            Console.Write('-');
                        }
                        if (column > boldness - Changer && column <= boldness * 2 + Changer)
                        {
                            Console.Write('*');
                        }
                        if (column > boldness * 2 + Changer && column <= boldness * 3 - Changer)
                        {
                            Console.Write('-');
                        }
                        if (column > boldness * 3 - Changer && column <= boldness * 4 + Changer)
                        {
                            Console.Write('*');
                        }
                        if (column > boldness * 4 + Changer && column <= boldness * 5)
                        {
                            Console.Write('-');
                        }
   
                    }
                    if (row >= stopper)
                    {
                        
                        if (column <= boldness - helper)
                        {
                            Console.Write('-');    
                        }
                        if (column >boldness-helper&&column<=boldness-helper + boldness)
                        {
                            Console.Write('*');
                        }
                        
                        if ( column >= 2*boldness - moreHelp&& column<2*boldness+moreHelp - 3 ) 
                        {
                            Console.Write('-');
                        }

                        if (column>=2*boldness+moreHelp-3&&column<4*boldness-moreHelp)
                        {
                            Console.Write('*');
                        }
                        if (column >= 4 * boldness - moreHelp && column < 4 * boldness + moreHelp - 3 ) 
                        {
                            Console.Write('-');
                        }
                        if (column >= 4 * boldness + moreHelp - 3 && column <= 4 * boldness + br + (boldness / 2) - 1)
                        {
                            Console.Write('*');
                        }
                        if (column>4*boldness+br+(boldness/2)-1&&column<boldness*5 +br-moreHelp+1)
                        {
                            Console.Write('-');
                        }
                    }
                }
                helper++;
                Changer++;
                Console.Write("\n");     
            }




            Console.ReadLine();
        }
    }
}
