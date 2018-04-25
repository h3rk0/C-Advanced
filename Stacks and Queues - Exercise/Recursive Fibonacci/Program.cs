using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recursive_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			cache.Add(0, 0);
			cache.Add(1, 1);
			var n = int.Parse(Console.ReadLine());
			//var result = FibonacciIterative(n);
			var result2 = recursiveFib(n);
			Console.WriteLine(result2);
		}
		static Dictionary<int, long> cache = new Dictionary<int, long>();

		static long recursiveFib(int n)
		{
			long result;
			if (cache.TryGetValue(n, out result))
				return result;
			
			result = recursiveFib(n - 2) + recursiveFib(n - 1);
			cache.Add(n, result);
			return result;
		}
	}
}
