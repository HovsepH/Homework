
namespace BankingSystem
{
    public interface IAccountOperationsHandler
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
        string GetDescription();
    }
}
