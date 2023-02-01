using Entities;

namespace _API_.IServices
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCriteria();
        int InsertProduct(Product product);
        //public List<Product> DeleteProduct ();
        //void UpdateProduct(int id);
        
    }
}
