using AutoMapper;
using ComiShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.Data
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Product, ProductListViewModel>().ReverseMap();
        }
    }
}
