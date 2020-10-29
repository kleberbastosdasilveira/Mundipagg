using AutoMapper;
using Mundipagg.Aplication.ViewModels;
using Mundipagg.Domain.Entities;

namespace Mundipagg.Aplication.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<CategoriaProduto, CategoriaProdutoViewModel>().ReverseMap();

        }

    }
}
