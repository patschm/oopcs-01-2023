using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace Collecties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            //Stringent();
            OverigeCollecties();
        }

        private static void OverigeCollecties()
        {
            //ArrayList list2= new ArrayList();
            //list2.Add(1)
            //list2[0] = 1;
            //list2[1] = 2;
            //list2[2] = 3;
            //list2[3] = "4";

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            list.Add(11);
            Console.WriteLine(list[3]);

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int tmp = stack.Pop();
            Console.WriteLine(tmp);
            Console.WriteLine(stack.Count);

            Queue<long> queue = new Queue<long>();  
            queue.Enqueue(1);
            queue.Enqueue(2);

            long tmp2 = queue.Dequeue();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("een", 1);
            dict.Add("twee", 2);

            Console.WriteLine(dict["twee"]);
        }

        private static void Stringent()
        {
            Stopwatch sw = new Stopwatch();
            //string name = "";
            StringBuilder name = new (10000);

            sw.Start();
            for(int i = 0; i < 100000; i++)
            {
                name.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        private static void Arrays()
        {
            int[] kluisjes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //kluisjes[0] =
            //1;
            //kluisjes[9] = 10;

            Console.WriteLine(kluisjes[5]);

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(matrix[1, 2]);

            int[,,] kubus = new int[3, 3, 3];

            //int[,,]

            int[][] jagged = new int[3][];
            jagged[0] = new int[10];
            jagged[1] = new int[5];
            jagged[2] = kluisjes;

            Console.WriteLine(jagged[2][3]);

            for (int i = 0; i < kluisjes.Length; i++)
            {
                int tmp = kluisjes[i];
                Console.WriteLine(tmp);
            }

            foreach (int tmp in kluisjes)
            {
                Console.WriteLine(tmp);
            }

        }
    }
}