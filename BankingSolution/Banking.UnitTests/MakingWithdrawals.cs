using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(200, 4800)]
        public void MakingWithrawalsDecreasesBalance(decimal amountToWithdraw, decimal expected)
        {
            // Arrange
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            // Act
            account.Withdraw(amountToWithdraw);
            decimal actualBalance = openingBalance - amountToWithdraw;
            // Assert
            Assert.Equal(expected, actualBalance);
        }
    }
}
