using Bmes.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bmes.Repositories
{
    public interface IBrandRepository
    {
        Brand FindBrandById(Guid id);
        IEnumerable<Brand> GetAllBrands();
        void SaveBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
