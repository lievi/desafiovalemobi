using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo;
using Servico;

namespace ValeMobi.Controllers
{
    public class TipoController : Controller
    {
        //Instanciando a Biblioteca e Serviços
        private TipoServico _tipoServico = new TipoServico();

        // GET: Tipo
        public ActionResult Index()
        {
            return View(_tipoServico.Listar());
        }

        // GET: Tipo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo/Create
        [HttpPost]
        public ActionResult Create(Tipo novo)
        {
            try
            {
                _tipoServico.Adicionar(novo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tipo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipo/Delete/5
        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                _tipoServico.Deletar((int)id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
