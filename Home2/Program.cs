string[] a = {"0","понедельник","вторник","среда","четверг","пятница","суббота","воскресенье" } ;
Console.Write("Введите номер дня недели");
int n = Convert.ToInt32(Console.ReadLine()); // номер дня недели
Console.Write(a[n]);