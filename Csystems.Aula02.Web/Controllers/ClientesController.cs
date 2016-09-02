using Csystems.Aula02.Persistencia.Dados;
using Csystems.Aula02.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Csystems.Aula02.Dominio.Entidades;

namespace Csystems.Aula02.Web.Controllers
{
   [Authorize(Roles = "Admin")]
    public class ClientesController : Controller
    {
        public ClientesController()
        {
            Dados.CarregaLista();
        }
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult Lista()
        {
            return View(Dados.Clientes);
        }


        public ActionResult Incluir()
        {
            var model = new Cliente();
            return View(model);
        }
        // POST: Teste/Create
        [HttpPost]
        public ActionResult Incluir(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                Dados.Clientes.Add(cliente);
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Editar(int id)
        {
            var model = Dados.Clientes.Where(x => x.ClienteId == id).First();
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                Dados.Editar(cliente);
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }
        }

       

        public ActionResult Detalhes(int id)
        {
            var model = Dados.Clientes.Where(x => x.ClienteId == id).First();
            return View(model);
        }

        [Authorize]
        public ActionResult Excluir(int id)
        {
            var model = Dados.Clientes.Where(x => x.ClienteId == id).First();
            return View(model);
        }

        // POST: Teste/Delete/5
        [HttpPost]
        public ActionResult Excluir(Cliente cliente)
        {
            try
            {
                // TODO: Add delete logic here
                var model = Dados.Clientes.Where(x => x.ClienteId == cliente.ClienteId).First();
                Dados.Clientes.Remove(model);
                return RedirectToAction("Lista");
            }
            catch
            {
                return View();
            }
        }
    }
}