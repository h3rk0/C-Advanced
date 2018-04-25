using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Element
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			Stack<int> stack = new Stack<int>();
			Stack<int> maxNumbers = new Stack<int>();

			var max = int.MinValue;

			maxNumbers.Push(int.MinValue);

			for (int i = 0; i < n; i++)
			{
				var command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

				if (command[0] == 1)
				{
					if (command[1] > maxNumbers.Peek())
					{
						maxNumbers.Push(command[1]);
					}
					stack.Push(command[1]);
				}
				else if (command[0] == 2)
				{
					if (stack.Peek() == maxNumbers.Peek())
					{
						maxNumbers.Pop();
					}
					stack.Pop();

				}
				else if (command[0] == 3)
				{
					Console.WriteLine(maxNumbers.Peek());
				}

			}
		}
	}
}
