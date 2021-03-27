using ProjMVCdois.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjMVCdois.Dao
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base("PizzaContext")
        {

        }
        public DbSet<Pizza> Pizzas { set; get; }
    }
}