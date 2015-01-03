using System;
class Illuminati
{
    static void Main()
    {
        string message = (Console.ReadLine()).ToUpper();
        int vowelsCount = 0;
        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            switch (message[i])
            {
                case 'A': sum += message[i]; vowelsCount++;
                    break;
                case 'E': sum += message[i]; vowelsCount++;
                    break;
                case 'I': sum += message[i]; vowelsCount++;
                    break;
                case 'O': sum += message[i]; vowelsCount++;
                    break;
                case 'U': sum += message[i]; vowelsCount++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("{0}\n{1}", vowelsCount, sum);
    }
}
