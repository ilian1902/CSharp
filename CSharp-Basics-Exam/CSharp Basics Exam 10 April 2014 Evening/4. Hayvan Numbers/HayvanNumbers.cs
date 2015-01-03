using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int a = 5; a <= 9; a++)
        {
            for (int b = 5; b <= 9; b++)
            {
                for (int c = 5; c <= 9; c++)
                {
                    bool isInvalid = false;
                    long abc = a * 100 + b * 10 + c;
                    long def = abc + diff;
                    if (def < 555 || def > 999)
                    {
                        isInvalid = true;
                    }
                    long ghi = def + diff;
                    if (ghi < 555 || ghi > 999)
                    {
                        isInvalid = true;
                    }

                    long num = abc * 1000000 + def * 1000 + ghi;
                    string numS = num.ToString();
                    long numSum = 0;

                    for (int i = 0; i < numS.Length; i++)
                    {
                        numSum += numS[i] - 48;
                        if ((numS[i] - 48) > 9 || (numS[i] - 48) < 5)
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
