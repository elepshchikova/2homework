// // int n = 918;

// System.Console.WriteLine(n/10%10);




int n = new Random().Next(100,10000);

if (n < 100){
System.Console.WriteLine("Третьей цифры нет");
}
else{
int result = n / 100 % 10;
System.Console.WriteLine($"Третья цифра числа {n} -> {result}");
}