
namespace BankingSystem
{
    public class SavingAccountOperationsHandler : AccountOperationsHandlerBase
    {
        public SavingAccountOperationsHandler(decimal balance) : base(balance)
        {
        }

        public override string GetDescription()
        {
            return "This is a Saving account";
        }
    }



}
