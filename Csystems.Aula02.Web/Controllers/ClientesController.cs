using Csystems.Aula02.Persistencia.Dados;
using Csystems.Aula02.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Csystems.Aula.Persistencia.Dados.SQLServer;
using Csystems.Aula02.Dominio.Entidades;
using Csystems.Aula02.Web.Views.ViewModels;

namespace Csystems.Aula02.Web.Controllers
{
   //[Authorize(Roles = "Admin")]
    public class ClientesController : Controller
    {
        PdvDbContexto db =new PdvDbContexto();
        public ClientesController()
        {
            Dados.CarregaLista();
        }
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult Lista(int pagina =1 ,int registros =10000)
        {
            //var model = db.Clientes.Where(c=>c.Nome.StartsWith("D")).OrderBy(c=>c.Nome).Skip((pagina-1)*registros).Take(registros);
            var model = db.Clientes.OrderBy(c => c.Nome).Skip((pagina - 1) * registros).Take(registros);

            return View(model);
        }


        public ActionResult Incluir()
        {
            var model = new ClienteviewModel();
            return View(model);
        }
        // POST: Teste/Create
        [HttpPost]
        public ActionResult Incluir(ClienteviewModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here

                    Cliente dadosCliente =new Cliente()
                    {
                        Nome = cliente.Nome,
                        Fantasia = cliente.Fantasia,
                        CPF = cliente.CPF
                    };


                    db.Clientes.Add(dadosCliente);
                    db.SaveChanges();
                }
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Editar(int? id)
        {
            //var model = Dados.Clientes.Where(x => x.ClienteId == id).First();
            //return View(model);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = db.Clientes.First(x => x.ClienteId == id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Lista");
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }

       

        public ActionResult Detalhes(int id)
        {
            var model = Dados.Clientes.Where(x => x.ClienteId == id).First();
            return View(model);
        }

        [Authorize]
        public ActionResult Excluir(int id)
        {
            var model = db.Clientes.First(x => x.ClienteId == id);
            return View(model);
        }

        // POST: Teste/Delete/5
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(int? id)
        {
            try
            {
                // TODO: Add delete logic here

                var model = db.Clientes.First(x => x.ClienteId == id);
                db.Clientes.Remove(model);
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }

        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}