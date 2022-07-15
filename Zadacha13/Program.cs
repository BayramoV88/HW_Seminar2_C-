Random rand = new Random();
int number = rand.Next();
Console.WriteLine(number); //Вывод всего числа

int newNumber = 1000;
while (newNumber < number)
{
    number = number / 10;
}
//Console.WriteLine(number); //Вывод первых трех разрядов

int newNumber_2 = 100;
if (newNumber_2 <= number)
{
    number = number % 10;
    Console.WriteLine(number + " -третья цифра изначально числа");
}
else
{
    Console.WriteLine("третьей цифры нет");
}