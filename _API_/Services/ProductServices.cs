using _API_.IServices;
using Entities;
using ILogic;

namespace _API_.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(Product product)
        {
            _productLogic.InsertProduct(product);
            return product.Id;
        }
        public List<Product> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }
        public List<Product> GetProductsByCriteria()
        {
            return _productLogic.GetProductsByCriteria();
        }
        //public List<Product> DeleteProduct()
      //  {
           // _productLogic.DeleteProduct(product);
           // return _productLogic.DeleteProduct; 
       // }
    }
}










    
