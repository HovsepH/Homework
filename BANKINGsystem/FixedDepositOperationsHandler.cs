
namespace BankingSystem
{
    public class FixedDepositOperationsHandler : AccountOperationsHandlerBase
    {
        private readonly int _age;
        public FixedDepositOperationsHandler(decimal balance, int age) : base(balance)
        {
            _age = age;
        }

        public override void Withdraw(decimal amount)
        {
            if (_age < 18)
            {
                throw new InvalidOperationException("Non Mature Withdraw try");
            }
            base.Withdraw(amount);
        }

        public override string GetDescription()
        {
            return "This is a Fixed Deposit account";
        }
    }

}
