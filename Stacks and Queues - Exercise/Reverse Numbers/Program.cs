using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Stacks_and_Queues
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputArr = Console.ReadLine().Split(' ').ToArray();

			var stack = new Stack<string>(inputArr);

			var sb = new StringBuilder();

			while (stack.Count > 0)
			{
				sb.Append(stack.Pop() + " ");
			}


			Console.WriteLine(sb);

		}
	}
}
