using Bmes.Database;
using Bmes.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bmes.Repositories.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private BmesDbContext _context;

        public BrandRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Brand FindBrandById(Guid id)
        {
            var brand = _context.Brands.Find(id);
            return brand;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            var brands = _context.Brands;
            return brands;
        }

        public void SaveBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public void UpdateBrand(Brand brand)
        {
            _context.Brands.Update(brand);
            _context.SaveChanges();
        }

        public void DeleteBrand(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }

        public Brand FindProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brand> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
