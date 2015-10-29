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

        public void DataInsertion(Bank bank, List<Bankomat> bankomats, List<Currency> currencies,List<Service> services, BanksDB db)
        {
            bank.Bankomats.AddRange(bankomats);
            bank.Currencies.AddRange(currencies);
            bank.Services.AddRange(services);
            db.Banks.AddOrUpdate();
            //db.Banks.Add(bank);
            db.SaveChanges();
        }
    }
}
