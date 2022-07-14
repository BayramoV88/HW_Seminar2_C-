Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

int tens = number / 10 % 10;
Console.WriteLine(tens);