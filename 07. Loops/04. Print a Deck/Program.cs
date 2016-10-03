using System;


class Program
{
    static void Main()
    {

        char card = (char)Console.Read();
        char[] cards = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
        bool isBigest = true;
        for (int i = 0; i < 8; i++)
        {

            Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", cards[i],
                "spades", "clubs", "hearts", "diamonds");
            if (cards[i] == card)
            {
                isBigest = false;
                break;
            }
        }
        if ((card == '1') || (isBigest == true))
        {
            Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", "10",
                "spades", "clubs", "hearts", "diamonds");
            if (card == '1')
            {
                isBigest = false;
            }
        }
        if (isBigest)
        {
            for (int i = 8; i < cards.Length; i++)
            {
                Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", cards[i],
                "spades", "clubs", "hearts", "diamonds");
                if (cards[i] == card)
                {
                    break;
                }
            }
        }
        
    }
}