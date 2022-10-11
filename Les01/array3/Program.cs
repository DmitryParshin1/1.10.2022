//1 группа - методы которые ничегоо не принимают и не возвращают

void Method1() // void нчего не возвращает, () - нет аргументов
{
    Console.WriteLine("Всем привет: ");
}

//---------------------------------------------------------- 

// 2 группа - методы которые ничего не принимают но есть аргумент

void Method2(string text)
{
    Console.WriteLine(text);
}
//Method2("Введите техт");


// несколько аргументоов может быть в ()
void Method21(string text, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(text);
        i++;
    }
}
//Method21(text: "Введите текст", count: 4); //можно записывать еще так

//----------------------------------------------------------

// 3 группа методы: метод возвращаем, но не принимает ни какие аргументы

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//----------------------------------------------------------

// 4 группа методы: метод возвращаем, и принимает аргументы

//string Method4(int count, string text)
{
   // int i = 0;
    //string result = String.Empty;
    
    //while(i < count)
    //{
    //result = result + text;
    //i++;
   // } 
//return result;
}

//string res = Method4(10, "Введем рандомный текст");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
    result = result + text;
    } 
return result;
}

string res = Method4(10, "Введем текст");
//Console.WriteLine(res);


// for - цикл (рассматриваем пример цикл в цикле)
// ниже пример, делам таблицу умножениея

//for (int i = 2; i < 10; i++)
//{
    //for (int j = 2; j <= 10; j++)
    //{
       // Console.WriteLine($"{i} * {j} = {i * j}");
   // }
    //Console.WriteLine();  // разорвалии строки
//}

//----------------------------------------------------------

// === Работа с текстом
//Дан тест. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с"

//string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            //+ "ежели бы вас послали вместо нашего милого Винценгероде,"
           // + "вы бы взяли приступом согласие прусского короля. "
           // + "Вы так красноречивы. Вы дадите мне чаю?";


 //string RepLace(string text, char oldValue, char newValue)
 //{

   // string result = String.Empty;

    //int lenght = text.Length;
    //for (int i = 0; i < lenght; i++)
    //{
        //if(text[i] == oldValue) result = result + $"{newValue}";
        //else result = result + $"{text[i]}";
    //}

    //return result;
 //}

//string newText = RepLace(text, ' ', '|');
//Console.WriteLine(newText);

//Console.WriteLine();
//newText = RepLace(newText, 'к', 'К');
//Console.WriteLine(newText);


//Console.WriteLine();
//newText = RepLace(newText, 'С', 'с');
//Console.WriteLine(newText);


int[] arr = {3, 6, 4, 9, 1, 4, 6, 2, 7, 2, 1,};

void printArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


printArray(arr);
SelectionSort(arr);

printArray(arr);