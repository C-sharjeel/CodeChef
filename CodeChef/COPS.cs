using System;

namespace CodeChef
{
	public class COPS : Run
	{
		public void run(){
			int[] input = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
			int[] Cop_Houses = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);

			int result = solve (input [0], input [1], input [2], Cop_Houses);
			Console.WriteLine (result);
		}

		public int solve(int M, int x, int y, int [] Cop_Houses){
			int range = x * y;
			int safeHouse_Count = 0;

			for (int i = 0; i < M; i++)
				for (int j = i; j < M; j++) {
					if (Cop_Houses [i] > Cop_Houses[j]) {
						int temp = Cop_Houses [j];
						Cop_Houses[j] = Cop_Houses[i];
						Cop_Houses [i] = temp;
					}
				}
			//for (int i = 0; i < M; i++)
			//	Console.Write(Cop_Houses [i]);
			//Console.WriteLine ();
			int index = 1;
			for (int i = 0; i < M; i++) {
				if (index + range >= Cop_Houses [i])
					index = Cop_Houses [i]+range;
				else {
					index = index + range;
					safeHouse_Count += Cop_Houses [i]-1 - index;
					index = Cop_Houses [i];
				}
			}
			safeHouse_Count += (Cop_Houses [M-1] + range >= 100) ? 0 : 100 - (Cop_Houses[M-1] + range);
			return safeHouse_Count;
		}
	}
}

