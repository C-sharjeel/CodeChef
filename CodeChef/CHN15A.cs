using System;

namespace CodeChef
{
	public class CHN15A : Run
	{
		public void run(){

			int[] input = Array.ConvertAll(Console.ReadLine ().Split(' '),Int32.Parse);

			int[] minions = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
			int result = solve (input[0], input[1], minions);
			Console.WriteLine (result);
		}

		public int solve(int n,int k, int[] minions){

			int count = 0;
			for (int i = 0; i < n; i++) {
				if((minions[i]+k) % 7 ==0)
						count++;
			}
			return count;
		}
	}
}

