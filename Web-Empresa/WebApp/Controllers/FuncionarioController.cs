using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View(FuncionarioRepo.GetList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Funcionario funcionario)
        {
            FuncionarioRepo.Save(funcionario);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int codigo)
        {
            return View(FuncionarioRepo.GetFuncionario(codigo));
        }

        [HttpPost]
        public ActionResult Edit(Models.Funcionario funcionario)
        {
            Repository.FuncionarioRepo.Update(funcionario);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int codigo)
        {
            FuncionarioRepo.Delete(codigo);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int codigo)
        {
            return View(FuncionarioRepo.GetFuncionario(codigo));

        }





    }
}