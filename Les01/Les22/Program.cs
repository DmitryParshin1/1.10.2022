// Есть магазин "Ромашка"
// Охранник ведёт журнал посещения
// 11-13
// 10-14
// 9-10
// 11-22
// 18-18
// 0-23
// 4-5
// 4-5
// 4-5

// Суть: показать интервалы, когда было больше всего 
// людей в магазине

// Ответ: 4-5, 11-13

int[] time = {1 ,1 ,1 ,1 ,4 ,4 ,1 ,1 ,1 ,2 ,3 ,4 ,4 ,4 ,3 ,2 ,2, 2, 4, 4};
 int max = time.Max();
 int s = Array.IndexOf(time, max);
 Console.WriteLine($" s: {s} ");

 int e = s;
 for (int i = s; i < time.Length - 1; i++)
 {
    if(!(time[i] == time[i + 1]))
    {
        e = i; break;
    }
 }

 for (int i = 0; i <= e; i++)
 {
    time[i] = 0;
 }

 Console.WriteLine($" {s} - {e} ");


s = Array.IndexOf(time, max);
 Console.WriteLine($" s: {s} ");

e = s;
 for (int i = s; i < time.Length - 1; i++)
 {
    if(!(time[i] == time[i + 1]))
    {
        e = i; break;
    }
 }

 for (int i = 0; i <= e; i++)
 {
    time[i] = 0;
 }

 Console.WriteLine($" {s} - {e} ");
