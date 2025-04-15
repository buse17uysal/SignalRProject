using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BasketDtos;
using SignalRWebUI.Dtos.ProductDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.v = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44321/api/Product/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithCategory>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBasket([FromBody] CreateBasketDto createBasketDto)
        {
            try
            {
                if (createBasketDto == null || createBasketDto.MenuTableID == 0)
                {
                    return BadRequest("Geçersiz veri");
                }

                using var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createBasketDto);
                var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:44321/api/Basket", stringContent);

                var client2 = _httpClientFactory.CreateClient();
                await client2.GetAsync("https://localhost:44321/api/MenuTables/ChangeMenuTableStatusToTrue?id=" + createBasketDto.MenuTableID);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return Ok(new { success = true, message = "Ürün sepete eklendi." });
                }
                else
                {
                    return BadRequest("API'ye gönderim başarısız.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
