using System;
using System.Text;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char hashtag = '#';
        StringBuilder tail = new StringBuilder();
        StringBuilder head = new StringBuilder();

        tail.Append(dot, n / 2);
        tail.Append(hashtag, n);
        tail.Append(dot, n / 2);
        tail.Append("\n");
        for (int i = 0; i < n - 2; i++)
        {
            tail.Append(dot, n / 2);
            tail.Append(hashtag, 1);
            tail.Append(dot, n - 2);
            tail.Append(hashtag, 1);
            tail.Append(dot, n / 2);
            tail.Append("\n");
        }

        head.Append(hashtag, n / 2 + 1);
        head.Append(dot, n - 2);
        head.Append(hashtag, n / 2 + 1);
        head.Append("\n");

        for (int i = 2 * n - 3, j = 1; i > -1; i -= 2, j++)
        {
            head.Append(dot, j);
            head.Append(hashtag, 1);
            head.Append(dot, i);
            head.Append(hashtag, 1);
            head.Append(dot, j);
            head.Append("\n");
        }
        head.Append(dot, n - 1);
        head.Append(hashtag, 1);
        head.Append(dot, n - 1);
        Console.WriteLine("{0}{1}", tail, head);
    }
}
