using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            return View(DepartamentoRepo.GetList()) ;
        }
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Departamento departamento)
        {
            Repository.DepartamentoRepo.Save(departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int codigo)
        {
            return View(DepartamentoRepo.Get(codigo));
        }

        [HttpPost]
        public ActionResult Edit(Models.Departamento departamento)
        {
            Repository.DepartamentoRepo.Update(departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int codigo)
        {
            DepartamentoRepo.Delete(codigo);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int codigo)
        {
            return View(DepartamentoRepo.Get(codigo));

        }


    }
}