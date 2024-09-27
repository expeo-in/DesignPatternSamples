using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Template.Solution
{
    public abstract class Task
    {
        private AuditTrail auditTrail;
        public Task()
        {
            auditTrail = new AuditTrail();
        }

        public void Execute()
        {
            auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
