using System;

namespace CodeChef
{
	public class LECANDY : Run
	{
		int Elephants;
		int Candies;
		int[] WishList;

		public void run(){

			int[] input1 = Array.ConvertAll(Console.ReadLine ().Split (' '), Int32.Parse);
			WishList = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
			Elephants = input1 [0];
			Candies = input1 [1];
			string result = solve (Elephants, Candies, WishList);
			Console.WriteLine (result);
		}

		public string solve(int Elephants, int Candies, int[] WishList){
		
			if (WishList.Length != Elephants)
				return "No";
			
			foreach (int candyWish in WishList) {
				if (Candies < candyWish) {
					return "No";
				}
				Candies -= candyWish;
			}
			return "Yes";
		}
	}
}

