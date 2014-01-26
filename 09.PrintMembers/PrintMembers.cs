using System;
//9. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    class PrintMembers
{
    static void Main()
    {
        for (int members = 2; members <= 11; members++)
        {
            if (members % 2 == 0)
            {
                Console.WriteLine(members);
            }
            else
            {
                Console.WriteLine(members * (-1));
            }

        }

    }
}
