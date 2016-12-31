using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanPlz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lol = { 1, 2, 3, 4, 5, 6 };
            Span<int> span1 = new Span<int>(lol);
            var span2 = span1.Slice(2, 4);

            for (int i = 0; i < span2.Length; i++)
            {
                Console.WriteLine(span2[i]);
            }

            Console.ReadLine();
        }
    }
}
