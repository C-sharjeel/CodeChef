using System;

namespace CodeChef
{
	public class CNOTE : Run
	{
		int Required_pages;
		int Available_pages;
		int bugdet;
		int num_notebooks;
		//int[][] notebooks_cost;

		const int pages = 0;
		const int cost = 1;

		public void run(){

			int[] input1 = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);

			Required_pages = input1 [0];
			Available_pages = input1 [1];
			bugdet = input1 [2];
			num_notebooks = input1 [3];
			//notebooks_cost = new int[num_notebooks][];

			//for (int i = 0; i < num_notebooks; i++) {
				//notebooks_cost [i] = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
			//}

			string result = solve (Required_pages, Available_pages, bugdet, num_notebooks);
			Console.WriteLine (result);
		}

		public string solve (int Required_pages, int Available_pages, int bugdet, 
							int num_notebooks )
		{
		
			int extra_pages_required = Required_pages - Available_pages;

			for (int i = 0; i < num_notebooks; i++) {
				int[] notebooks_cost = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
				if (extra_pages_required <= notebooks_cost[pages] && bugdet >= notebooks_cost[cost])
					return "LuckyChef";
			}

			return "UnluckyChef";
		}

	}
}

