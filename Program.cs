Console.Write("Введите номер задачи: ");
int a = 0;
try{
a = Convert.ToInt32(Console.ReadLine());
} catch (System.FormatException){
    Console.Write("Это не номер");
    return;
}

switch (a){

    case 10:
    task10("Вторая цифра - ");
    break;

    case 13:
    task13("Третья цифра - ");
    break;

    case 15:
    if(task15()) Console.WriteLine("Это выходной день");
    break;

    default: 
    Console.WriteLine("Нет такой задачи(");
    break;
}

// Task10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа

void task10(string message){
    Console.Write("Введите трехзначное число: ");
    string abc = Console.ReadLine()!;
    int number = 0;

    try{
    number = Convert.ToInt32(abc);
    } catch(System.FormatException e){
        Console.WriteLine("Введеные данные не являются числом");
        return;
    }

    if(number <100 || number >= 1000){
        Console.WriteLine("Это число не трехзначное");
        return;
    }

    number = number / 10 % 10;
    Console.WriteLine(message + number);
}

// Task13.  Напишите программу, которая выводит третью цифру
// заданного числа ( или -1, если третьей цифры нет).

int task13(string message){
    Console.Write("Введите число: ");
    string abc = Console.ReadLine()!;
    int number = 0;

    try{
    number = Convert.ToInt32(abc);
    } catch(System.FormatException e){
        Console.WriteLine("Введеные данные не являются числом");
        return -1;
    }

    if(number < 100){
        Console.WriteLine("Третьей цифры нет");
        return -1;
    }

    if(number > 999){
        do {
           number = number / 10;
        } while (number > 999);
    }

    number = number % 10;
    Console.WriteLine(message + number);
    return number;
}

// Task15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

bool task15(){

    Console.Write("Введите цифру дня недели: ");
    string abc = Console.ReadLine()!;
    int number = 0;

    try{
    number = Convert.ToInt32(abc);
    } catch(System.FormatException e){
        Console.WriteLine("Введеные данные не являются цифрой или числом");
        return false;
    }

    if(number < 1 || number > 7){
        Console.WriteLine("Цифра/число не обозначает день недели");
        return false;
    }

    if(number != 6 && number != 7){
        Console.WriteLine("Этот день не выходной");
        return false;
    }

    return true;
}