using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mef_extensions_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Importer importer = new Importer();

            importer.Init("..\\..\\..\\..\\..\\plugins.yml");

            do
            {
                Console.WriteLine("{0} component(s) are imported successfully.", importer.AvailableNumberOfOperation);

                List<string> result = importer.CallAllComponents(125, 5, 10, 27, 45, 19, 10);

                foreach (string s in result)
                {
                    Console.WriteLine(s);
                }

            } while (Console.ReadLine() != "exit");
        }
    }
}
