Console.WriteLine("Введите имя пользователя: ");

string username = Console.ReadLine();

if(username.ToLower == "Маша") // если имя пользователя равен Маша, ToLower - нижний регистр
{
    Console.WriteLine("Ура, это же Маша!");  //Консоль выводит Машу  
}
else // иначе
{
    Console.Write("Привет, ");
    Console.Write(username);
}