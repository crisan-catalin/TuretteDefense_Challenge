﻿using System;

namespace TuretteDefense_Challenge
{
	internal class Program
	{
		private static void Main()
		{
			var turretDefense = new TurretDefense();
			Console.WriteLine(turretDefense.FirstMiss(new[] {3, 5, 6}, new[] {7, 5, 6}, new[] {11, 15, 16}));

			Console.WriteLine(turretDefense.FirstMiss(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16},
				new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16},
				new[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32}));

			Console.WriteLine(turretDefense.FirstMiss(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16},
				new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16},
				new[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 31}));

			Console.WriteLine(turretDefense.FirstMiss(
				new[]
				{
					1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000,
					0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0
				},
				new[]
				{
					1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000,
					0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0, 1000, 0
				},
				new[]
				{
					2000, 4000, 6000, 8000, 10000, 12000, 14000, 16000, 18000, 20000, 22000, 24000, 26000, 28000, 30000, 32000, 34000,
					36000, 38000, 40000, 42000, 44000, 46000, 48000, 50000, 52000, 54000, 56000, 58000, 60000, 62000, 64000, 66000,
					68000, 70000, 72000, 74000, 76000, 78000, 80000, 82000, 84000, 86000, 88000, 90000, 92000, 94000, 96000, 98000,
					100000
				}));

			Console.WriteLine(turretDefense.FirstMiss(new[] {4, 5},
				new[] {4, 5},
				new[] {7, 8}));

			Console.WriteLine(turretDefense.FirstMiss(new[] {1, 2, 3, 4, 15},
				new[] {1, 2, 3, 4, 15},
				new[] {100, 200, 300, 400, 405}));
		}
	}
}