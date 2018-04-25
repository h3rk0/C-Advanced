using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot_Potato
{
	class Program
	{
		static void Main(string[] args)
		{
			var players = Console.ReadLine().Split(' ').ToList();

			var queue = new Queue<string>(players);

			var cycle = int.Parse(Console.ReadLine());

			while (queue.Count > 1)
			{
				for (int i = 0; i < cycle - 1; i++)
				{
					queue.Enqueue(queue.Dequeue());
				}
				Console.WriteLine($"Removed {queue.Dequeue()}");

				//Console.WriteLine(string.Join(" ",queue));
			}

			Console.WriteLine($"Last is {queue.Dequeue()}");

		}
	}
}
