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
            Address = "г. Минск, ",
            CoordinateX = 53.885440,
            CoordinateY = 27.584083,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
          //  CurrencyValueB = "",
          //  CurrencyValueS = "",
            PersonalInformation = "Штоу Игорь Петрович",
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
            Address = "г. Минск, ",
            CoordinateX = 53.924053,
            CoordinateY = 27.557572,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            Currencies = new List<Currency>()
            {
                new Currency()
                {
                    CurrencyId = 1,
                    CurrencyName = "USD",
                    CurrencyBuyV = 17380,
                    CurrencySellV = 17200
                },
                new Currency()
                {
                    CurrencyId = 1,
                    CurrencyName = "EUR",
                    CurrencyBuyV = 19900,
                    CurrencySellV = 19600
                },
                new Currency()
                {
                    CurrencyId = 1,
                    CurrencyName = "RUR",
                    CurrencyBuyV = 278.5,
                    CurrencySellV = 273.0
                }
            },
         //   CurrencyValueB = "",
         //   CurrencyValueS = "",
            PersonalInformation = "Конь Игнат Стасович",
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
            Address = "г. Минск, ",
            CoordinateX = 53.856606,
            CoordinateY = 27.633450,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
         //   CurrencyValueB = "",
         //   CurrencyValueS = "",
            PersonalInformation = "Кудах Гоги Матвеевич",
            Review = "Отличный банкомат!",
            Services = "Обмен валюты, оплата услуг связи",
            AdditionalInformation = "?"
        };

       

        #endregion

        #region banks
        Bank banks = new Bank()
        {

            BankId = 111,
            BankName = "Приорбанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };
        #endregion



        #region currencies
        
       

        #endregion



        public void DbDataInsert()
        {

            banks.Bankomats.Add(priorbkm1);
            banks.Bankomats.Add(priorbkm2);
            banks.Bankomats.Add(priorbkm3);
            db.Banks.Add(banks);
            db.SaveChanges();
        }
    }
}
