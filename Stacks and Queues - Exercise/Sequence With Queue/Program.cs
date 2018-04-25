using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Sequence_with_Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = long.Parse(Console.ReadLine());

			Queue<long> queue = new Queue<long>();

			queue.Enqueue(input);

			for (int i = 0; i < 16; i++)
			{
				queue.Enqueue(queue.ElementAt(i) + 1);
				queue.Enqueue(2 * queue.ElementAt(i) + 1);
				queue.Enqueue(queue.ElementAt(i) + 2);
			}



			var last = queue.ElementAt(16) + 1;

			queue.Enqueue(last);

			Console.WriteLine(string.Join(" ", queue));
		}
	}
}
