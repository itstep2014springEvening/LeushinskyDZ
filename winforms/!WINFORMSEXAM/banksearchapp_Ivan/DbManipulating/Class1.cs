using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulating
{
    
    public class CreateDB
    {
        BanksDB db = new BanksDB();
        
        #region bansomats
        Bankomat priorbkm1 = new Bankomat()
        {
            BankomatId = 1,
            BankomatName = "prior1",
            BankOwnerName = "",
            Telephone = 123,
            Address = "",
            CoordinateX = 123,
            CoordinateY = 123,
            OpenDate = DateTime.Now,
            WorkingTime = "",
            CurrencyValueB = "",
            CurrencyValueS = "",
            PersonalInformation = "",
            Review = "",
            Services = "",
            AdditionalInformation = ""
        };



        #endregion

        #region banks
        Bank banks = new Bank()
        {
            BankId = 110,
            BankName = "",
            //BankName = "Van",
            //Date = DateTime.Now,
            Bankomats = new List<Bankomat>()
        };
        #endregion

        public void DbInsert()
        {
            banks.Bankomats.Add(priorbkm1);
            db.Banks.Add(banks);
            db.SaveChanges();
        }
        
       
    }

    

   

}
