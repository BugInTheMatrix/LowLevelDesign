using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.ISP_InterFaceSegregationPrinciple.GoodCode
{
    public class MulitPruposeMachine : IPrint, IScan
    {
        public void Scan()
        {
        }

        public void  Print()
        {
        }
    }
}
