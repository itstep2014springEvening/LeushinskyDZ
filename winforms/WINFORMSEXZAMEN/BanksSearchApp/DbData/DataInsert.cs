using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class DataInsert
    {
        //public List<Bank> BanksList = new List<Bank>();
        //public List<Bankomat> BankomatsList = new List<Bankomat>(); 
        //public List<Currency> CurrenciesList = new List<Currency>();
        //public BanksDB db = new BanksDB();


        public void DataInsertion(Bank bank, List<Bankomat> bankomats, List<Currency> currencies,IEnumerable<long> serviceId, BanksDB db)
        {

        }

        public void DataInsertion(Bank bank, List<Bankomat> bankomats, List<Currency> currencies, BanksDB db)
        {
            db.Banks.Add(bank);
            db.SaveChanges();
            foreach (var bankomat in bankomats)
            {
                bankomat.BankId = bank.BankId;
            }
            foreach (var bankomat in bankomats)
            {
                db.Bankomats.Add(bankomat);
                db.SaveChanges();

                foreach (var currency in currencies)
                {
                    currency.BankomatId = bankomat.BankomatId;
                    db.Currencies.Add(currency);
                }
                db.SaveChanges();
            }

            var services = db.Services.AsNoTracking().ToList();
            foreach (var bankomat in bankomats)
            {
                foreach (var service in services)
                {
                    db.BankomatToServices.Add(new BankomatToService
                    {
                        ServiceId = service.ServiceId,
                        BankomatId = bankomat.BankomatId
                    });
                }
            }
            db.SaveChanges();
        }



        public void DataInsertionServices(List<Service> services, BanksDB db)
        {
            db.Services.AddRange(services);
            db.SaveChanges();

        }

        public void InsertBankomat(Bankomat bankomat, List<Currency> currencies, List<long> servicesIds , BanksDB db)
        {

            db.Bankomats.Add(bankomat);
            db.SaveChanges();

            foreach (var currency in currencies)
            {
                currency.BankomatId = bankomat.BankomatId;
                db.Currencies.Add(currency);
            }
            db.SaveChanges();

            foreach (var serviceId in servicesIds)
            {
                db.BankomatToServices.Add(new BankomatToService
                {
                    ServiceId = serviceId,
                    BankomatId = bankomat.BankomatId
                });
            }

            db.SaveChanges();
        }
    }
}
