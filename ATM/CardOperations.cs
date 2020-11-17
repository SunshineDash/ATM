using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CardOperations
    {
        static public bool IsBanned(CreditCard creditCard, string path)
        {
            string[] bannedCards = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < bannedCards.Length; i++)
            {
                if (creditCard.CardNumber == bannedCards[i])
                {
                    return true;
                }
            }
            return false;
        }

        static public string GetBill(CreditCard creditCard, string path)
        {
            string[] bills = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < bills.Length; i++)
            {
                string[] buffer = new string[2];
                buffer = bills[i].Split('/');
                if (creditCard.CardNumber == buffer[0])
                {
                    return buffer[1];
                }
            }
            return "0";
        }

        static public List<CreditCard> ReadBase(string creditCardPath, string bannedCardPath, string billPath)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            string[] creditCardsAndPins = System.IO.File.ReadAllLines(creditCardPath);
            for (int i = 0; i < creditCardsAndPins.Length; i++)
            {
                string[] buffer = new string[3];
                buffer = creditCardsAndPins[i].Split('/');
                CreditCard creditCard = new CreditCard();
                creditCard.CardNumber = buffer[0];
                creditCard.PinCode = buffer[1];
                creditCard.Attempts = Int32.Parse(buffer[2]);
                creditCard.Ban = IsBanned(creditCard, bannedCardPath);
                creditCard.Bill = GetBill(creditCard, billPath);
                creditCards.Add(creditCard);
            }
            return creditCards;
        }

        static public int GetNumbers(string card_number)
        {
            int odd_sum = 0;
            int sum = 0;
            for (int i = 0; i < card_number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + ((int)Char.GetNumericValue(card_number[i]) * 2) / 10 + ((int)Char.GetNumericValue(card_number[i]) * 2) % 10;
                }
                else
                {
                    odd_sum += (int)Char.GetNumericValue(card_number[i]);
                }
            }
            sum += odd_sum;
            return sum;
        }

        static public bool Validity(int sum)
        {
            if (sum.ToString()[sum.ToString().Length - 1] == '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public CreditCard GetCard(string cardNumber, List<CreditCard> creditCards) 
        {
            CreditCard fake = new CreditCard();
            fake.CardNumber = "a";
            fake.PinCode = "a";
            fake.Ban = false;
            for (int i = 0; i < creditCards.Count; i++)
            {
                if (cardNumber == creditCards[i].CardNumber)
                {
                    return creditCards[i];
                }
            }
            return fake;
        }

        static public void SaveCreditCard(string cardNumbersPath, string billPath, string bannedCardsPath, List<CreditCard> creditCards)
        {
            List<string> creditCard = new List<string>();
            List<string> bill = new List<string>();
            List<string> bannedCards = new List<string>();
            for (int i = 0; i < creditCards.Count; i++)
            {
                creditCard.Add(creditCards[i].CardNumber + "/" + creditCards[i].PinCode + "/" + creditCards[i].Attempts);
                bill.Add(creditCards[i].CardNumber + "/" + creditCards[i].Bill);
                if (creditCards[i].Ban || creditCards[i].Attempts <= 0)
                {
                    bannedCards.Add(creditCards[i].CardNumber);
                }
            }
            System.IO.File.WriteAllLines(cardNumbersPath, creditCard);
            System.IO.File.WriteAllLines(billPath, bill);
            System.IO.File.WriteAllLines(bannedCardsPath, bannedCards);
        }
    }
}
