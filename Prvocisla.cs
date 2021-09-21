using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
	public class Prvocisla
	{
		Random rd = new Random();
		private int number;

		public void NajdiPrvocislo(int number)
		{
			this.number = number;
			int i, j, p;
			int[] array = new int[number];

			
			for (i = 0; i < number; i++)
			{
				array[i] = i + 1;
			}

			Console.Write("Všechna prvočísla před číslem " + number + " jsou: ");
			for (i = 0; i < number; i++)
			{
				j = 2;
				p = 1;
				while (j < array[i])
				{
					if (array[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}

				if (p == 1)
				{
					Console.Write(array[i] + " ");
				}
			}
		}
	}
}


