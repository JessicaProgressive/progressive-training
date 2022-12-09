using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {

        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
        {
            return currentBalance >= 5000 ? amountOfDeposit * .10M : 0;
        }
    }
}
