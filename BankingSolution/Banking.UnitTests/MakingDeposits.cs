using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests;

public class MakingDeposits
{
    [Fact]
    public void MakingDepositsIncreasesBalance()
    {
        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(amountToDeposit + openingBalance,
            account.GetBalance());
    }
}
