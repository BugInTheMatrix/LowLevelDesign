using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.GoodCode
{
    public class WritableWork : ReadableWork , Writable
    {
        public virtual void write()
        {
            Console.WriteLine("Writing data to writable work");
        }
        public override void read()
        {
            Console.WriteLine("Reading data from writable work");
        }
    }
}
