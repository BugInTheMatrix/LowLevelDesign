using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.ISP_InterFaceSegregationPrinciple.BadCode
{
    public class Printer : IMachine
    {
        void IMachine.Fax()
        {
            throw new NotImplementedException();
        }

        void IMachine.Print()
        {
            Console.WriteLine("Printing document...");
        }

        void IMachine.Scan()
        {
            throw new NotImplementedException();
        }
    }
}
