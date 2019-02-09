using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;

namespace Service
{
    public class ServicesProducts : IServicesProducts
    {
        MyfinanceContext ctx = new MyfinanceContext();
        public void AjouterProduit(Product p)
        {
            ctx.Products.Add(p);
            
        }

        public void Commit()
        {
            
            ctx.SaveChanges();
        }
 
    }
}
