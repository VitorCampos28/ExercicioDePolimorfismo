using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacaoPolimorfia.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price , DateTime manufacturedate) : base(name , price)
        {
            manufactureDate = manufacturedate;
        }

        public override string priceTag()
        {
            return base.priceTag() + "(Manufacture date : " + manufactureDate + ")";
        }
    }
}
    