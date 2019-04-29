using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Web.ViewModels;

namespace ProjetoCodeIT.Web.Mapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {          
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewModelProfile>();
                x.AddProfile<ViewModelToModelProfile>();
            });
        }
    }

    public class ModelToViewModelProfile : Profile
    {
        public ModelToViewModelProfile()
        {
            
            CreateMap<Frete, FreteViewModel>();

            CreateMap<Produto, ProdutoViewModel>();

            CreateMap<ItemViagem, ItemViagemViewModel>()
                .ForMember(pv => pv.produtoViewModel, p => p.MapFrom(x => x.produto))
                .ForMember(fv => fv.freteViewModel, f => f.MapFrom(x => x.frete));

        }
    }

    public class ViewModelToModelProfile : Profile
    {
        public ViewModelToModelProfile()
        {
            CreateMap<FreteViewModel, Frete>();

            CreateMap<ProdutoViewModel, Produto>();

            CreateMap<ItemViagemViewModel, ItemViagem>()
                .ForMember(pv => pv.produto, p => p.MapFrom(x => x.produtoViewModel))
                .ForMember(fv => fv.frete, f => f.MapFrom(x => x.freteViewModel));

        }

    }

}