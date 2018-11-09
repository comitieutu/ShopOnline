using BookStore.Data;
using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IRepository<Product> _productRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<Customer> _customerRepository;
        private IRepository<PersonInfo> _personInfoRepository;
        private IRepository<ProductDetail> _productDetailRepository;
        private IRepository<ReceiveProduct> _receiveProductRepository;
        private IRepository<SaleOrder> _saleOrderRepository;
        private IRepository<SaleOrderDetail> _saleOrderDetailRepository;
        private IRepository<Shipper> _shipperRepository;

        //private UserManager<ApplicationUser> _userManager;
        //private RoleManager<IdentityRole> _roleManager;

        public UnitOfWork(AppDbContext context)
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

        public IRepository<Customer> CustomerRepository => throw new NotImplementedException();

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
