Console.WriteLine("Введите число");
long a = Convert.ToInt64(Console.ReadLine());
if (a < 100) {
    Console.WriteLine("третьей цифры нет");
}
else {
    while (a > 1000) {
        a = a/10;
    }
    a = a%10;
    Console.WriteLine(a);
}