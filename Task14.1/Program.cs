using HomeTask14._1;

Account heikkisAccount = new Account("Heikki's account", 100.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

heikkisAccount.Withdraw(20);
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);