using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01Day01Conrarian
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement, contra;
            int j;
            Console.WriteLine("Enter a ststement using the format I do like [   ]. or I don't like [   ].");
            statement = Console.ReadLine();

            string[] mixing = statement.Split(' ');

            /*if (mixing[1] == "don't")
            {
                mixing[1] = "do";
                /*for(int i = 0; i < mixing.Length; i++){
                    Console.WriteLine(mixing[i]);
                }
                Console.WriteLine(String.Join(" ", mixing));
            }
            else if (mixing[1] == "do")
            {
                mixing[1] = "don't";
                /*for(int i = 0; i < mixing.Length; i++){
                    Console.WriteLine(mixing[i]);
                }
                Console.WriteLine(String.Join(" ", mixing));
            }*/

            for (j = 0; j < mixing.Length; j++)
            {
                if (mixing[j] == "like" && mixing[j - 1] != "do")
                {
                    mixing[j] = "don't like";
                }
                else if (mixing[j] == "don't")
                {
                    mixing[j] = "do";

                }
                else if (mixing[j] == "do")
                {
                    mixing[j] = "don't";
                }
                else if (mixing[j] == "hate")
                {
                    mixing[j] = "love";
                }
                else if (mixing[j] == "love")
                {
                    mixing[j] = "hate";
                }
                else if (mixing[j] == "horrible")
                {
                    mixing[j] = "beautiful";
                }
                else if (mixing[j] == "beautiful")
                {
                    mixing[j] = "horrible";
                }
            }

            Console.WriteLine(String.Join(" ", mixing));


                Console.ReadKey();


        }
    }
}
