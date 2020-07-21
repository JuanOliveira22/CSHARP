using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ConsoleApp26.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufractDate { get; set; }

        public UsedProduct()
        {
           
        }
    
      public UsedProduct(string name, double price,DateTime manuFractDate) : base(name,price)
        {
            ManufractDate = manuFractDate;
        }

        public override string PriceTag()
       
        {
            return Name
               + " (used) $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture)
               + " (Manufacture date: "
               + ManufractDate.ToString("dd/MM/yyyy")
               + ")";
        }
    }
}
