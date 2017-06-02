using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        var users = new Dictionary<string, HashSet<string>>();

        var input =  Console.ReadLine().Split(':');

        while (input[0].ToLower() != "joker")
        {
            var name = input[0];
            var cards = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var hashCards = new HashSet<string>(cards);

            if (!users.ContainsKey(name))
            {
                users[name] = new HashSet<string>();
            }
            foreach (var card in cards)
            {
                users[name].Add(card);
            }


            input = Console.ReadLine().Split(':');
        }

        foreach (var user in users)
        {
            var cardsPoints = CalculateCardsPoints(user.Value);
            Console.WriteLine($"{user.Key}: {cardsPoints}");
        }
    }

    public static int CalculateCardsPoints(HashSet<string> cards)
    {

        int cardsPoints = 0;
        foreach (var card in cards)
        {
            var power = 0;
            var cardValue = 0;
            switch (card[card.Length - 1])
            {
                case 'S':
                    power = 4;
                    break;
                case 'H':
                    power = 3;
                    break;
                case 'D':
                    power = 2;
                    break;
                case 'C':
                    power = 1;
                    break;
            }
            var cardNumber = card.Remove(card.Length - 1);
            switch (cardNumber)
            {
                case "1":
                    cardValue = 1;
                    break;
                case "2":
                    cardValue = 2;
                    break;
                case "3":
                    cardValue = 3;
                    break;
                case "4":
                    cardValue = 4;
                    break;
                case "5":
                    cardValue = 5;
                    break;
                case "6":
                    cardValue = 6;
                    break;
                case "7":
                    cardValue = 7;
                    break;
                case "8":
                    cardValue = 8;
                    break;
                case "9":
                    cardValue = 9;
                    break;
                case "10":
                    cardValue = 10;
                    break;
                case "J":
                    cardValue = 11;
                    break;
                case "Q":
                    cardValue = 12;
                    break;
                case "K":
                    cardValue = 13;
                    break;
                case "A":
                    cardValue = 14;
                    break;
            }
            cardsPoints += power * cardValue;
        }

        return cardsPoints;
    }
}
