using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMate_doubleM
{
    class mGenerator
    {
        private int Thickness;

        public void Set_Thickness(int Thickness)
        {
            
            if (Thickness % 2 == 0 || Thickness <= 2 || Thickness >= 10_000)
            {
                Console.WriteLine("Enter odd value between 2 and 10 000!");
                return;
            }
            else
            {
                this.Thickness = Thickness;
            }
            


        }


        public int Get_Thickness()
        {
            return Thickness;
        }

        public void Draw_MM()
        {
            int brUpper = 0;
            int Separator = (Thickness / 2) + 1;
            int brDownSide = 1;
            int brDownSideLowCount = 1;
            int brLowerRightEnd = Thickness / 2;

           
            for (int row = 0; row <= Thickness; row++)
            {
                if (row >= Separator)
                {
                    brDownSideLowCount++;

                }
                if (row > Separator)
                {
                    brLowerRightEnd++;
                }


                for (int column = 0; column <= 11 * Thickness ; column++)
                {
                            /*Up*/
                    if (row < Separator)
                    {
                        /*First M*/
                        if (column < Thickness - brUpper)
                        {
                            Console.Write('-');
                        }
                        if (column > Thickness - brUpper && column <= Thickness * 2 + brUpper)
                        {
                            Console.Write('*');
                        }
                        if (column > Thickness * 2 + brUpper && column <= Thickness * 3 - brUpper)
                        {
                            Console.Write('-');
                        }
                        if (column > Thickness * 3 - brUpper && column <= Thickness * 4 + brUpper)
                        {
                            Console.Write('*');
                        }
                        if (column > Thickness * 4 + brUpper && column <= Thickness * 5)
                        {
                            Console.Write('-');
                        }

                        /*Second M*/

                        if (column > Thickness * 5 && column <= Thickness * 6 - brUpper) 
                        {
                            Console.Write('-');
                        }
                        if (column > 6*Thickness - brUpper && column <= Thickness * 7 + brUpper)
                        {
                            Console.Write('*');
                        }
                        if (column > Thickness * 7 + brUpper && column <= Thickness * 8 - brUpper)
                        {
                            Console.Write('-');
                        }
                        if (column > Thickness * 8 - brUpper && column <= Thickness * 9 + brUpper)
                        {
                            Console.Write('*');
                        }
                        if (column > Thickness * 9 + brUpper && column <= Thickness * 10)
                        {
                            Console.Write('-');
                        }


                    }
                            /*Down*/
                    if (row >= Separator)
                    {
                        
                        /*First M*/
                        if (column <= Thickness - brDownSide)
                        {
                            Console.Write('-');
                        }
                        if (column > Thickness - brDownSide && column <= Thickness - brDownSide + Thickness)
                        {
                            Console.Write('*');
                        }

                        if (column >= 2 * Thickness - brDownSideLowCount && column < 2 * Thickness + brDownSideLowCount - 3)
                        {
                            Console.Write('-');
                        }

                        if (column >= 2 * Thickness + brDownSideLowCount - 3 && column < 4 * Thickness - brDownSideLowCount)
                        {
                            Console.Write('*');
                        }
                        if (column >= 4 * Thickness - brDownSideLowCount && column < 4 * Thickness + brDownSideLowCount - 3)
                        {
                            Console.Write('-');
                        }
                        if (column >= 4 * Thickness + brDownSideLowCount - 3 && column <= 4 * Thickness + brLowerRightEnd + (Thickness / 2) - 1)
                        {
                            Console.Write('*');
                        }
                        if (column > 4 * Thickness + brLowerRightEnd + (Thickness / 2) - 1 && column < Thickness * 5 + brLowerRightEnd - brDownSideLowCount + 1)
                        {
                            Console.Write('-');
                        }

                        /*Second M*/

                        if (column > 5*Thickness&& column <= 6*Thickness - brDownSide+1)
                        {
                            Console.Write('-');
                        }
                        if (column > 6*Thickness - brDownSide+1 && column <= 7*Thickness - brDownSide+1 )
                        {
                            Console.Write('*');
                        }
                        if (column >= 7 * Thickness - brDownSideLowCount + 1 && column < 7 * Thickness + brDownSideLowCount - 2)
                        {
                            Console.Write('-');
                        }
                        if (column >= 7 * Thickness + brDownSideLowCount - 2 && column < 9 * Thickness - brDownSideLowCount+1)
                        {
                            Console.Write('*');
                        }
                        if (column >= 9 * Thickness - brDownSideLowCount+1 && column < 9 * Thickness + brDownSideLowCount - 2)
                        {
                            Console.Write('-');
                        }
                        if (column >= 9 * Thickness + brDownSideLowCount - 2 && column <= 9 * Thickness + brLowerRightEnd + (Thickness / 2) )
                        {
                            Console.Write('*');
                        }
                        if (column > 9 * Thickness + brLowerRightEnd + (Thickness / 2)  && column < Thickness * 10 + brLowerRightEnd - brDownSideLowCount + 2)
                        {
                            Console.Write('-');
                        }

                    }
                }
                brDownSide++;
                brUpper++;
                Console.Write("\n");
            }
        }
    
    }
}
