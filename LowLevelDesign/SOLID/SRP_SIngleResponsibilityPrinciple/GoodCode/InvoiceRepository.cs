using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.SRP_SIngleResponsibilityPrinciple.GoodCode
{
    public class InvoiceRepository
    {
        public void saveToDatabase()
        {
            Console.WriteLine("Saving invoice to Database ");
        }
    }
}
