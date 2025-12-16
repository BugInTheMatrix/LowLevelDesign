using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.ISP_InterFaceSegregationPrinciple.BadCode
{
    public class MultiPraposeMachine : IMachine
    {
        public void Fax()
        {
        }

        public void Print()
        {
        }

        public void Scan()
        {
        }
    }
}
