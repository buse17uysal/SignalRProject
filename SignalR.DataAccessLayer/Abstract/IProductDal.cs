using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        public int ProductCountByCategoryNameHamburger();
        public int ProductCountByCategoryNameDrink();
        public decimal ProductPriceAvg();
        public string ProductNameByMaxPrice();
        public string ProductNameByMinPrice();
        public decimal ProductAvgPriceByHamburger();
        public decimal ProductPriceByPizza();
        public decimal ProductPriceByPasta();
        public decimal ProductPriceBySalad();
        public decimal ProductPriceByDessert();
        public decimal ProductPriceByDrink();
        public decimal ProductPriceByFrying();
    }
}
