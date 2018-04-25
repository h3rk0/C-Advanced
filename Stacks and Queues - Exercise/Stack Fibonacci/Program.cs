using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = long.Parse(Console.ReadLine());
			var stack = new Stack<long>();
			stack.Push(0);
			stack.Push(1);
			for (int i = 1; i < n; i++)
			{
				var last = stack.Pop();
				var beforeLast = stack.Peek();
				var next = last + beforeLast;
				stack.Push(last);
				stack.Push(next);
			}
			Console.WriteLine(stack.Peek());
		}
	}
}
