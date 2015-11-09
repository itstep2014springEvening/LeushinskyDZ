using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class DbCreator
    {

        public BanksDB db = new BanksDB();





        #region banks
                Bank priorbank = new Bank()
                {
                    BankName = "Приорбанк",
                    //BankName = "Van",
                    //Date = DateTime.Now,
                    Bankomats = new List<Bankomat>(),
                   // Currencies = new List<Currency>(),
                   // Services = new List<Service>()
                   
                };



                Bank belarusbank = new Bank()
                {
                    BankName = "БеларусьБанк",
                    //BankName = "Van",
                    //Date = DateTime.Now,
                    Bankomats = new List<Bankomat>(),
                   // Currencies = new List<Currency>(),
                   // Services = new List<Service>()
                };

                Bank mtbbank = new Bank()
                {
                    BankName = "МТБанк",
                    //BankName = "Van",
                    //Date = DateTime.Now,
                    Bankomats = new List<Bankomat>(),
                   // Currencies = new List<Currency>(),
                   // Services = new List<Service>()

                };
                #endregion

        #region services

        public Service s1 = new Service()
        {
           // ServiceId = 1,
            ServiceName = "Снятие наличных"
        };

        public Service s2 = new Service()
        {
          //  ServiceId = 2,
            ServiceName = "Обмен валют"
        };

        public Service s3 = new Service()
        {
          //  ServiceId = 3,
            ServiceName = "Оплата ЖКХ"
        };

        public Service s4 = new Service()
        {
           // ServiceId = 4,
            ServiceName = "Оплата мобильной связи"
        };

        public Service s5 = new Service()
        {
           // ServiceId = 5,
            ServiceName = "Погашение кредитов"
        };



    #endregion

        #region bankomats
        public Bankomat priorbkm1 = new Bankomat()
        {
            //BankomatId = 1,
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
            AdditionalInformation = "?"
        };

        public Bankomat priorbkm2 = new Bankomat()
        {
          //  BankomatId = 2,
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
            AdditionalInformation = "?"
        };
        


        public Bankomat priorbkm3 = new Bankomat()
        {
           // BankomatId = 3,
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
            AdditionalInformation = "?",
        };



      
        public Bankomat belarusbank1 = new Bankomat()
        {
          //  BankomatId = 3,
            BankomatName = "Беларусьбанк_Банкомат_1",
            BankOwnerName = "Беларусьбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул.Веры Хоружей",
            HomeNumber = "31",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.923037,
            CoordinateY = 27.556468,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };


   
        public Bankomat belarusbank2 = new Bankomat()
        {
          //  BankomatId = 3,
            BankomatName = "Беларусьбанк_Банкомат_2",
            BankOwnerName = "Беларусьбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "Игнатенко",
            HomeNumber = "11",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.918622,
            CoordinateY = 27.524207,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };




       
        public Bankomat belarusbank3 = new Bankomat()
        {
           // BankomatId = 3,
            BankomatName = "Беларусьбанк_Банкомат_3",
            BankOwnerName = "Беларусьбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Захарова",
            HomeNumber = "50",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.902641,
            CoordinateY = 27.581849,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };

        public Bankomat belarusbank4 = new Bankomat()
        {
          //  BankomatId = 3,
            BankomatName = "Беларусьбанк_Банкомат_4",
            BankOwnerName = "Беларусьбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Московская",
            HomeNumber = "18",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.890773,
            CoordinateY = 27.537594,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };


        public Bankomat mtbbank1 = new Bankomat()
        {
         //   BankomatId = 3,
            BankomatName = "МТБбанк_Банкомат_1",
            BankOwnerName = "МТБбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Воронянского",
            HomeNumber = "7",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.903600,
            CoordinateY = 27.586474,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };


        public Bankomat mtbbank2 = new Bankomat()
        {
          //  BankomatId = 3,
            BankomatName = "МТБбанк_Банкомат_2",
            BankOwnerName = "МТБбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Кабушкина",
            HomeNumber = "94",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.858327,
            CoordinateY = 27.632591,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };


        public Bankomat mtbbank3 = new Bankomat()
        {
           // BankomatId = 3,
            BankomatName = "МТБбанк_Банкомат_3",
            BankOwnerName = "МТБбанк",
            Telephone = "222-22-12",
            CityName = "г. Минск",
            StreetName = "ул. Денисовская",
            HomeNumber = "8",
            //   Address = "г. Минск, ул. Крупской 6/1",
            CoordinateX = 53.874948,
            CoordinateY = 27.571964,
            OpenDate = DateTime.Now,
            WorkingTime = "8.00 - 20.00",
            PersonalInformation = "Старовойтов Игорь Петрович",
            Review = "Отличный банкомат!",
            AdditionalInformation = "?",
        };

        #endregion

        


        #region currencies

        public Currency CurForPriorUSD = new Currency()
        {
         //   CurrencyId = 1,
            CurrencyName = "USD",
            CurrencyBuyV = 17380,
            CurrencySellV = 17200,
        };

        public Currency CurForPriorEUR = new Currency()
        {
          //  CurrencyId = 2,
            CurrencyName = "EUR",
            CurrencyBuyV = 19900,
            CurrencySellV = 19600
        };

        public Currency CurForPriorRUR = new Currency()
        {
           // CurrencyId = 3,
            CurrencyName = "RUR",
            CurrencyBuyV = 278.5,
            CurrencySellV = 273.0
        };

        public Currency CurForblbUSD = new Currency()
        {
          //  CurrencyId = 4,
            CurrencyName = "USD",
            CurrencyBuyV = 17150,
            CurrencySellV = 17350,
        };

        public Currency CurForblbEUR = new Currency()
        {
         //   CurrencyId = 5,
            CurrencyName = "EUR",
            CurrencyBuyV = 19580,
            CurrencySellV = 19990
        };

        public Currency CurForblbRUR = new Currency()
        {
          //  CurrencyId = 6,
            CurrencyName = "RUR",
            CurrencyBuyV = 273.0,
            CurrencySellV = 283.0
        };

        public Currency CurFormtbUSD = new Currency()
        {
          //  CurrencyId = 7,
            CurrencyName = "USD",
            CurrencyBuyV = 17170,
            CurrencySellV = 17390,
        };

        public Currency CurFormtbEUR = new Currency()
        {
         //   CurrencyId = 8,
            CurrencyName = "EUR",
            CurrencyBuyV = 19600,
            CurrencySellV = 19900
        };

        public Currency CurFormtbRUR = new Currency()
        {
          //  CurrencyId = 9,
            CurrencyName = "RUR",
            CurrencyBuyV = 259.5,
            CurrencySellV = 281.0
        };
        #endregion



        public void DbDataInsert()
        {
            DataInsert dataInsert = new DataInsert();

            List <Service> serviceList = new List<Service>() {s1,s2,s3,s4,s5};
            List<Bankomat> priorbBankomats = new List<Bankomat>() { priorbkm1, priorbkm2, priorbkm3 };
            List<Bankomat> belarusbBankomats = new List<Bankomat>() { belarusbank1, belarusbank2, belarusbank3, belarusbank4 };
            List<Bankomat> mtbBankomats = new List<Bankomat>() { mtbbank1, mtbbank2, mtbbank3 };
            List<Currency> priorCurrencies = new List<Currency>() { CurForPriorUSD, CurForPriorEUR, CurForPriorRUR };
            List<Currency> belarusbCurrencies = new List<Currency>() { CurForblbUSD, CurFormtbEUR, CurFormtbRUR };
            List<Currency> mtbbCurrencies = new List<Currency>() { CurFormtbUSD, CurFormtbEUR, CurFormtbRUR };

            dataInsert.DataInsertionServices(serviceList, db);
            dataInsert.DataInsertion(priorbank, priorbBankomats, priorCurrencies, db);
            dataInsert.DataInsertion(belarusbank, belarusbBankomats, belarusbCurrencies,  db);
            dataInsert.DataInsertion(mtbbank, mtbBankomats, mtbbCurrencies, db);
            //priorbank.Currencies.AddRange(priorCurrencies);
            //priorbank.Currencies.AddRange(belarusbCurrencies);
            //priorbank.Currencies.AddRange(mtbbCurrencies);
            //priorbank.Bankomats.AddRange(priorbBankomats);
            //priorbank.Bankomats.AddRange(belarusbBankomats);
            //priorbank.Bankomats.AddRange(mtbBankomats);
            //db.Banks.Add(priorbank);
            //db.Banks.Add(belarusbank);
            //db.Banks.Add(mtbbank);
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
