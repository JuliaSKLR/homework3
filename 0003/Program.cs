// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int N = Prompt("Введите число ");
int i =1;
for( i =1; i<=N; i++)
{
    int result = i*i*i;
    System.Console.WriteLine(result);
}

