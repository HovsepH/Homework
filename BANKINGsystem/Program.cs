using BankingSystem;
var savingAccount = new Account(new SavingAccountOperationsHandler(100));
savingAccount.Deposit(10);
savingAccount.Withdraw(20);


var checkingAccount = new Account(new CheckingAccountOperationsHandler(100, 20));
checkingAccount.Deposit(10);
checkingAccount.Withdraw(20);








    



  


   



  




   


   

