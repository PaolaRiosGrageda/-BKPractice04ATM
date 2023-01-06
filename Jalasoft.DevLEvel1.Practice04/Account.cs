using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice04
{
    public class Account: IAccount
    {
        private double AccountBalance=0;
        private List<Operation> Operations=new List<Operation>();

        public void ShowBalance()
        {
            throw new NotImplementedException();
        }

        public int Deposit()
        {
            throw new NotImplementedException();
        }

        public void ShowOperation()
        {
            throw new NotImplementedException();
        }

        public double Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
