using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    bool isInvalid = false;
                    long abc = a * 100 + b * 10 + c;
                    long def = abc + diff;
                    if (def < 111 || def > 777)
                    {
                        isInvalid = true;
                    }
                    long ghi = def + diff;
                    if (ghi < 111 || ghi > 777)
                    {
                        isInvalid = true;
                    }

                    long num = abc * 1000000 + def * 1000 + ghi;
                    string numS = num.ToString();
                    long numSum = 0;

                    for (int i = 0; i < numS.Length; i++)
                    {
                        numSum += numS[i] - 48;
                        if ((numS[i] - 48) > 7 || (numS[i] - 48) < 1)
                        {
                            isInvalid = true;
                        }
                    }

                    if (numSum == sum && abc <= def && def <= ghi && !isInvalid)
                    {
                        Console.WriteLine(num);
                        isFound = true;
                    }
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
