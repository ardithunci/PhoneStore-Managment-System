using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;

namespace PhoneStoreManagmentSystem.Services
{
    public interface IProductService
    {
        string ProductDelete(string name);
        Product MerrProductByName(string name);
        List<Product> Produktet();
        string ProductUpdate(ProductVM product);
        string Create(ProductVM product);
    }
}
