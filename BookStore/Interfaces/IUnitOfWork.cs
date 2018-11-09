using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Customer> CustomerRepository { get; }
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
