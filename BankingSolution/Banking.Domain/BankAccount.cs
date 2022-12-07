namespace Banking.Domain
{
    public class BankAccount
    {
        public enum BankAccountType { Standard, Gold }


        private decimal _balance = 5000;
        public BankAccountType AccountType = BankAccountType.Gold;

        public BankAccount()
        {
        }

        public void Deposit(decimal amountToDeposit)
        {
            var bonus = 0M;
            switch (AccountType)
            {
                case BankAccountType.Standard:
                    break;
                case BankAccountType.Gold:
                    bonus = amountToDeposit * .1M; 
                    break;
                default:
                    break;
            }
            _balance += amountToDeposit + bonus;
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