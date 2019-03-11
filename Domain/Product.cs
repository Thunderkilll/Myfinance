using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        //clé etrangére convention : donne colone wa7da
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        //? : nullable 
        //les champs numerique sont obligatoire 
        public ICollection<Provider> Providers { get; set; }
    }
}
