using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Theory]
        [InlineData(100, 5110)]
        public void GoldBonusDeposit(decimal amountToDeposit, decimal expectedBalance)
        {
            var account = new GoldAccount();

            account.Deposit(amountToDeposit);
            var actualBalance = account.GetBalance();

            Assert.Equal(expectedBalance, actualBalance);

        }
    }
}
