//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num = Prompt("Введите пятизначное число ");
if (num > 100000 || num < 10000)
{
    System.Console.WriteLine("error enter");
    
}
else if (num % 10000 / 1000 == num % 100 / 10 && num % 100000 / 10000 == num % 10)
{
    System.Console.WriteLine("Polyndrome");
    
    }
else
{
    System.Console.WriteLine("not polyndrome");
}

