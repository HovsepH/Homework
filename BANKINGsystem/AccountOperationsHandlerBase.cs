
namespace BankingSystem
{
    public abstract class AccountOperationsHandlerBase : IAccountOperationsHandler
    {
        protected decimal _balance;

        protected AccountOperationsHandlerBase(decimal balance)
        {
            _balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public abstract string GetDescription();
    }

}
