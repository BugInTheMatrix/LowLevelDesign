using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.BadCode
{
    public class Main
    {
        public Main()
        {
            ReadOnlyClass readOnlyClass = new ReadOnlyClass();
            readOnlyClass.read();
            readOnlyClass.write(); // not good
        }
    }
}
