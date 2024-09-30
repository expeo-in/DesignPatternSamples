using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Command.Solution
{
    public class AddCustomerCommand : ICommand
    {
        CustomerService customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}
