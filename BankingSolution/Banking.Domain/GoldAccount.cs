namespace Banking.Domain
{
    public class GoldAccount : BankAccount
    {
        public GoldAccount()
        {
        }

        public override void Deposit(decimal amountToDeposit)
        {
            var bonus = amountToDeposit * .1M;
            base.Deposit(amountToDeposit + bonus);
        }
    }
}