using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice04
{
    public class Account : IAccount
    {
        private double accountBalance = 0;
        private List<Operation> Operations = new List<Operation>();

        public void Deposit(int amount)
        {
            var total=accountBalance += amount;
            Operations.Add(new Operation(){InitialBalance=accountBalance,EndBalance= total,Amount=amount,TransactionType= OperationType.Deposit });

        }
        public void ShowBalance() => Console.WriteLine("The account balance is:{0}", accountBalance);

        public void ShowOperation(double mount)
        {
            var query = Operations.Where(item => item.EndBalance >= mount);
            foreach (var item in query)
            {
                Console.WriteLine("The transactions is grester than {0}, are :{1}", mount, item);
            }
        }
        public void ShowOperation()
        {
            Operations.ForEach(x => x.Show());
        }
        public double Withdraw(double amount) => accountBalance -=amount;
        
    }
}
