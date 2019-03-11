using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Gui
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicesProducts sp = new ServicesProducts();
            Product p = new Product()
            {
                Name = "Tomate",
                Category = new Category() { Name = "Légume" },
                DateProd = DateTime.Now,
                Price = 10.00,
                Quantity = 10
            };
            sp.AjouterProduit(p);
            sp.Commit();
            Console.WriteLine("Data Base Created");
            Console.ReadKey();


        }
    }
}
