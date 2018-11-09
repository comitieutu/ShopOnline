using AutoMapper;
using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
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
