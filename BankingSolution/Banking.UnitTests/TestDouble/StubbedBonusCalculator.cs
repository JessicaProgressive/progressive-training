using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.TestDoubles;



// Canned responses to questions.
public class StubbedBonusCalculator : ICalculateBonuses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return currentBalance == 5000M && amountOfDeposit == 92.42M ? 42 : 0;
    }
}
