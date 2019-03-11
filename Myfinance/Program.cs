using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Passager p = new Passager()
            {
                Nom = "test_Name",
                Prenom = "test_Prenom"
                

            };

            Vol v = new Vol()
            {
               // DateDep = DateTime.Now : date mta3 tawa 
               DateDep = new DateTime(2018,02,25),
               Duree = 120  ,
               Destination = "Paris"

            };

            Avion a = new Avion()
            {
    Type_avion = Type_avion.airbus
    

            };
            v.Avion = a ;
            v.Passagers = new List<Passager>();
            v.Passagers.Add(p);

            List<Vol> vols = new List<Vol>()
            {
                v  ,
                new Vol ()
                {
                        DateDep = new DateTime(2019,01,24),
                        Duree = 110  ,
                        Destination = "Paris"
                }  ,
                     new Vol ()
                {
                        DateDep = new DateTime(2019,01,22),
                        Duree = 70 ,
                        Destination = "Tunis"
                }


            };
 
            //afficher liste des vols ver paris annee 2019
            IEnumerable<Vol> req1 = from i in vols
                       where i.DateDep.Year == 2019 
                       && i.Destination == "Paris"
                       select i;
    foreach (Vol i in req1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            //list - de 10 jours  timeSpam

            IEnumerable<String> req2 = from i1 in vols
                                    where (DateTime.Now - i1.DateDep).TotalDays < 10
                                    orderby i1.Duree descending
                                    select i1.Destination;


            foreach (String j in req2)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
            
            // afficher les 2 vols les plus longs
            IEnumerable<Vol> orderedVols = vols
                .OrderBy(vi1 => vi1.Duree)
                .Take(2);
                                 
            foreach ( Vol v2 in orderedVols)
            {

                Console.WriteLine(v2);

            }

            Console.ReadKey();




            /*
             * LinQ
             var req = from p in Personne 
                         where p.age<10
                         select p.nom ;//(or make a new object if select akthir min 1 prop )

                   */
            /*
             Limbda expression 
             var req = Personnes.where(p=> p.age <10).select(p=>p.Nom)

                         */

        }
    }
}
