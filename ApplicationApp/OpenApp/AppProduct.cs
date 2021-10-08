using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        public AppProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task Add(Product entity)
        {
            await _IProduct.Add(entity);
        }

        public async Task Delete(Product entity)
        {
            await _IProduct.Delete(entity);
        }

        public async Task<Product> GetEntityById(int id)
        {
           return await _IProduct.GetById(id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Product entity)
        {
            await _IProduct.Update(entity);
        }
    }
}
