using System;

namespace CodeChef
{
	public class SALARY : Run
	{
		public void run(){
		
			int n = Convert.ToInt32 (Console.ReadLine ());
			int[] Wages = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);

			int result = solve (n, Wages);
			Console.WriteLine (result);
		}

		public int solve(int n, int[] Wages){
		
			int min = Wages[0];
			for (int i = 0; i < n; i++) {
				if (min > Wages [i])
					min = Wages [i];
			}
			int count = 0;
			for (int i = 0; i < n; i++) {
				count += (Wages [i] - min);
			}

			return count;
		}
	}
}

