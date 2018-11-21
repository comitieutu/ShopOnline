using ComiShop.Data.Entities;
using ComiShop.Models;

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
        IRepository<Comment> CommentRepository { get; }

        void Refresh();

        void Commit();
    }
}
