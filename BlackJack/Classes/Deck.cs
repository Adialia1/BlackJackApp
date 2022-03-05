using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class Deck
    {
        string[] deckArr;
        readonly string[] values = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k" };
        readonly string[] types = { "club", "diamond", "heart", "spade" };

        /// <summary>
        /// הפעולה יוצאת חבילת קלפים חדשה
        /// </summary>
        public void CreateDeck()
        {
            deckArr = new string[52];
            Load_Values_And_Types(deckArr, values, types);
        }

        private void Load_Values_And_Types(string[] deck, string[] values, string[] types)
        {
            int i = 0;
            foreach (string type in types)
            {
                foreach (string value in values)
                {
                    deckArr[i++] = $"{type},{value}";
                }
            }

            for (int j = 0; j < 3; j++)
            {
                Randomize(deck);
            }
        }

        private static void Randomize<T>(T[] items)
        {
            Random rand = new Random();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        /// <summary>
        /// הפעולה בוחרת קלף רנדומלי מהחבילה
        /// </summary>
        /// <returns>(string): Resource card name,Card Value</returns>
        public string RandomCard()
        {
            Random rnd = new Random();
            int valueCard = 0;
            //Random Card from arr
            int r = rnd.Next(deckArr.Length);
            while (deckArr[r] == null)
                r = rnd.Next(deckArr.Length);

            string[] cardSplit = deckArr[r].Split(',');
            //cardSplit[0] - Type
            //cardSplit[1] - Value

            switch (cardSplit[1])
            {
                case "a":
                    valueCard = 1;
                    break;
                case "j":
                    valueCard = 10;
                    break;
                case "q":
                    valueCard = 10;
                    break;
                case "k":
                    valueCard = 10;
                    break;
                default:
                    valueCard = int.Parse(cardSplit[1]);
                    break;
            }

            string cardName = cardSplit[0] + "_" + cardSplit[1];

            deckArr[r] = null;

            return cardName + "," + valueCard;

            //output: card Name, value
        }

    }
}
