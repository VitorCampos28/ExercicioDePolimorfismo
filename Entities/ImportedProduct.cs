using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioDeFixacaoPolimorfia.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price , double customsfee) : base(name , price)
        {
            customsFee = customsfee;
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return base.Name + " $ " + totalPrice().ToString("F2",CultureInfo.InvariantCulture) + " (Customs fee : $ "+ customsFee + ")";
        }
    }
}
