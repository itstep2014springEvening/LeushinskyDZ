using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class DbManipulator
    {
        BanksDB db = new BanksDB();

        #region bansomats
        public Bankomat priorbkm1 = new Bankomat()
        {
            BankomatId = 1,
            BankomatName = "Приорбанк Банкомат 1",
            BankOwnerName = "Приорбанк",
            Telephone = "222-45-15",
            Address = "г. Минск, Партизанский проспект, 6",
            CoordinateX = 53.888475,
            CoordinateY = 27.584426,
            OpenDate = new DateTime(2010,10,3),
            WorkingTime = "8.00 - 20.00",
           // CurrencyValueB = "",
           // CurrencyValueS = "",
            PersonalInformation = "Кассир - Штоу Игорь Петрович",
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
           // CurrencyValueB = "",
          //  CurrencyValueS = "",
            PersonalInformation = "Кассир - Курлык Игнат Стасович",
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
           // CurrencyValueB = "",
          //  CurrencyValueS = "",
            PersonalInformation = "Кассир - Кудах Гоги Матвеевич",
            Review = "Отличный банкомат!",
            Services = "Обмен валюты, оплата услуг связи",
            AdditionalInformation = "?"
        };

        


        #endregion

        #region banks
        Bank prior = new Bank()
        {
            
            BankId = 111,
            BankName = "Приорбанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };

        Bank belarus = new Bank()
        {

            BankId = 222,
            BankName = "БеларусьБанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };

        Bank mtb = new Bank()
        {

            BankId = 333,
            BankName = "МТБанк",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };
        #endregion

        public void DbDataInsert()
        {
            prior.Bankomats.Add(priorbkm1);
            prior.Bankomats.Add(priorbkm2);
            prior.Bankomats.Add(priorbkm3);
            db.Banks.Add(prior);
            db.SaveChanges();
        }
    }
}
