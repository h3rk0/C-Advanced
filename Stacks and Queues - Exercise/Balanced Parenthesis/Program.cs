using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Parentheses
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToCharArray();


			var stack = new Stack<char>();

			for (int i = 0; i < input.Length; i++)
			{
				if (stack.Count == 0 && input[i] == '}' || stack.Count == 0 && input[i] == ')' ||
					stack.Count == 0 && input[i] == ']')
				{

					Console.WriteLine("NO");
					return;

				}


				if (input[i] == '{' || input[i] == '[' || input[i] == '(')
				{
					stack.Push(input[i]);
				}
				else if (input[i] == '}' && stack.Peek() != '{')
				{

					Console.WriteLine("NO");
					return;


				}
				else if (input[i] == ']' && stack.Peek() != '[')
				{
					Console.WriteLine("NO");
					return;
				}
				else if (input[i] == ')' && stack.Peek() != '(')
				{
					Console.WriteLine("NO");
					return;
				}
				else
				{
					stack.Pop();
				}

			}

			Console.WriteLine("YES");

		}
	}
}
