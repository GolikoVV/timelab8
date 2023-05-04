using timelab8;

class Program
{
    static void Main()
    {
        // создание объекта Time
        Time time1 = new Time(10, 30, 45);
        Time time2 = new Time(2, 15, 20);

        // вызов методов и операторов
        Console.WriteLine("time1 + time2 = " + (time1 + time2));
        Console.WriteLine("time1 - time2 = " + (time1 - time2));
        Console.WriteLine("time1 == time2 ? " + (time1 == time2));
        Console.WriteLine("time1 > time2 ? " + (time1 > time2));
        Console.WriteLine("time1++ = " + (time1));
        Console.WriteLine("time2-- = " + (time2));
    }
}
/*Здесь мы создаем два объекта Time, затем вызываем операторы и методы для выполнения 
арифметических операций и операций сравнения между ними. */