using System;
using System.Collections.Generic;

namespace ProductRegister.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(){}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price){
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag(){
            return Name + " (Used) $" + Price.ToString("F2") + $" (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}