using PhoneStoreManagmentSystem.Data;
using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;

namespace PhoneStoreManagmentSystem.Services
{
    public class ProductService: IProductService
    {
        readonly AppDbContext _dbContext;
        public ProductService(AppDbContext db)
        {
            _dbContext = db;
        }
        public string Create(ProductVM product)
        {
            _dbContext.Produktet.Add(new Product
            {
                CreatedDate = DateTime.Now,
                Kostoja = product.Kostoja,
                Parametrat = product.Parametrat,
                QRcode = product.QRcode,
                Prodhuesi = product.Prodhuesi,
                Name = product.EmriProduktit
            });
            _dbContext.SaveChanges();
            return "Produkti u shtua me sukses!";
        }

        public string ProductUpdate(ProductVM product)
        {
            var _product = _dbContext.Produktet.FirstOrDefault(c => c.Name == product.EmriProduktit);
            _product!.Kostoja = product.Kostoja;
            _dbContext.SaveChanges();
            return "Produkti u perditesua me sukses!";
        }
        public List<Product> Produktet()
        {
            return _dbContext.Produktet.ToList();
        }
        public Product MerrProductByName(string name)
        {
            var _product = _dbContext.Produktet.FirstOrDefault(c => c.Name == name);
            return _product!;
        }
        public string ProductDelete(string name)
        {
            var _product = _dbContext.Produktet.FirstOrDefault(c => c.Name == name);
            _dbContext.Produktet.Remove(_product!);
            _dbContext.SaveChanges();
            return "Produkti u fshi me sukses!";
        }
    }
}
