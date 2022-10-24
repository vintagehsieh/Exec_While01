using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01_Q2
{
	internal class Program
	{
		/// <summary>
		/// Q2: 使用 while , 在畫面顯示所有可以整除 300 的整數
		/// 例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
		/// </summary>

		static void Main(string[] args)
		{
			int n = 0;

			Console.WriteLine("可以整除300的數字有: ");
			while ( n < 300)
			{
				n++;
				if ( 300 % n ==0)
				Console.WriteLine(n);
			}
		}
	}
}
