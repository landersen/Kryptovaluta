using System;
using System.Collections;

namespace CryptoCurrency
{
    public class Converter
    {
        Hashtable currencyList;

        public Converter()
        {
            currencyList = new Hashtable();
            currencyList.Add("BitCoin",10.0); 
            currencyList.Add("Ripple",20.0);
            currencyList.Add("DogCoin",30.0);
        }

        /// <summary>
        /// Angiver prisen for en enhed af en kryptovaluta. Prisen angives i dollars.
        /// Hvis der tidligere er angivet en værdi for samme kryptovaluta, 
        /// bliver den gamle værdi overskrevet af den nye værdi
        /// </summary>
        /// <param name="currencyName">Navnet på den kryptovaluta der angives</param>
        /// <param name="price">Prisen på en enhed af valutaen målt i dollars. Prisen kan ikke være negativ</param>
        public void SetPricePerUnit(String currencyName, double price)
        {
            if (currencyList.Contains(currencyName))
            {
                currencyList[currencyName] = price;
            } else
            {
                currencyList.Add(currencyName, price);
            }
        }

        /// <summary>
        /// Konverterer fra en kryptovaluta til en anden. 
        /// Hvis en af de angivne valutaer ikke findes, kaster funktionen en ArgumentException
        /// 
        /// </summary>
        /// <param name="fromCurrencyName">Navnet på den valuta, der konverterers fra</param>
        /// <param name="toCurrencyName">Navnet på den valuta, der konverteres til</param>
        /// <param name="amount">Beløbet angivet i valutaen angivet i fromCurrencyName</param>
        /// <returns>Værdien af beløbet i toCurrencyName</returns>
        public double Convert(String fromCurrencyName, String toCurrencyName, double amount) 
        {
            if (currencyList.ContainsKey(fromCurrencyName) && currencyList.ContainsKey(toCurrencyName)) {
                double fromValue = (double)CurrencyList[fromCurrencyName];
                double toValue = (double)CurrencyList[toCurrencyName];
                double fromValueAndAmount = fromValue * amount;
                double amountOfNewCurrency = fromValueAndAmount / toValue;

                return amountOfNewCurrency;
            } else
            {
                throw new ArgumentException("The currency does not exist");
            }
           
        }

        public Hashtable CurrencyList { get => currencyList; set => currencyList = value; }


    }
}
