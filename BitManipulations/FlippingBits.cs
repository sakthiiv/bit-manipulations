namespace BitManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FlippingBits : AbstractBase
    {
        public override void Execute()
        {

            string[] numbers = "2147483647\n1\n0".Split('\n').ToArray();
            int t = Convert.ToInt16(3);            

            for (int k = 0; k < t; k++)
            {
                UInt32 x = Convert.ToUInt32(numbers[k]);

                /*
                 * My Solution - Kind of Annoying approach
                 * But succeeded in all test cases
                string xS = Convert.ToString(x, 2);
                bool[] bits = new bool[32];
                int j = bits.Length - 1;

                for (int i = xS.Length - 1; i >= 0; i--)
                {
                    bits[j] = xS[i] == '1' ? true : false;
                    j--;
                }

                xS = "";
                for (int i = 0; i < bits.Length; i++)
                {
                    xS += Convert.ToInt16(!bits[i]);
                }
                
                Console.WriteLine(Convert.ToUInt32(xS, 2));
                 
                 */

                /*
                 * Better Solution
                 * If maxInt is the maximum value an integer can have, subtracting the original number will give you the complement. 
                 * For example: If the input number is 6, that's 110 (00000110) in binary. 11111111 - 00000110 = 11111001, 
                 * which, as you can see, is the input value's flipped bits.

                UInt32 max = Convert.ToUInt32(Math.Pow(2, 32) - 1); // Should be placed outside the loop
                Console.WriteLine(max - x);

                 */

                /*
                 * Here we are XOR'in with 0 (x ^ 0 = x) followed by a NOT
                 */

                Console.WriteLine(~(x ^ 0));
                 
            }
            

            //UInt32 x = Convert.ToUInt32(Math.Pow(2, 32) - 1);
            //Console.WriteLine(x - x5);

            /*uint x = 1;
            uint res = ~(x ^ 0);
            Console.WriteLine(res);*/


        }
    }
}
