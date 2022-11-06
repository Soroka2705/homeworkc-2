/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("homework 2.1 ");
Console.Write("put three-digit nbr: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("second digit of this nbr -> "+stringNumber[1]);
*/


/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("task 15");

Console.Write("enter digit for weekday: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

{
    if(dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(day-off) -> yes");
    }
    else Console.WriteLine("(go to work) -> no");
}
return dayNumber;
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("task13");

Console.Write("enter number: ");
int randNumber = Convert.ToInt32(Console.ReadLine());
string randNumberText = Convert.ToString(randNumber);

if (randNumberText.Length > 2)
{
Console.WriteLine("third digit ->" + randNumberText[2]);
}
else
{
Console.WriteLine("no third digit");
}
*/
