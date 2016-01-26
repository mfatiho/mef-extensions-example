using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using mef_extensions;
using mef_extenstions_example_contracts;

namespace mef_extensions_example
{
    public class Importer : ImporterBase
    {
        [ImportMany(AllowRecomposition = true)]
        private IEnumerable<Lazy<IComponent, IMetadata>> _operations;

        public int AvailableNumberOfOperation
        {
            get { return _operations != null ? _operations.Count() : 0; }
        }

        public List<string> CallAllComponents(params double[] args)
        {
            var result = new List<string>();

            foreach (Lazy<IComponent, IMetadata> com in _operations)
            {
                Console.WriteLine(com.Value.Description);
                Console.WriteLine(com.Metadata.Symbol);
                result.Add(com.Value.ManipulateOperation(args));
            }

            return result;
        }
    }
}