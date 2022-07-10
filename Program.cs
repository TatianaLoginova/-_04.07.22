
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void FindSecondNumberVoid()
{
    int num, a, b;

    Console.Write("Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());

    a = num % 10;   // 789 % 10 = 9
    b = num / 100; //7,89

    num = num - (b*100); //убрали сотни - 789 - (7*100) = 89
    num = num - a; // убрали единичные цифры - равно 89, 89 - 9 = 80
    num = num /10 ; // поделили на десять, 80/10 = 8

    Console.WriteLine("Второе число " +  num);

}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void FindThirdNumberVoid()
{
    int num, current_number, current_divider, i, third_number;

    bool third_number_exist = false;
    
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());

    current_divider = 1;
    current_number = num;
    third_number = num;
    i = 1;
    
    while( current_number > 0 ) {
       
        if (i >= 3){
            third_number = (num / (current_divider/10/10))%10;
            third_number_exist = true;
            Console.WriteLine( i + ". current_number = " +  current_number + ". Текущий делитель = " + current_divider + " num = " + num + " third_number =  " + third_number  );            
       }else {
            Console.WriteLine( i + ". current_number = " +  current_number + ". Текущий делитель = " + current_divider + " num = " + num );            
       }; 

       current_number = num / current_divider;
       i ++;
       
    };

    
     if (third_number_exist == false) {
            Console.WriteLine( "Третьего числа нет");
       }else{
        Console.WriteLine( "Третье число: " + third_number);
       };
 
    
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void FindWeekend(){

    int num;

    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 7){
        Console.WriteLine("Число не день недели. Конец программы.");
        return;
    };

    if (IsWeekend(num) == true){
        Console.WriteLine("Это выходной");
    }else {
        Console.WriteLine("Это не выходной");
    };

}

bool IsWeekend(int weeeknumber) {
    if (weeeknumber >5){
        return true;
    }else {
        return false;
    };

}



//FindSecondNumberVoid();
//FindThirdNumberVoid();
FindWeekend();
