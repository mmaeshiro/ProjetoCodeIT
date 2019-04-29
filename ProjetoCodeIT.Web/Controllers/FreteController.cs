using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCodeIT.Web.Controllers
{
    public class FreteController : Controller
    {

        private readonly IFreteNegocio _freteNegocio;

        public FreteController(IFreteNegocio freteNegocio)
        {
            _freteNegocio = freteNegocio;
        }

        // GET: Frete
        public ActionResult Index()
        {
            var freteViewModel = AutoMapper.Mapper.Map< IEnumerable<FreteViewModel>>(_freteNegocio.ObterTodos());

            return View(freteViewModel);
        }

        // GET: Frete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Frete/Create
        [HttpPost]
        public ActionResult Create(FreteViewModel freteViewModel)
        {
            try
            {
                var frete = AutoMapper.Mapper.Map<Frete>(freteViewModel);

                var retorno = _freteNegocio.Inserir(frete);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Criar Frete", ex);
            }
        }

        // GET: Frete/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Frete/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, decimal valor)
        {
            try
            {

                var retorno = _freteNegocio.AlterarFrete(id, valor);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Editar Frete", ex);
            }
        }

        // GET: Frete/Delete/5
        public ActionResult Delete(int id)
        {

            var freteViewModel = AutoMapper.Mapper.Map<FreteViewModel>(_freteNegocio.ObterId(id));

            return View(freteViewModel);
        }

        // POST: Frete/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _freteNegocio.ExcluirFrete(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Deletar Frete", ex);
            }
        }
    }
}
