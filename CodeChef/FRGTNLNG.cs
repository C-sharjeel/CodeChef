using System;

namespace CodeChef
{
	public class FRGTNLNG: Run
	{
		public void run(){

			int[] input = Array.ConvertAll (Console.ReadLine ().Split (' '), Int32.Parse);
			int N = input [0];
			int K = input [1];
			string[] forgotten = Console.ReadLine ().Split (' ');
			string[] phrases = new string[K];

			for (int i = 0; i < K; i++) {
				phrases [i] = Console.ReadLine ();
			}

			string[] result = solve (N, K, forgotten, phrases);
			foreach (string r in result)
				Console.Write (r + " ");
			Console.WriteLine ();
		}

		public string[] solve(int n, int k, string[] forgotten, string[] phrases){
		
			string[] result = new string[n];
			for(int i=0;i<n;i++)
				result[i] = "NO";

			for (int i = 0; i < n; i++) {
				string word = forgotten [i];
				foreach(string phrase in phrases){
					if(phrase.Contains(word)){
						result [i] = "YES";
						break;
					}
				}
			}
			return result;
		}
		
	}
}

