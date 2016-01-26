using System.ComponentModel.Composition;
using mef_extenstions_example_contracts;

namespace mef_extensions_example_export_sum
{
    [Export(typeof(IComponent))]
    [ExportMetadata("Symbol", '+')]
    public class SumComponent : IComponent
    {
        public string Description
        {
            get { return "Sum of components"; }
        }

        public string ManipulateOperation(params double[] args)
        {
            string result = "";
            double count = 0;
            bool first = true;

            foreach (double d in args)
            {
                if (first)
                {
                    count = d;
                    first = false;
                }
                else
                    count += d;
                result += string.Format("{0} + ", d);
            }

            return string.Format("{0} = {1}", result.Trim('+', ' '), count);
        }
    }
}
