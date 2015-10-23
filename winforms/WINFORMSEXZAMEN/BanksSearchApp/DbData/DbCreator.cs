using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class DbCreator
    {

        BanksDB db = new BanksDB();

        #region bansomats
        public Bankomat priorbkm1 = new Bankomat()
        {
            BankomatId = 1,
            BankomatName = "Приорбанк_Банкомат_1",
            BankOwnerName = "Приорбанк",
            Telephone = "222-45-15",
           // CityName = "г. Минск",
          //  StreetName = "Партизанский проспект",
          //  HomeNumber = "6",
            CityName = "asd",
              StreetName = "asd",
             HomeNumber = "asd",
            //Address = "г. Минск, Партизанский проспект, 6",
            CoordinateX = 53.885440,
            CoordinateY = 27.584083,
            OpenDate = new DateTime(2010, 10, 3),
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Самсонова Елена Петровна",
            Review = "Отличный банкомат!",
            Services = "Обмен валюты, оплата услуг связи",
            AdditionalInformation = "?"
        };

        public Bankomat priorbkm2 = new Bankomat()
        {
            BankomatId = 2,
            BankomatName = "Приорбанк_Банкомат_2",
            BankOwnerName = "Приорбанк",
            Telephone = "222-37-33",
            CityName = "г. Минск",
            StreetName = "улица Кабушкина",
            HomeNumber = "94",
          //  Address = "г. Минск, просп. Петра Машерова 29 ",
            CoordinateX = 53.855796,
            CoordinateY = 27.633793,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Каратай Евгения Сергеевна",
            Review = "Отличный банкомат!",
            Services = "Обмен валюты, оплата услуг связи",
            AdditionalInformation = "?"
        };
        


        public Bankomat priorbkm3 = new Bankomat()
        {
            BankomatId = 3,
            BankomatName = "Приорбанк_Банкомат_3",
            BankOwnerName = "Приорбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Крупской",
            HomeNumber = "6",
         //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.859855,
            CoordinateY = 27.626671,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            Services = "Обмен валюты, оплата услуг связи",
            AdditionalInformation = "?",
        };
        

       

        #endregion

        #region banks
        Bank priorbank = new Bank()
        {

            BankId = 1,
            BankName = "Приорбанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>(),
            Currencies = new List<Currency>()
        };

        Bank belarus = new Bank()
        {

            BankId = 2,
            BankName = "БеларусьБанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };

        Bank mtb = new Bank()
        {

            BankId = 3,
            BankName = "МТБанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>(),
            //Currencies = new List<Currency>()
        };
        #endregion



        #region currencies

        public Currency CurForPriorUSD = new Currency()
        {
            CurrencyId = 1,
            CurrencyName = "USD",
            CurrencyBuyV = 17380,
            CurrencySellV = 17200,
        };

        public Currency CurForPriorEUR = new Currency()
        {
            CurrencyId = 2,
            CurrencyName = "EUR",
            CurrencyBuyV = 19900,
            CurrencySellV = 19600
        };

        public Currency CurForPriorRUR = new Currency()
        {
            CurrencyId = 3,
            CurrencyName = "RUR",
            CurrencyBuyV = 278.5,
            CurrencySellV = 273.0
        };
           
       

        #endregion



        public void DbDataInsert()
        {
            List<Bankomat> priorBankomats = new List<Bankomat>() { priorbkm1, priorbkm2, priorbkm3 };
            List<Currency> priorCurrencies = new List<Currency>() {CurForPriorUSD,CurForPriorEUR,CurForPriorRUR};
            priorbank.Currencies.AddRange(priorCurrencies);
            priorbank.Bankomats.AddRange(priorBankomats);
            db.Banks.Add(priorbank);
          //  
          //  db.Banks.Add(priorbank);
           // priorbkm1.Currencies.AddRange(priorCurrencies);
            
            //CurForPriorUSD.Bankomats.AddRange(priorBankomats);
           // CurForPriorEUR.Bankomats.AddRange(priorBankomats);
          //  CurForPriorRUR.Bankomats.AddRange(priorBankomats);
           // banks.Bankomats.Add(priorbkm1);
           // banks.Bankomats.Add(priorbkm2);
           // banks.Bankomats.Add(priorbkm3);
           //// db.Banks.Add(banks);
          //  db.Currencies.Add(CurForPriorUSD);
            //db.Currencies.Add(CurForPriorEUR);
            //db.Currencies.Add(CurForPriorRUR);
            db.SaveChanges();
        }
    }
}
