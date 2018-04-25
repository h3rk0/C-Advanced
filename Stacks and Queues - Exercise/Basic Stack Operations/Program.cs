using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var stack = new Stack<int>();

			var pushCount = input[0];

			var popCount = input[1];

			var check = input[2];

			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = 0; i < pushCount; i++)
			{
				stack.Push(numbers[i]);
			}

			for (int i = 0; i < popCount; i++)
			{
				stack.Pop();
			}

			if (stack.Contains(check))
			{
				Console.WriteLine("true");
				return;
			}

			if (stack.Count == 0)
			{
				Console.WriteLine(0);
				return;
			}

			var smallest = int.MaxValue;

			while (stack.Count > 0)
			{
				var poped = stack.Pop();

				if (smallest > poped)
				{
					smallest = poped;
				}
			}

			Console.WriteLine(smallest);
		}
	}
}
