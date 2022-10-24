using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01_Q1
{
	internal class Program
	{
		/// <summary>
		/// Exec_While01
		/// Q1: 1+ 2 + 3 + 4 + .... + N < 105
		/// 請問 N 是多少?
		/// </summary>

		static void Main(string[] args)
		{
			int sum = 0;
			int i = 1;

			do
			{
				sum += i;
				i++;
			} while (sum < 105);

			if (sum >= 105)
			{
				Console.WriteLine($"N值為{i - 1}");
			}
			else
			{
				Console.WriteLine($"N值為{i}");
			}
		}
	}
}
