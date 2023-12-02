using Product.Model;
using System.Collections.Generic;


namespace Product.Repository
{
   interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int Productid);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductID);
        void UpdateProduct(Product product);
        void Save();

    }
}
