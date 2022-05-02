Console.WriteLine("Введите двухзначное число"); 
int a = Convert.ToInt32(Console.ReadLine());
if (a%10 > a/10) {
    Console.WriteLine(a%10);
}
else {
    Console.WriteLine(a/10);
}
