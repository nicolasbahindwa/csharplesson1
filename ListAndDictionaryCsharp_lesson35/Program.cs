using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaryCsharp_lesson35
{
    class Program
    {
        static void Main()
        {
            Country country = new Country() { CountryName = "USA", capital = "WASHINTON",code="+1" };
            Country country1 = new Country() { CountryName = "INDIA", capital = "DELHI", code = "+2" };
            Country country2 = new Country() { CountryName = "CANADA", capital = "TORONTO", code = "+44" };
            Country country3 = new Country() { CountryName = "FRANCE", capital = "PARIS", code = "+30" };
            Country country4 = new Country() { CountryName = "JAPON", capital = "TOKYO", code = "+81" };
            #region using list
            //List<Country> CountryList = new List<Country>();
            //CountryList.Add(country);
            //CountryList.Add(country1);
            //CountryList.Add(country2);
            //CountryList.Add(country3);
            //CountryList.Add(country4);
            //string userchoice = String.Empty;
            //do
            //{
            //    Console.WriteLine("please enter country code");
            //    string code = Console.ReadLine().ToLower();
            //    Country resultCount = CountryList.Find(x => x.code == code);
            //    if (resultCount == null)
            //    {
            //        Console.WriteLine("country not found");
            //    }
            //    else
            //    {
            //        Console.WriteLine("country name is {0} country code : {1}, capital: {2}", resultCount.CountryName, resultCount.code, resultCount.capital);
            //    }
            //    do
            //    {
            //        Console.WriteLine("type YES OR NO if you want to cotinue");

            //        userchoice = Console.ReadLine().ToUpper();
            //    } while (userchoice != "NO" && userchoice != "YES");
            //}
            //while (userchoice == "YES");

            #endregion
            #region using disctionary

            Dictionary<string, Country> countryDico = new Dictionary<string, Country>();
            countryDico.Add(country.code, country);
            countryDico.Add(country1.code, country1);
            countryDico.Add(country2.code, country2);
            countryDico.Add(country3.code, country3);
            countryDico.Add(country4.code, country4);
            string userchoice = String.Empty;
            do
            {
                Console.WriteLine("please enter country code");
                string code = Console.ReadLine().ToLower();
                //    Country resultCount = CountryList.Find(x => x.code == code);
                Country resultCount = countryDico.ContainsKey(code)? countryDico[code]:null;
                if (resultCount == null)
                {
                    Console.WriteLine("country not found");
                }
                else
                {
                    Console.WriteLine("country name is {0} country code : {1}, capital: {2}", resultCount.CountryName, resultCount.code, resultCount.capital);
                }
                do
                {
                    Console.WriteLine("type YES OR NO if you want to cotinue");

                    userchoice = Console.ReadLine().ToUpper();
                } while (userchoice != "NO" && userchoice != "YES");
            }
            while (userchoice == "YES");

            #endregion
        }
    }

    public class Country
    {
        public string CountryName { get; set; }
        public string code { get; set; }
        public string capital { get; set; }

    }
}
