using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ConsoleApp26.Entities
{
    class ImportedProduct : Product
    {
      
        public double Fee { get; set; }
          
        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price,double fee) : base (name,price)
        {
            Fee = fee;
        } 

        public double TotalPrice()
        {
            return  Price + Fee;
        }
       

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + Fee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }


    }
}
