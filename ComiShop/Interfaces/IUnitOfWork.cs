using ComiShop.Interfaces;
using ComiShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiShop.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<ApplicationUser> UserRepository { get; }
        IRepository<PersonInfo> PersonInfoRepository { get; }
        IRepository<ProductDetail> ProductDetailRepository { get; }
        IRepository<ReceiveProduct> ReceiveProductRepository { get; }
        IRepository<SaleOrder> SaleOrderRepository { get; }
        IRepository<SaleOrderDetail> SaleOrderDetailRepository { get; }
        IRepository<Shipper> ShipperRepository { get; }

        void Refresh();

        void Commit();
    }
}
