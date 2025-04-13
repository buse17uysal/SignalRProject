using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialmediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialmediaService, IMapper mapper)
        {
            _socialmediaService = socialmediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialmediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialmediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialmedia(CreateSocialMediaDto createsocialmediaDto)
        {
            var value = _mapper.Map<SocialMedia>(createsocialmediaDto);
            _socialmediaService.TAdd(value); 
            return Ok("Sosyal Medya Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocialmedia(int id)
        {
            var value = _socialmediaService.TGetByID(id);
            _socialmediaService.TDelete(value);
            return Ok("Sosyal Medya Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetSocialmedia(int id)
        {
            var value = _socialmediaService.TGetByID(id);
            return Ok(_mapper.Map<GetSocialMediaDto>(value));
        }
        [HttpPut]
        public IActionResult UpdateSocialmedia(UpdateSocialMediaDto updatesocialmediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updatesocialmediaDto);
            _socialmediaService.TUpdate(value);
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}
