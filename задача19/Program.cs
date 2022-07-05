//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Ввведите пятизначное число");
int number = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
 if(number > 99999 || number < 10000)
 {
     Console.WriteLine("Вы ввели не пятизначное число");
 }
else 
{
    int number1 = number % 10;
    int number2 = (number / 10) % 10;
    int number3 = (number / 100) % 10;
    int number4 = (number / 1000) % 10;
    int number5 = number / 10000;
    if (number1 == number5 && number2 == number4)
    {
    Console.WriteLine("Число является палидромом");
    }
    else
    {
    Console.WriteLine("Число не является палидромом");
    }
}
