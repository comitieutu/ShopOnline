using ComiShop.Data;
using ComiShop.Interfaces;
using ComiShop.Models;
using System;

namespace ComiShop.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IRepository<Product> _productRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<ApplicationUser> _userRepository;
        private IRepository<PersonInfo> _personInfoRepository;
        private IRepository<ProductDetail> _productDetailRepository;
        private IRepository<ReceiveProduct> _receiveProductRepository;
        private IRepository<SaleOrder> _saleOrderRepository;
        private IRepository<SaleOrderDetail> _saleOrderDetailRepository;
        private IRepository<Shipper> _shipperRepository;

        //private UserManager<ApplicationUser> _userManager;
        //private RoleManager<ApplicationRole> _roleManager;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        //public UserManager<ApplicationUser> UserManager
        //{
        //    get
        //    {
        //        if (_userManager == null)
        //        {
        //            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));
        //        }
        //        return _userManager;
        //    }
        //}

        //public RoleManager<IdentityRole> RoleManager
        //{
        //    get
        //    {
        //        if (_roleManager == null)
        //        {
        //            _roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_context));
        //        }
        //        return _roleManager;
        //    }
        //}

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new Repository<Product>(_context);
                }
                return _productRepository;
            }
        }
        public IRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new Repository<Category>(_context);
                }
                return _categoryRepository;
            }
        }

        public IRepository<ApplicationUser> UserRepository => throw new NotImplementedException();

        public IRepository<PersonInfo> PersonInfoRepository => throw new NotImplementedException();

        public IRepository<ProductDetail> ProductDetailRepository => throw new NotImplementedException();

        public IRepository<ReceiveProduct> ReceiveProductRepository => throw new NotImplementedException();

        public IRepository<SaleOrder> SaleOrderRepository => throw new NotImplementedException();

        public IRepository<SaleOrderDetail> SaleOrderDetailRepository => throw new NotImplementedException();

        public IRepository<Shipper> ShipperRepository => throw new NotImplementedException();

        public void Refresh()
        {
            //_context.Rollback();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
