using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj = 0;
			while (broj < 10)
			{
				Console.WriteLine(++broj);
			}

			Console.WriteLine("------------------");

			broj = 0;
			do
			{
				Console.WriteLine(broj++);
			} while (broj < 10);

			Console.WriteLine("------------------");

			for (; broj > 0; broj-- )
			{
				Console.WriteLine(broj);
			}
			Console.WriteLine("------------------");

			broj = 0;
			while (broj <= 100)
			{
				broj++;
				if (broj < 10)
				{
					continue;
				}

				if (broj % 2 == 0)
				{
					Console.WriteLine(broj);
				}
				
				if (broj == 75)
				{
					break;
				}
			}

			/* Beskonacne petlje
			for (;;)
			{
				Console.WriteLine(broj);	
			}
			while(true)
			{
				Console.WriteLine(broj);
			}*/

			Console.ReadKey();
		}
	}
}
