using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinExampleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            JoinDemonstration app = new JoinDemonstration();

            app.InnerJoin();
            app.GroupJoin();
            app.GroupInnerJoin();
            app.GroupJoin3();
            app.LeftOuterJoin();
            app.LeftOuterJoin2();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


}
