class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atama ve işlemli Atama");
        // Atama ve işlemli Atama
        int x = 3;
        int y = 3;
        y = y + 2;

        Console.WriteLine(y);
        // İşlemli Atama
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x += 2;
        Console.WriteLine(x);

        Console.WriteLine("Mantıksal Operatörler");

        // Mantıksal Operatörler

        // ||, &&, !

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

        if (isSuccess || isCompleted)
            Console.WriteLine("Great!");

        if (isSuccess && !isCompleted)
            Console.WriteLine("Fine");


        Console.WriteLine("İlişkisel Operatörler");

        // İlişkisel Operatörler
        // <, >, <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool result = a < b;
        Console.WriteLine(result);
        result = a > b;
        Console.WriteLine(result);
        result = a <= b;
        Console.WriteLine(result);
        result = a >= b;
        Console.WriteLine(result);
        result = a == b;
        Console.WriteLine(result);
        result = a != b;
        Console.WriteLine(result);

        // Aritmetik Operatörler
        // /, *, +, -
        Console.WriteLine("Aritmetik Operatörler");

        int numberOne = 10;
        int numberTwo = 5;
        int resultSliced = numberOne / numberTwo;
        Console.WriteLine(resultSliced);
        resultSliced = numberOne * numberTwo;
        Console.WriteLine(resultSliced);
        resultSliced = numberOne + numberTwo;
        Console.WriteLine(resultSliced);
        resultSliced = ++numberOne;
        Console.WriteLine(resultSliced);

        // % : mod alır (Kalanı verir)
        int resultMod = 20 % 3;
        Console.WriteLine(resultMod);
    }
}