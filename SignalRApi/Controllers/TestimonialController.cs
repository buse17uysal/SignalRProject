using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult testimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Createtestimonial(CreateTestimonialDto createtestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createtestimonialDto.Comment,
                ImageUrl = createtestimonialDto.ImageUrl,
                Name = createtestimonialDto.Name,
                Status = createtestimonialDto.Status,
                Title = createtestimonialDto.Title,

            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updatetestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Comment = updatetestimonialDto.Comment,
                ImageUrl = updatetestimonialDto.ImageUrl,
                Name = updatetestimonialDto.Name,
                Status = updatetestimonialDto.Status,
                Title = updatetestimonialDto.Title,
                TestimonialID = updatetestimonialDto.TestimonialID,
            });
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}
