using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class ProductsManager
    {
        Product newProduct;
        SqlDatabase sqlDatabase;
        public ProductsManager()
        {
            sqlDatabase = new SqlDatabase();
        }

        public void AddProduct(string Name, int Amount,string description,bool status, int apartmentNumber)
        {
            newProduct = new Product(sqlDatabase.GetTheHighestIdForProduct()+1, Name, Amount,status,apartmentNumber);
            newProduct.Description = description;
            sqlDatabase.InsertProductToSQLGroceryList(newProduct);
        }

        public List<Product> GetAllProducts(User user)
        {
            return sqlDatabase.GroceryListFromSQL(user);
        }

        public void DeleteProduct(Product product) 
        {
            sqlDatabase.DeleteProduct(product);
        }
        public void ChangeStatus(Product product)
        {
            product.ChangeProductStatus();
            sqlDatabase.ChangeStatusProductSql(product);
        }
    }
}
