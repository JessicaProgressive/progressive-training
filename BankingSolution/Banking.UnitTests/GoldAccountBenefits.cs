using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        //[Fact]
        //public void GetBonusOnDeposit()
        //{
        //    var account = new BankAccount(new DummyBonusCalculator());
        //    var openingBalance = account.GetBalance();
        //    var amountToDeposit = 100M;
        //    var expectedBonus = 10M;

        //    account.Deposit(amountToDeposit);

        //    Assert.Equal(openingBalance + amountToDeposit + expectedBonus,
        //        account.GetBalance());

        //}

        [Fact]
        public void GetBonusOnDeposit()
        {

            // Given
            var stubbedBonusCalculator = new Mock<ICalculateBonuses>();
            var account = new BankAccount(stubbedBonusCalculator.Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 92.42M;
            var expectedBonus = 42M;
            stubbedBonusCalculator.Setup(s => s.GetBonusForDepositOn(openingBalance, amountToDeposit)).Returns(expectedBonus);

            // When
            account.Deposit(amountToDeposit);

            // Then
            Assert.Equal(openingBalance + amountToDeposit + expectedBonus,
                account.GetBalance());

        }
    }
}
