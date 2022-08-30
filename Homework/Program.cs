//Задача 1
bool Palind(int number)
{
    int n1 = number / 10000;
    number -= n1 * 10000;

    int n2 = number / 1000;
    number -= n2 * 1000;

    int n3 = number / 100;
    number -= n3 * 100;

    int n4 = number / 10;
    int n5 = number % 10;

    if (n1 == n5 && n2 == n4)
    {
        return true;
    }
    else
    {
        return false;
    }

}
System.Console.WriteLine(Palind(23432));


//Задача 2
// double GetRange (int a1, int a2, int a3, int b1, int b2, int b3)
// {
//     return Math.Sqrt(Math.Pow((b1 - a1), 2)+ (Math.Pow((b2 - a2), 2)+ (Math.Pow((b3 - a3), 2))));

// }
// System.Console.WriteLine(GetRange (7,-5,0,1,-1,9));

//Задача 3
// void GetPow(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         if (i >= number)
//     {
//         System.Console.Write(Math.Pow(i, 3)+ ".");
//     }
//     else
//     {
//         System.Console.Write(Math.Pow(i, 3)+ ",");
//     }
//     }
// }
// GetPow(3);