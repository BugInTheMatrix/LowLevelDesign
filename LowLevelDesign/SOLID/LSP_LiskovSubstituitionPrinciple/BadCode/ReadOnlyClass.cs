using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.BadCode
{
    public class ReadOnlyClass:File
    {
        public override void write()
        {
            throw new Exception("Can't write to a read only file");
        }
    }
}
