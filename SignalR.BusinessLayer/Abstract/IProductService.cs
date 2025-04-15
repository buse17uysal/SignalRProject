using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        public int TProductCount();
        public int TProductCountByCategoryNameHamburger();
        public int TProductCountByCategoryNameDrink();
        public decimal TProductPriceAvg();
        public string TProductNameByMaxPrice();
        public string TProductNameByMinPrice();
        public decimal TProductAvgPriceByHamburger();
        public decimal TProductPriceByPizza();
        public decimal TProductPriceByPasta();
        public decimal TProductPriceBySalad();
        public decimal TProductPriceByDessert();
        public decimal TProductPriceByDrink();
        public decimal TProductPriceByFrying();
    }
}
