//int dayNumber = 5;

//switch (dayNumber)
//{
//case 5 or 7: System.Console.WriteLine(("Выходной")); break;
// default: System.Console.WriteLine("Будний"); break;
//}
//int score = 38;

//switch (score) {
//case >= 0 and < 39:
//System.Console.WriteLine("Неудовлетворительно");
//break;
//case >= 40 and < 59:
//System.Console.WriteLine("Удовлетворительно");
//break;
//case >= 60 and < 79:
//System.Console.WriteLine("Хорошо");
//break;
//case >= 80 and <= 100:
//System.Console.WriteLine("Отлично");
//break;
//default:
//System.Console.WriteLine("Некорректный балл");
//break;
//}
//int score = 14;

//string result = score switch
//{
//    >= 35 => "Очень жарко",
//    >= 25 => "Жарко",
//    >= 15 => "Комфортно",
//    >= 0 => "Прохладно",
//    _ => "Мороз"
//};

//System.Console.WriteLine(result);
//string role = "teacher";

//string result = role switch
//{
//"admin" => "Полный доступ",
//"teacher" => "Доступ преподавателя",
// _ => "Ограниченный доступ"
//};

//System.Console.WriteLine(result);
//int age = 18;
//bool hasTicket = false;

//switch (age)
//{
//case >= 18 when hasTicket:
//System.Console.WriteLine("Вход разрешён");
//break;
//case >= 18 when hasTicket == false:
//System.Console.WriteLine("Нет билета");
//break;
//default:
//System.Console.WriteLine("Вход запрещён");
//break;
//}
// int level = 2;
// switch (level)
// {
//     case 1:
//         System.Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         System.Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         System.Console.WriteLine("Продвинутый уровень");
//         break;
// }

using System.Net.Http.Headers;

int numberMonths = int.Parse(Console.ReadLine());
string season = numberMonths switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
System.Console.WriteLine(season);

int age = int.Parse(Console.ReadLine());
string result = age switch
{
    >= 65 => "Пенсионер",
    >= 18 => "Взрослый",
    >= 7 => "Подросток",
    >= 0 => "Ребенок",
    _ => "Ошибка"
};
System.Console.WriteLine(result);