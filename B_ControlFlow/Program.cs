
static void MassIndex()
{
    Console.WriteLine("What's your age?");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("What's your weight in kg?");
    double weight = double.Parse(Console.ReadLine());

    Console.WriteLine("What's your height in meters?");
    double height = double.Parse(Console.ReadLine());


    double bodyMassIndex = weight / (height * height);
    Console.WriteLine(bodyMassIndex);
    bool isTooLow = bodyMassIndex <= 18.5;
    bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
    bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
    bool isTooFat = bodyMassIndex > 30;

    bool isFat = isAboveNormal || isTooFat;

    if (isFat)
    {
        Console.WriteLine("You'd better lose some weight");
    }
    else
    {
        Console.WriteLine("Oh, you're in good shape");
    }

    if (!isFat)
    {
        Console.WriteLine("You are deffo not fat");
    }

    if (isTooLow)
    {
        Console.WriteLine("Not enough weight");
    }
    else if (isNormal)
    {
        Console.WriteLine("You are ok");
    }
    else if (isAboveNormal)
    {
        Console.WriteLine("Be careful");
    }
    else
    {
        Console.WriteLine("You need to lose some weight.");
    }
    if (isFat || isTooFat)
    {
        Console.WriteLine("Anyway it's time to get on diet");
    }

    string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
    Console.WriteLine(description);
}
static void TwoNums()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

   /* int max = a;
    if (b>a)
    {
        max = b;
    }
    Console.WriteLine(max); */

    int max = a > b ? a : b;    

    Console.WriteLine($"max = {max}");


}
static void ForLoops()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(numbers[i]);
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] % 2 == 0)
        {
            Console.Write(numbers[j] + " ");
        }
    }
    foreach (int val in numbers)
    {
        Console.WriteLine(val + " ");
    }
}
static void NestedLoops()
{
    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
    for (int i = 0;i < numbers.Length; i++)
    {
        for (int j = i+1; j<numbers.Length; j++)
        {
            int atI = numbers[i];
            int atJ = numbers[j];

            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i}; {j})");
            }

        }
    }
}
static void WhileLoop()
{
    int age = 30;

    while (age < 18)
    {
        Console.WriteLine("First while loop");
        Console.WriteLine("What is your age");
        age = int.Parse(Console.ReadLine());
    }
    do
    {
        Console.WriteLine("Do while loop ");
        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());
    }

    while (age < 18);


    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
    int i = 0;
    while (i < nums.Length)
    {
        Console.WriteLine(nums[i] + " ");
        i++;
    }
    Console.WriteLine("Good");
}
static void BreakContinue()
{



    int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    foreach (int n in numbers1)
    {
        if (n % 2 != 0)
            continue;
        Console.WriteLine(n);
        {
            
        }
    }
    char[] letters = { 'a', 'b', 'c',  'd' , 'e', 'f', 'g', 'h', 'i', 'j'};
    for(int i = 0; i<numbers1.Length; i++)
    {
        Console.WriteLine($"Number= {numbers1[i]}");
        for (int j = 0; j < letters.Length; j++)
        {
            if (numbers1[i]==j)
            {
                break;
            }
            Console.Write($"{letters[j]}");
        }
        Console.WriteLine();

    }

    Console.ReadLine();


    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (counter == 3)
            break;
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int atI = numbers[i];
            int atJ = numbers[j];

            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i}; {j})");
                counter++;
            }
            if (counter == 3)
                break;

        }
    }
}
static void SwitchCase()
{
    int month = int.Parse(Console.ReadLine());
    string season = String.Empty;
    switch (month)
    {
        case 1:
        case 2:
        case 12:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;
        default:
            throw new ArgumentException("1-12");
            Console.WriteLine("Введите число от 1-12");
            break;


    }
    Console.WriteLine(season);


    int weddingYears = int.Parse(Console.ReadLine());
    string name = String.Empty;

    switch (weddingYears)
    {
        case 5:
            name = "Деревянная свадьба";
            break;
        case 10:
            name = "Оловянная свадьба";
            break;
        case 15:
            name = "Хрустальная";
            break;
        case 20:
            name = "Фарфоровая свадьба";
            break;
        case 25:
            name = "Серебряная свадьба";
            break;
        case 30:
            name = "Жемчужная свадьба";
            break;
        default:
            name = "Не знаем такого юбилея!";
            break;

    }
    Console.WriteLine(name);

}
static void TestingDebugger() {
    
    Console.WriteLine("Let's calculate the square of a triangle.");
    Console.WriteLine("Enter the lenght of side AB:");
    double ab = GetDouble();

    Console.WriteLine("Enter the lenght of side BC:");
    double bc = GetDouble();

    Console.WriteLine("Enter the lenght of side AC:");
    double ac = GetDouble();

    double p = (ab + bc + ac) / 2;
    double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

    Console.WriteLine($"square of the triangle equals {square}");

    static double GetDouble()
    {
        return double.Parse(Console.ReadLine());
    }

}
static void FibonacciNums()
{
    Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");
    int n = int.Parse(Console.ReadLine());
    int[] fibonacci = new int[n];
    int a0 = 0;
    int a1 = 1;
    fibonacci[0] = a0; fibonacci[1] = a1;
    
    for( int i = 2; i < n; i++ )
    {
        int a = a0 + a1;
        fibonacci[i] = a;

        a0 = a1;
        a1 = a;
    }
    foreach (int f in fibonacci)
    {
        Console.WriteLine(f);
    }
    Console.ReadLine();
}

static void TenNums()
{
    int[] numbers = new int[10];
    int inputCount = 0;
    while (inputCount < 10) 
    {
        int number = int.Parse(Console.ReadLine());
        numbers[inputCount] = number;

        inputCount++;

        if (number == 0)
            break; 
    }
    int sum = 0;
    int count = 0;

    foreach (int n in numbers)
    {
        if (n > 0 && n % 3 == 0)
        {
            sum += n;
            count++;
        }
    }
    double average = (double)sum / count;
    Console.WriteLine(average);

}