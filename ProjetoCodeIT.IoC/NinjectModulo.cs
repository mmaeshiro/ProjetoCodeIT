using Ninject.Modules;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.Interfaces.IRepositorio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            //NEGOCIO----------------------------------------------------------
            Bind(typeof(Dominio.Interfaces.INegocio.INegocioBase<>)).To(typeof(Negocio.Implementacao.NegocioBase<>));
            Bind<IFreteNegocio>().To<Negocio.Implementacao.FreteNegocio>();
            Bind<Dominio.Interfaces.INegocio.IProdutoNegocio>().To<Negocio.Implementacao.ProdutoNegocio>();
            Bind<Dominio.Interfaces.INegocio.IItemViagemNegocio>().To<Negocio.Implementacao.ItemViagemNegocio>();
           


            //DOMINIO----------------------------------------------------------
            Bind(typeof(Dominio.Interfaces.IServico.IServicoBase<>)).To(typeof(Dominio.Servico.ServicoBase<>));
            Bind<IFreteServico>().To<Dominio.Servico.FreteServico>();
            Bind<Dominio.Interfaces.IServico.IProdutoServico>().To<Dominio.Servico.ProdutoServico>();
            Bind<Dominio.Interfaces.IServico.IItemViagemServico>().To<Dominio.Servico.ItemViagemServico>();
   

            //INFRA-----------------------------------------------------------
            Bind(typeof(Dominio.Interfaces.IRepositorio.IRepositorioBase<>)).To(typeof(Infra.Implementacao.RepositorioBase<>));
            Bind<IFreteRepositorio>().To<Infra.Implementacao.FreteRepositorio>();
            Bind<Dominio.Interfaces.IRepositorio.IProdutoRepositorio>().To<Infra.Implementacao.ProdutoRepositorio>();
            Bind<Dominio.Interfaces.IRepositorio.IItemViagemRepositorio>().To<Infra.Implementacao.ItemViagemRepositorio>();
  

        }
    }
}
