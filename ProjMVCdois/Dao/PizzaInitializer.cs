using ProjMVCdois.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjMVCdois.Dao
{
    public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaContext>
    {
        protected override void Seed(PizzaContext context)
        {
            var pizzas = new List<Pizza>
            {
                new Pizza{Id = 1, Descricao = "Mel",Valor=10 },
                
            };

            pizzas.ForEach(d => context.Pizzas.Add(d));
            context.SaveChanges();
        }
    }
}