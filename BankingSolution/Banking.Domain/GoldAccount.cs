namespace Banking.Domain
{
    public class GoldAccount : BankAccount
    {
        public GoldAccount()
        {
        }

        public override void Deposit(decimal amountToDeposit)
        {
            base.Deposit(amountToDeposit * .1M);
        }
    }
}