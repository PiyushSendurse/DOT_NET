namespace BusinessLogicLayer;
using BusinessObjectLayer; //Contains "Product" Class
using DataAccessLayer; //Conatins "DBManager" class having All objects
public class CatalogManager
{
    public List<Product> GetAllProduct() {
        List<Product> allProducts = new List<Product>();
        allProducts=DBManager.GetAllProducts();

        return allProducts;
    }

    public Product GetEachProduct(int id) {
        List<Product> allProducts = DBManager.GetAllProducts();
        Product eachProduct=allProducts.Find((p)=>p.Id==id); //Lambda Function

        return eachProduct;
    }
}
