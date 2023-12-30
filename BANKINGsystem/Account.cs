namespace BankingSystem
{
    public class Account
    {
        private readonly IAccountOperationsHandler _operationsHandler;
        public Account(IAccountOperationsHandler operationsHandler)
        {
            _operationsHandler = operationsHandler;
        }

        public void Deposit(decimal amount)
        {
            _operationsHandler.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            _operationsHandler.Withdraw(amount);
        }

        public decimal GetBalance()
        {
            return _operationsHandler.GetBalance();
        }

        public string GetDescription()
        {
            return _operationsHandler.GetDescription();
        }
    }

}