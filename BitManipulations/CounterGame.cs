namespace BitManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * Louise and Richard play a game. They have a counter set to N. Louise gets the first turn and the turns alternate thereafter. In the game, they perform the following operations.
     * If N is not a power of 2, reduce the counter by the largest power of  less than .
     * If N is a power of 2, reduce the counter by half of N.
     * The resultant value is the new N which is again used for subsequent operations.
     * The game ends when the counter reduces to 1, i.e., N == 1 , and the last person to make a valid move wins.
     * 
     * Given N, your task is to find the winner of the game.
     * 
     * Update If they set counter to 1, Richard wins, because its Louise' turn and she cannot make a move. 
     */


    class CounterGame : AbstractBase
    {
        public override void Execute()
        {
            int t = Convert.ToInt32("10");
            UInt64 N = 0;
            bool isLouise = false;

            List<string> temp = "17488958049258225102\n8397603399295484595\n9507393731223901740\n5166941619374154799\n140737488355328\n3392750628096388017\n2305843009213693952\n12935953512692493379\n4194304\n1099511627776".Split(new char[] { '\n' }).ToList();


            for (int i = 0; i < temp.Count; i++)
            {
                N = Convert.ToUInt64(temp[i]);

                while (N != 1)
                {
                    isLouise = !isLouise;

                    // The numbers which are power of 2 , have this unique property , that in binary format , they have exactly one bit set to '1' and rest are all '0's 
                    // So we can determine whether a number is a power of 2 , by checking whether the number has just one bit set or not
                    // Now for a number N ,  the operation N & ( N - 1 )  , removes the right most '1' Eg N = 8 (1000), (N - 1) = 111
                    // So for a number that is a power of 2 , since there will be exactly a single '1' , hence the above mentioned operation would result in it becoming a '0' and hence the entire value will be zero. 
                    // However when N = 0 , then too the above check would return true , obviously which is not correct . ( N != 0 ) && ( N & ( N - 1 ) == 0 )
                    // Ref: http://www.algo-faq.com/Bitwise-Operators/Using-bitwise-operators-determine-if-a-number-is-a-power-of-2.php

                    if ((N & (N - 1)) == 0)
                    {
                        N = N / 2;
                    }
                    else
                    {
                        int count = -1;
                        UInt64 legacyN = N;

                        // To find the largest power of 2 less than N, Eg: 21 (10101), count the number of bits minus 1 and left shift to 1, 16 (10000)
                        // Right shift till N becomes 0, then left shift to that count for the number which is a power of 2 less then N

                        while (N > 0)
                        {
                            count++;
                            N >>= 1;
                        }
                        N = (ulong)1 << count;
                        N = legacyN - N;
                    }
                }

                Console.WriteLine(isLouise ? "Louise" : "Richard");
                isLouise = false;

            }
        }
    }
}
