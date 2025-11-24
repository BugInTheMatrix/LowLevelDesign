using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.SRP_SIngleResponsibilityPrinciple.GoodCode
{
    public class EmailService
    {
        public void sendEmailNotification()
        {
            Console.WriteLine("Sending email notification for invoice ");
        }
    }
}
