
namespace BankingSystem
{
    public class CheckingAccountOperationsHandler : AccountOperationsHandlerBase
    {
        private readonly decimal _overdraftLimit;
        public CheckingAccountOperationsHandler(decimal balance, decimal overdraftLimit) : base(balance)
        {
            _overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount - _balance > _overdraftLimit)
            {
                throw new InvalidOperationException("Overdraft limit exceeded");
            }
            base.Withdraw(amount);
        }

        public override string GetDescription()
        {
            return "This is a Checking account";
        }
    }
}
