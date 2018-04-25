using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Queue_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int push = input[0];

			int pop = input[1];

			int check = input[2];

			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Queue<int> queue = new Queue<int>();

			Queue<int> smallest = new Queue<int>();

			smallest.Enqueue(int.MaxValue);

			for (int i = 0; i < push; i++)
			{
				if (smallest.Peek() > numbers[i])
				{
					smallest.Dequeue();
					smallest.Enqueue(numbers[i]);
				}
				queue.Enqueue(numbers[i]);
			}

			for (int i = 0; i < pop; i++)
			{
				if (smallest.Peek() == queue.Peek())
				{
					smallest.Dequeue();
					if (smallest.Count == 0)
					{
						smallest.Enqueue(int.MaxValue);
					}
				}
				queue.Dequeue();
			}

			if (smallest.Peek() == int.MaxValue)
			{
				smallest.Dequeue();
			}

			if (queue.Contains(check))
			{
				Console.WriteLine("true");
				return;
			}

			if (queue.Count == 0)
			{
				Console.WriteLine(0);
				return;
			}

			Console.WriteLine(smallest.Peek());

		}
	}
}
