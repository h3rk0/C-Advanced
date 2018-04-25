using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var stack = new Stack<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(')
				{
					stack.Push(i);
				}

				if (input[i] == ')')
				{
					var startIndex = stack.Pop();

					var endIndex = i;

					for (int j = startIndex; j <= endIndex; j++)
					{
						Console.Write(input[j]);
					}
					Console.WriteLine();
				}
			}

			Console.WriteLine();
		}
	}
}
