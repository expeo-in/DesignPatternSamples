using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Template.Problem
{
    public class TransferMoneyTask
    {
        private AuditTrail auditTrail;

        public TransferMoneyTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();

            Console.WriteLine("Transfer money");
        }
    }
}
