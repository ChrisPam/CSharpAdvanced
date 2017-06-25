using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var firstInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var secondInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var firstPlayer = new Queue<string>(firstInput);
        var secondPlayer = new Queue<string>(secondInput);

        var counter = 0;
        while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
        {
            if (counter >= 1000000)
            {
                break;
            }
            //Find first player num
            var firstPlayerCard = firstPlayer.Dequeue();
            int firstPlayerNum = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));
            //Add first player num to first player score

            //Find second player num
            var secondPlayerCard = secondPlayer.Dequeue();
            int secondPlayerNum = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));
            //Add second player num to first player score

            //Check if first number is greater than second number
            if (firstPlayerNum > secondPlayerNum)
            {
                // Add first match to first player Deck
                firstPlayer.Enqueue(firstPlayerCard);
                // Add second match to first player Deck
                firstPlayer.Enqueue(secondPlayerCard);
            }
            else if (secondPlayerNum > firstPlayerNum)
            {
                // Add second match to second player Deck
                secondPlayer.Enqueue(secondPlayerCard);
                // Add first match to second player Deck
                secondPlayer.Enqueue(firstPlayerCard);
            }
            else
            {
                var eightCardDeck = new List<string>();
                while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
                {
                    if (counter >= 1000000)
                    {
                        break;
                    }
                    // Check first player numbers in deck
                    if (firstPlayer.Count >= 3 && secondPlayer.Count >= 3)
                    {
                        eightCardDeck.Add(firstPlayerCard);
                        eightCardDeck.Add(secondPlayerCard);
                        // Get 3 numbers from first player deck
                        var firstPlayerFnum = firstPlayer.Dequeue();
                        var firstPlayerSnum = firstPlayer.Dequeue();
                        var firstPlayerTnum = firstPlayer.Dequeue();
                        eightCardDeck.Add(firstPlayerFnum);
                        eightCardDeck.Add(firstPlayerSnum);
                        eightCardDeck.Add(firstPlayerTnum);
                        // Sum all 3 numbers

                        var firstPlayerSum = GetPlayerLettersSum(firstPlayerFnum, firstPlayerSnum, firstPlayerTnum);

                        // Get 3 numbers from second player deck
                        var secondPlayerFnum = secondPlayer.Dequeue();
                        var secondPlayerSnum = secondPlayer.Dequeue();
                        var secondPlayerTnum = secondPlayer.Dequeue();
                        eightCardDeck.Add(secondPlayerFnum);
                        eightCardDeck.Add(secondPlayerSnum);
                        eightCardDeck.Add(secondPlayerTnum);
                        // Sum all 3 numbers
                        var secondPlayerSum = GetPlayerLettersSum(secondPlayerFnum, secondPlayerSnum, secondPlayerTnum);

                        // Check first player sum and second player sum
                        if (firstPlayerSum > secondPlayerSum)
                        {
                            var sortEightCardDeck = eightCardDeck.OrderByDescending(x => toNum(x)).ThenByDescending(x => x[x.Length - 1]).ToArray();
                            // Add all 8 cards to first player
                            AddCardsToDeck(sortEightCardDeck, firstPlayer);
                            break;
                        }
                        else if (firstPlayerSum < secondPlayerSum)
                        {
                            var sortEightCardDeck = eightCardDeck.OrderByDescending(x => toNum(x)).ThenByDescending(x => x[x.Length - 1]).ToArray();
                            // Add all 8 cards to second player
                            AddCardsToDeck(sortEightCardDeck, secondPlayer);
                            break;
                        }
                    }
                }

            }
            counter++;
        }
        if (firstPlayer.Count > secondPlayer.Count)
        {
            Console.WriteLine($"First player wins after {counter} turns");
        }
        else if (secondPlayer.Count > firstPlayer.Count)
        {
            Console.WriteLine($"Second player wins after {counter} turns");
        }
        else if (firstPlayer.Count == secondPlayer.Count)
        {
            Console.WriteLine($"Draw after {counter} turns");
        }
    }

    private static int toNum(string x)
    {
        return int.Parse(x.Substring(0, x.Length - 1));
    }

    private static void AddCardsToDeck(string[] sortEightCardDeck, Queue<string> playerDeck)
    {
        foreach (var item in sortEightCardDeck)
        {
            playerDeck.Enqueue(item);
        }
    }

    private static int GetPlayerLettersSum(string firstLetter, string secondLetter, string thirdLetter)
    {
        var sum = firstLetter[firstLetter.Length - 1] +
                            secondLetter[secondLetter.Length - 1] +
                            thirdLetter[thirdLetter.Length - 1];
        return sum;
    }
}