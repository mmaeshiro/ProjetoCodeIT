using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.ObjetoValor;
using ProjetoCodeIT.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCodeIT.Web.Controllers
{
    public class ViagemController : Controller
    {

        private readonly IItemViagemNegocio _itemViagemNegocio;
        private readonly IFreteNegocio _freteNegocio;
        private readonly IProdutoNegocio _produtoNegocio;

        public ViagemController(IItemViagemNegocio itemViagemNegocio,
            IFreteNegocio freteNegocio,
            IProdutoNegocio produtoNegocio)
        {
            _itemViagemNegocio = itemViagemNegocio;
            _freteNegocio = freteNegocio;
            _produtoNegocio = produtoNegocio;
        }


        // GET: Viagem
        public ActionResult Index()
        {

            var itemViagemViewModel = AutoMapper.Mapper.Map<IEnumerable<ItemViagemViewModel>>(_itemViagemNegocio.ObterTodos());

            return View(itemViagemViewModel);
        }

        // GET: Viagem/Create
        public ActionResult Create()
        {

            var itemViagemViewModel = new ItemViagemViewModel()
            {
                listaFreteViewModel = AutoMapper.Mapper.Map<IEnumerable<FreteViewModel>>(_freteNegocio.ObterTodos()),
                listaProdutoViewModel = AutoMapper.Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoNegocio.ObterTodos())
            };

            return View(itemViagemViewModel);
        }

        // POST: Viagem/Create
        [HttpPost]
        public ActionResult Create(ItemViagemViewModel itemViagemViewModel)
        {
            try
            {
                var itemViagem = AutoMapper.Mapper.Map<ItemViagem>(itemViagemViewModel);

                _itemViagemNegocio.InserirItemViagem(itemViagem);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Criar ItemViagem", ex);
            }
        }
   
        public ActionResult GerarViagem() 
        {
            try
            {
                var viagemResultadoObjetoValor = _itemViagemNegocio.GerarViagem();

                return View(viagemResultadoObjetoValor);

}
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Viagem", ex);
            }

        }            

    }
}
