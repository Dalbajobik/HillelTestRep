/*
// Початковий номер замовлення
int orderNumber = 1;

//Дані для першого користувача
Console.Write("Write clien name for order:");
string userName1 = Console.ReadLine();
Console.Write("Write product name for order:");
string productName1 = Console.ReadLine();
Console.Write("Write product price:");
string productPrice1 = Console.ReadLine();
Console.Write("Write adress for order:");
string clientAdress1 = Console.ReadLine();

//Вивід інформації про перше зщамовлення
Console.WriteLine();
Console.WriteLine($"Order No {orderNumber}");
Console.WriteLine($"Client: {userName1}");
Console.WriteLine($"Product: {productName1}, price {productPrice1} UAN");
Console.WriteLine($"Adress: {clientAdress1}");

// Друге замовлення
orderNumber++;

//Дані для другого користувача
Console.WriteLine();
Console.Write("Write clien name for order:");
string userName2 = Console.ReadLine();
Console.Write("Write product name for order:");
string productName2 = Console.ReadLine();
Console.Write("Write product price:");
string productPrice2 = Console.ReadLine();
Console.Write("Write adress for order:");
string clientAdress2 = Console.ReadLine();

//Вивід інформації про друге замовлення
Console.WriteLine();
Console.WriteLine($"Order No {orderNumber}");
Console.WriteLine($"Client: {userName1}");
Console.WriteLine($"Product: {productName1}, price {productPrice1} UAN");
Console.WriteLine($"Adress: {clientAdress1}");


// Третє замовлення
orderNumber++;

//Дані для третього користувача
Console.WriteLine();
Console.Write("Write clien name for order:");
string userName3 = Console.ReadLine();
Console.Write("Write product name for order:");
string productName3 = Console.ReadLine();
Console.Write("Write product price:");
string productPrice3 = Console.ReadLine();
Console.Write("Write adress for order:");
string clientAdress3 = Console.ReadLine();

//Вивід інформації про третє замовлення
Console.WriteLine();
Console.WriteLine($"Order No {orderNumber}");
Console.WriteLine($"Client: {userName1}");
Console.WriteLine($"Product: {productName1}, price {productPrice1} UAN");
Console.WriteLine($"Adress: {clientAdress1}");
*/

// Початковий номер замовлення
int orderNumber = 1;

// Змінні для зберігання даних про замовлення
string userName1, productName1, productPrice1, userAddress1;
string userName2, productName2, productPrice2, userAddress2;
string userName3, productName3, productPrice3, userAddress3;

// Введення даних для першого користувача
Console.Write("Write clien name for order:");
userName1 = Console.ReadLine();
Console.Write("Write product name for order:");
productName1 = Console.ReadLine();
Console.Write("Write product price:");
productPrice1 = Console.ReadLine();
Console.Write("Write adress for order:");
userAddress1 = Console.ReadLine();

// Введення даних для другого користувача
Console.WriteLine();
Console.Write("Write clien name for order:");
userName2 = Console.ReadLine();
Console.Write("Write product name for order:");
productName2 = Console.ReadLine();
Console.Write("Write product price:");
productPrice2 = Console.ReadLine();
Console.Write("Write adress for order:");
userAddress2 = Console.ReadLine();

// Введення даних для третього користувача
Console.WriteLine();
Console.Write("Write clien name for order:");
userName3 = Console.ReadLine();
Console.Write("Write product name for order:");
productName3 = Console.ReadLine();
Console.Write("Write product price:");
productPrice3 = Console.ReadLine();
Console.Write("Write adress for order:");
userAddress3 = Console.ReadLine();

// Очищення консолі
Console.Clear();

// Виведення всіх замовлень
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Замовлення No {orderNumber}");
Console.ResetColor();
Console.WriteLine($"Client: {userName1}");
Console.WriteLine($"Product: {productName1}, price {productPrice1} UAN");
Console.WriteLine($"Adress: {userAddress1}");
Console.WriteLine();

orderNumber++;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Order No {orderNumber}");
Console.ResetColor();
Console.WriteLine($"Client: {userName2}");
Console.WriteLine($"Product: {productName2}, price {productPrice2} UAN");
Console.WriteLine($"Adress: {userAddress2}");
Console.WriteLine();

orderNumber++;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Order No {orderNumber}");
Console.ResetColor();
Console.WriteLine($"Client: {userName3}");
Console.WriteLine($"Product: {productName3}, price {productPrice3} UAN");
Console.WriteLine($"Adress: {userAddress3}");
