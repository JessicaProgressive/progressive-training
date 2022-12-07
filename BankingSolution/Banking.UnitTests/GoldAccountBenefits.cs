using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banking.Domain.BankAccount;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Theory]
        [InlineData(100, 5110)]
        public void GetBonusOnDeposit(decimal amountToDeposit, decimal expectedBalance)
        {
            var account = new BankAccount();
            account.AccountType = BankAccountType.Gold;

            account.Deposit(amountToDeposit);
            var actualBalance = account.GetBalance();

            Assert.Equal(expectedBalance, actualBalance);
        }
    }
}
