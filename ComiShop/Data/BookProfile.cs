using AutoMapper;
using ComiShop.Models;
using ComiShop.ViewModels;
using System.Linq;

namespace ComiShop.Data
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>()
                .ForMember(x => x.IsDeleteAble, p => p.MapFrom(src => src.Products.Any() ? false : true));
            CreateMap<Product, ProductListViewModel>().ReverseMap();
            CreateMap<ProductCreateViewModel, Product>()
                .ForMember(dest => dest.Category, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore())
                .ForMember(dest => dest.ProductDetails, opt => opt.Ignore());
            CreateMap<ReceiveProduct, ReceiveProductViewModel>().ReverseMap();
            CreateMap<CategoryCreateViewModel, Category>().ReverseMap();
            CreateMap<SalesOrderViewModel, SaleOrder>().ReverseMap();
            CreateMap<ShipperViewModel, Shipper>().ReverseMap();
            CreateMap<SaleOrderDetailViewModel, SaleOrderDetail>().ReverseMap();
            CreateMap<UserViewModel, ApplicationUser>().ReverseMap();
            CreateMap<EditUserViewModel, ApplicationUser>().ReverseMap();
        }
    }
}
