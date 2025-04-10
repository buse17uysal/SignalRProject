using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;
        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }
        public static int clientCount { get; set; }
        public async Task SendStatistic()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = _productService.TProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", value5);

            var value6 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value6);

            var value7 = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

            var value8 = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            var value9 = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00") + "₺");

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

            var value14 = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");



            var value16 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value16);
        }
        public async Task SendProgress()
        {

            var value = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00") + "₺");

            var value2 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            var value3 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value3);

            var value5 = _productService.TProductPriceAvg().ToString("0");
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value5);

            var value6 = _productService.TProductAvgPriceByHamburger().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByHamburger", value6);

            var value7 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveDrink", value7);

            var value8 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value8);

            var value9 = _productService.TProductPriceByPizza().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByPizza", value9); 
            
            var value10 = _productService.TProductPriceByPasta().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByPasta", value10);
             
            var value11 = _productService.TProductPriceByDessert().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByDessert", value11);
             
            var value12 = _productService.TProductPriceByFrying().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByFrying", value12);
             
            var value13 = _productService.TProductPriceByDrink().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceByDrink", value13);
             
            var value14 = _productService.TProductPriceBySalad().ToString("0");
            await Clients.All.SendAsync("ReceiveAvgPriceBySalad", value14);

        }
        public async Task GetBookingList()
        {
            var value = _bookingService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBookingList", value);
        }
        public async Task SendNotificatiion()
        {
            var value = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);

            var notificationlistbyfalse = _notificationService.TGetAllNotificationByFalse();
            await Clients.All.SendAsync("ReceiveNotificationListByFalse", notificationlistbyfalse);
        }
        public async Task GetMenuTableStatus()
        {
            var value = _menuTableService.TGetListAll();
            await Clients.All.SendAsync("ReceiveMenuTableStatus", value);
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
