using ProjMVCdois.Dao;
using ProjMVCdois.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjMVCdois.Controllers
{
    public class PizzaController : Controller
    {
        private PizzaContext db = new PizzaContext();
        public ActionResult Index()
        {
            return View(db.Pizzas.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                
                Pizza pizzaUpdate = db.Pizzas.First(d => d.Id == pizza.Id);
                pizzaUpdate.Valor = pizza.Valor;
                pizzaUpdate.Descricao = pizza.Descricao;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Details(int id)
        {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var pizza = db.Pizzas.First(d => d.Id == id);
            db.Pizzas.Remove(pizza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}