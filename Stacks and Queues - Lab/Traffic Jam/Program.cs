using System;
using System.Collections;

namespace Traffic_Light
{
	class Program
	{
		static void Main(string[] args)
		{
			int passingCount = int.Parse(Console.ReadLine());

			Queue passingCars = new Queue();

			int totalPassed = 0;

			int passedCount = 0;

			while (true)
			{
				var input = Console.ReadLine().TrimEnd();

				if (input == "end")
				{
					break;
				}


				if (input == "green")
				{
					if (passingCars.Count == 0)
					{
						continue;
					}



					while (passingCars.Count > 0)
					{
						var passedCar = passingCars.Dequeue();

						if (passingCount == 0)
						{
							continue;
						}

						Console.WriteLine($"{passedCar} passed!");

						passedCount++;

						totalPassed++;

						if (passedCount == passingCount)
						{
							passedCount = 0;
							break;
						}
					}
				}
				else
				{
					var passingCar = input;

					passingCars.Enqueue(passingCar);
				}

			}

			Console.WriteLine($"{totalPassed} cars passed the crossroads.");
		}

	}
}
