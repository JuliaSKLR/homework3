// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.  
//Math.Sqrt(x); x, y, z,

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int[] array1 = new int[3];
int[] array2 = new int[3];
char[] coord = { 'X', 'Y', 'Z' };

for (int i = 0; i <= 2; i++)
{
    array1[i] = Prompt($"Введите для первой точки  {coord[i]}: ");
}
for (int i = 0; i <= 2; i++)
{
    array2[i] = Prompt($"Введите для второй точки  {coord[i]}: ");
}
  
double result = Math.Sqrt((array1[0]-array2[0])*(array1[0]-array2[0])+((array1[1]-array2[1])*(array1[1]-array2[1])+(array1[2]-array2[2])*(array1[2]-array2[2])));
System.Console.WriteLine(result);
