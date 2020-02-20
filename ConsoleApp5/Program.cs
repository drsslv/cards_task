using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp5
{
    class Program
    {
        static byte Min(Queue<byte> que)
        {
            byte min = 101;

            while (que.Count > 0)
            {
                byte element = que.Dequeue();
                if (min > element) min = element;
            }
            return min;

        }
        
        static Queue<byte> Copy(Queue<byte> cards)
        {
            var bytes = cards.ToArray();
            return new Queue<byte>(bytes);
        }
        static void Main(string[] args)
        {
         
            byte a = byte.Parse(Console.ReadLine());
            Queue<byte> cards = new Queue<byte>();
            var line = Console.ReadLine().Split(' ');
            for (int i = 0; i < a; i++)
            {
                cards.Enqueue(byte.Parse(line[i]));

            }
            byte sum = 0;
   
            while (cards.Count > 0)
            {
                sum++;
                var que = Copy(cards);
                byte currentmin = Min(que);
                if (currentmin == cards.Peek())
                {
                    cards.Dequeue();
                }
                else
                {
                    cards.Enqueue(cards.Peek());
                    cards.Dequeue();
                }
            }
            Console.WriteLine(sum);
            

        }
    }
}
