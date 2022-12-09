using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class NewAccounts
{
    [Fact]
    public void HaveTheCorrectOpeningBalance()
    {
        // Write the Code You Wish You Had (WTCYWYH)v
        // Given
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object);
        // When
        decimal balance = account.GetBalance();
        // Then
        Assert.Equal(5000M, balance);
    }
}
