Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)  {
    Console.Write("да");
}
else {
    Console.Write(a%b);
}
