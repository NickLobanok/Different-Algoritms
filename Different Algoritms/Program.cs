using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Different_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllAsterisk(5); 
          //  OrderNum(5);
            Console.WriteLine();
           // OrderInARow(10);
           // SameLatters(5);
            LatterSeq(5);
            Console.WriteLine();
            LessNum(5);
            LessNumInRow(5);
            Console.WriteLine();
            LessLetter(5);
            Console.WriteLine("Буквы на уменьшение в строке\n");
            LessLetterInRow(10);
            Console.WriteLine();
            AsteriskPyrmids(6);
            NumPuramid(10);
            NumInRowPyramids(9);
        }

        static void AllAsterisk(int elAmount)
        {
            int emountsOfElemenents = elAmount;
            for (int i = 0; i < emountsOfElemenents; i++)
            {

                for (int j = 0; j < emountsOfElemenents; j++)

                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        static void OrderNum(int elAmount)
        {
            int elemAmount = elAmount;
            for (int i = 1; i <= elemAmount; i++)
            {
                for (int j = 1; j <= elemAmount; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }

        static void OrderInARow(int elAmount)
        {
            for (int i = 1; i <= elAmount; i++)
            {
                for (int j = 1; j <= elAmount; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void SameLatters(int amountOfLatters)
        {
            char nextChar = 'A';
            int charReturn ;

           
            for (int i = 0; i < amountOfLatters; i++)
            {
                for (int j = 0; j < amountOfLatters; j++)
                {
                    charReturn = nextChar + i;
                    Console.Write((char)charReturn+" ");
                }
                Console.WriteLine();
            }
        }

        static void LatterSeq(int amountOfLatters)
        {
            char firstLatter = 'A';
            int retLatters;
            for (int i = 0; i < amountOfLatters; i++)
            {
                for (int j = 0; j < amountOfLatters; j++)
                {
                    retLatters = firstLatter + j;
                    Console.Write((char)retLatters + " ");
                }
                Console.WriteLine();
            }
        }
        // одно число в строку в порядке убывания
        static void LessNum(int amountOfLatters)
        {
            for (int i = amountOfLatters; i > 0; i--)
            {
                for (int j = 1 ; j <= amountOfLatters ; j ++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        // одно число в строку в порядке убывания
        static void LessNumInRow(int amountOfLatters)
        {
            for (int i = 1; i <= amountOfLatters; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void LessLetter(int amountOfLetters)
        {
           
            char ch = 'A';
            for (int i = amountOfLetters-1; i >= 0; i--)
            {
                int res ;
                for (int j = 1; j < amountOfLetters; j++)
                {
                    res = 'a' + i;
                    Console.Write( (char)res  + " ");
                }
                Console.WriteLine();
            }
        }

        static void LessLetterInRow(int amountOfLetters)
        {
            int res;
            for (int i = 1; i < amountOfLetters; i++)
            {
                for (int j = amountOfLetters-1; j >= 0; j--)
                {
                    res = 'A' + j;
                    Console.Write((char)res + " ");
                }
                Console.WriteLine();
            }
        }

        static void AsteriskPyrmids(int amountOfStages)
        {
            for (int i = 0; i <= amountOfStages; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void NumPuramid(int stageAmount)
        {
            for (int i = 1; i <= stageAmount; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void NumInRowPyramids(int stageAmount)
        {
            for (int i = 1; i < stageAmount + 1; i++)
            {
                
                for (int j = i , h = 1; j > 0; j--)
                {
                    Console.Write(h + " ");
                    h++;
                }
                Console.WriteLine();
                
            }
        }
    }

    

}
