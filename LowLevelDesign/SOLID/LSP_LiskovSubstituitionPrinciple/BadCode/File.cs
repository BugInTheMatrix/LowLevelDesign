using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.LSP_LiskovSubstituitionPrinciple.BadCode
{
    public class File
    {
        public virtual void read()
        {
            Console.WriteLine("reading from file...");
        }
        public virtual void write()
        {
            Console.WriteLine("Writing to file...");
        }

    }
}
