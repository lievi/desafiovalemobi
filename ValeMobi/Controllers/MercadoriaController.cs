using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo;
using Servico;

namespace ValeMobi.Controllers
{
    public class MercadoriaController : Controller
    {
        //Instanciando biblioteca de serviço
        public MercadoriaServico _mercadoriaServico = new MercadoriaServico();
        public TipoServico _tipoServico = new TipoServico();
        // GET: Mercadoria
        public ActionResult Index()
        {
            return View(_mercadoriaServico.Listar());
        }


        // GET: Mercadoria/Create
        public ActionResult Create()
        {
            PopularViewBag();
            return View();
        }

        // POST: Mercadoria/Create
        [HttpPost]
        public ActionResult Create(Mercadoria novo)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _mercadoriaServico.Adicionar(novo);
                    return RedirectToAction("Index");
                }
                else
                {
                    PopularViewBag();
                    return View(novo);
                }
            }
            catch
            {
                PopularViewBag();
                return View(novo);
            }
        }

        private void PopularViewBag()
        {
            ViewBag.TipoId = new SelectList(_tipoServico.Listar(), "TipoId", "NomeTipo");
            ViewBag.TipoNegocio = new SelectList(new string[] { "Compra", "Venda"});
        }
    }
}
