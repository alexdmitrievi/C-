Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n/100;
int b = n%10;
n = a * 10 + b;
Console.WriteLine(n);
