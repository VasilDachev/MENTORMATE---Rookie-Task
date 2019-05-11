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


                for (int column = 0; column <= 10 * Thickness ; column++)
                {

                    if (row < Separator)
                    {
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

                    }
                    if (row >= Separator)
                    {

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
                    }
                }
                brDownSide++;
                brUpper++;
                Console.Write("\n");
            }
        }
    
    }
}
