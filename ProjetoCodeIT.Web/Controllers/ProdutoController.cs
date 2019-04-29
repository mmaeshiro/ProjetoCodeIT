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
    public class ProdutoController : Controller
    {

        private readonly IProdutoNegocio _produtoNegocio;

        public ProdutoController(IProdutoNegocio produtoNegocio)
        {
            _produtoNegocio = produtoNegocio;
        }

        // GET: Produto
        public ActionResult Index()
        {

            try
            {
                var produtoViewModel = _produtoNegocio.ObterTodos();

                var produtosViewModel = AutoMapper.Mapper.Map<IEnumerable<ProdutoViewModel>>(produtoViewModel);

                return View(produtosViewModel);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Produtos", ex);
            }

        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            try
            {
                var produto = AutoMapper.Mapper.Map<Produto>(produtoViewModel);

                var retorno = _produtoNegocio.Inserir(produto);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Criar Produtos", ex);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {

            var produtoViewModel = AutoMapper.Mapper.Map<ProdutoViewModel>(_produtoNegocio.ObterId(id));

            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string nome)
        {
            try
            {

                var retorno = _produtoNegocio.AlterarProduto(id, nome);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Editar Produtos", ex);
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {

            var produtoViewModel = AutoMapper.Mapper.Map<ProdutoViewModel>(_produtoNegocio.ObterId(id));

            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _produtoNegocio.ExcluirProduto(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Delete Produtos", ex);
            }
        }
    }
}
