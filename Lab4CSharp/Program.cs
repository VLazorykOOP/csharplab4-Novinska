using Lab4CSharp;
using System;

Console.WriteLine("Lab4 C# ");

static void Task1()
{
    Rectangle rectangle = new Rectangle(3, 4, 3);

    // Друкуємо сторони
    rectangle.PrintSides();

    // Обчислення периметра і площі
    Console.WriteLine("Perimeter: {0}", rectangle.CalculatePerimeter());
    Console.WriteLine("Area: {0}", rectangle.CalculateArea());

    // Збільшення сторін
    Console.WriteLine("Is Square: {0}", (bool)rectangle);

    // Збільшення сторін
    rectangle++;
    Console.WriteLine("After incrementing:");
    rectangle.PrintSides();

    // Множення сторін на скаляр        
    Rectangle scaledRectangle = rectangle * 2;
    Console.WriteLine("Scaled Rectangle:");
    scaledRectangle.PrintSides();

    // Перетворення в рядок і назад
    string rectangleString = (string)rectangle;
    Console.WriteLine("Converted to string: {0}", rectangleString);
    Rectangle newRectangle = (Rectangle)rectangleString;
    Console.WriteLine("Converted back to Rectangle:");
    newRectangle.PrintSides();

    newRectangle--;
    Console.WriteLine("After decrementing:");
    newRectangle.PrintSides();

    // Доступ до сторін за допомогою індексу
    Console.WriteLine("Side at index 0: {0}", newRectangle[0]);
    Console.WriteLine("Side at index 1: {0}", newRectangle[1]);
    Console.WriteLine("Color at index 2: {0}", newRectangle[2]);
}

static void Task2()
{
    // Вектори
    VectorShort v1 = new VectorShort(3, 5);
    VectorShort v2 = new VectorShort(3, 10);

    // Друкуємо створені вектори
    Console.WriteLine("Vector v1:");
    v1.Print();

    Console.WriteLine("Vector v2:");
    v2.Print();

    // Виконання операцій
    VectorShort sum = v1 + v2;
    Console.WriteLine("Sum of vectors v1 and v2:");
    sum.Print();

    VectorShort scalarProduct = v1 * 2;
    Console.WriteLine("Scalar product of vector v1 and 2:");
    scalarProduct.Print();

    Console.WriteLine($"Length of vector v1: {v1.Lenth}");

    Console.WriteLine($"Code error of vector v1: {v1.CodeError}");

    ++v1;
    Console.WriteLine("After incrementing vector v1:");
    v1.Print();

    --v2;
    Console.WriteLine("After decrementing vector v2:");
    v2.Print();

    Console.WriteLine($"Is vector v1 empty? {(bool)v1}");
    Console.WriteLine($"Is vector v2 empty? {(bool)v2}");

    VectorShort bitwiseNot = ~v1;
    Console.WriteLine("Bitwise NOT of vector v1:");
    bitwiseNot.Print();

    VectorShort bitwiseOr = v1 | v2;
    Console.WriteLine("Bitwise OR of vectors v1 and v2:");
    bitwiseOr.Print();

    VectorShort bitwiseXor = v1 ^ v2;
    Console.WriteLine("Bitwise XOR of vectors v1 and v2:");
    bitwiseXor.Print();

    // Логічне І - диз'юнкція
    VectorShort bitwiseAnd = v1 & v2;
    Console.WriteLine("Bitwise AND of vectors v1 and v2:");
    bitwiseAnd.Print();
}

static void Task3()
{
    // матриці
    MatrixShort mat1 = new MatrixShort(2, 2, 1);
    MatrixShort mat2 = new MatrixShort(2, 2, 2);

    // Друкуємо створені матриці
    Console.WriteLine("Matrix 1:");
    mat1.Print();
    Console.WriteLine("Matrix 2:");
    mat2.Print();

    // Додавання
    MatrixShort matSum = mat1 + mat2;
    Console.WriteLine("Sum of matrices:");
    matSum.Print();

    // Множення
    MatrixShort matProd = mat1 * mat2;
    Console.WriteLine("Product of matrices:");
    matProd.Print();

    // еквівалентність
    Console.WriteLine($"Matrices are equal: {mat1 == mat2}");

    Console.WriteLine($"Matrices are not equal: {mat1 != mat2}");

    // Перевірте, чи одна матриця менша за іншу
    Console.WriteLine($"Matrix 1 is less than matrix 2: {mat1 < mat2}");

    // Перевірте, чи одна матриця більша за іншу
    Console.WriteLine($"Matrix 1 is greater than matrix 2: {mat1 > mat2}");

    // Перевірте, чи одна матриця менша або дорівнює іншій
    Console.WriteLine($"Matrix 1 is less than or equal to matrix 2: {mat1 <= mat2}");

    // Перевірте, чи одна матриця більша або дорівнює іншій
    Console.WriteLine($"Matrix 1 is greater than or equal to matrix 2: {mat1 >= mat2}");

}

static void ShowMenu()
{
    string[] menuStrings =
    {
        "1. Task 1!",
        "2. Task 2!",
        "3. Task 3!"
    };
    int currentOprtion = 0;
    ConsoleKeyInfo keyInfo;
    int choice = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Lab 4 CSharp");
        PrintMenu(menuStrings, currentOprtion);


        keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
        {
            currentOprtion = currentOprtion + 1 <= menuStrings.Length - 1 ? currentOprtion + 1 : 0;
        }
        else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
        {
            currentOprtion = currentOprtion - 1 >= 0 ? currentOprtion - 1 : menuStrings.Length - 1;
        }
        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            choice = currentOprtion;
            break;
        }
    }
    switch (choice)
    {
        case 0:
            Task1();
            break;
        case 1:
            Task2();
            break;
        case 2:
            Task3();
            break;
        default:
            break;
    }
}

static void PrintMenu(string[] menuString, int choosenString)
{
    for (int i = 0; i < menuString.Length; i++)
    {
        if (i == choosenString)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine(menuString[i]);
        if (i == choosenString)
        {
            Console.ResetColor();
        }
    }
}

while (true)
{
    Console.Clear();
    try
    {
        ShowMenu();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
