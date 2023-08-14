﻿namespace Catalog.Infrastructure.Write
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            this._context = context;
        }

        public Catalog.Product Find(Guid id) => _context.Product.Find(id);

        public void Register(Catalog.Product product)
        {
            var dbProduct = new Product(product);
            _context.Product.Add(dbProduct);
            _context.SaveChanges();
        }

        public void Update(Catalog.Product product)
        {
            var storedProduct = _context.Product.Find(product.Id);

            storedProduct.Update(product);

            _context.Product.Update(storedProduct);
            _context.SaveChanges();
        }
    }
}