using System;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int n = 1111; n <= 9999; n++)
        {
            char[] secret = secretNumber.ToCharArray();
            char[] num = n.ToString().ToCharArray();
            int currentBulls = 0;
            int currentCows = 0;
            //exclude '0' values 
            if (num[0] >= '1' && num[1] >= '1' && num[2] >= '1' && num[3] >= '1')
            {
                //Check for bulls
                for (int i = 0; i < 4; i++)
                {
                    if (secret[i] == num[i])
                    {
                        secret[i] = '!';
                        num[i] = '&';
                        currentBulls++;
                    }
                }

                //check for cows
                for (int s = 0; s < 4; s++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        if (secret[s] == num[c])
                        {
                            secret[s] = '!';
                            num[c] = '&';
                            currentCows++;
                        }
                    }
                }
                if (currentBulls == bulls && currentCows == cows)
                {
                    Console.Write("{0} ", n);
                    isFound = true;
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
