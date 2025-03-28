using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto creatediscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = creatediscountDto.Amount,
                Description = creatediscountDto.Description,
                ImageUrl = creatediscountDto.ImageUrl,
                Title = creatediscountDto.Title,
                Status =false,
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updatediscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount = updatediscountDto.Amount,
                Description = updatediscountDto.Description,
                ImageUrl = updatediscountDto.ImageUrl,
                Title = updatediscountDto.Title,
                DiscountID=updatediscountDto.DiscountID,
                Status=updatediscountDto.Status,
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
        [HttpGet("ChangeStatusToTrue/{id}")]
        public IActionResult ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("Ürün İndirimi Aktif Hale Getirildi");
        }

        [HttpGet("ChangeStatusToFalse/{id}")]
        public IActionResult ChangeStatusToFalse(int id)
        {
            _discountService.TChangeStatusToFalse(id);
            return Ok("Ürün İndirimi Pasif Hale Getirildi");
        }

    }
}
