using System;

class MagicDates
{
    static void Main()
    {
        int firstYear = int.Parse(Console.ReadLine());
        int secondYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(firstYear, 1, 1);
        DateTime endDate = new DateTime(secondYear, 12, 31);
        bool hasMatch = false;

        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            int n1 = d.Day / 10;
            int n2 = d.Day % 10;
            int n3 = d.Month / 10;
            int n4 = d.Month % 10;
            int n5 = (d.Year / 1000) % 10;
            int n6 = (d.Year / 100) % 10;
            int n7 = (d.Year / 10) % 10;
            int n8 = d.Year % 10;
            int[] digits = { n1, n2, n3, n4, n5, n6, n7, n8 };

            int currentWeight = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    currentWeight = currentWeight + (digits[i] * digits[j]);
                }
            }
            if (currentWeight == magicWeight)
            {
                Console.WriteLine(d.ToString("dd-MM-yyyy"));
                hasMatch = true;
            }

        }
        if (!hasMatch)
        {
            Console.WriteLine("No");
        }
    }
}
