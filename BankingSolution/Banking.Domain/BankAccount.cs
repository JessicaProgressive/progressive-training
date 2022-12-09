namespace Banking.Domain
{
    public class BankAccount
    {
        private readonly ICalculateBonuses _calculator;
        private decimal _balance = 5000;

        public BankAccount(ICalculateBonuses calculator)
        {
            _calculator = calculator;
        }

        public void Deposit(decimal amountToDeposit)
        {
            var bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
            _balance += amountToDeposit;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
                // TODO
                throw new OverdraftException();
            }
            else
            {
                _balance -= amountToWithdraw;
            }
        }
    }
}