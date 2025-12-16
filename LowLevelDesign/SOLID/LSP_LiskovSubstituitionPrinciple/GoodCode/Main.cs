using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.GoodCode
{
    public class Main
    {
        public Main()
        {
            ReadableWork readableWork = new ReadOnly();
            readableWork.read();
            WritableWork writableWork = new WritableWork();
            writableWork.read();
            writableWork.write();
        }
    }
}
