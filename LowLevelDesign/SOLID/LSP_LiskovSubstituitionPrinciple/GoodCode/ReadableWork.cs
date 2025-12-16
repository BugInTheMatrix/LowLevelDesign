using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.GoodCode
{
    public class ReadableWork : Readable
    {
        public virtual void read()
        {
            Console.WriteLine("Reading data from readable work");
        }
    }

}
