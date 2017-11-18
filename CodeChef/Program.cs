using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace CodeChef
{
    class Program
    {
        static void Main(string[] args)
        {
            //T is number of test cases 
            int T = Convert.ToInt32(Console.ReadLine());
			Run runner;
            //Solve for CFRTEST
            //runner = new CFRTEST();

            //Solve for CHEFARRP
            //runner = new CHEFARRP();

			//Solve for LECANDY
			//runner = new LECANDY();

			//Solve for CNOTE
			//runner = new CNOTE();

			//Solve for SALARY
			//runner = new SALARY();

			//Solve for CHN15A
			//runner = new CHN15A();

			//solve for FRGTNLNG
			//runner = new FRGTNLNG();

			//solve for COPS
			runner = new COPS();
            for (int i = 0; i < T; i++)
            {
                runner.run();
            }
            Console.ReadLine();
        }
    }
}
