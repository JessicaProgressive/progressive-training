using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class MakingDeposits
{
    [Fact]
    public void MakingDepositsIncreasesBalance()
    {
        // Given
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(amountToDeposit + openingBalance,
            account.GetBalance());
    }
}
