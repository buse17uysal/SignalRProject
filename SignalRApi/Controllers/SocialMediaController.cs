using AutoMapper;
using Microsoft.AspNetCore.Http;
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
            _socialmediaService.TAdd(new SocialMedia()
            {
                Icon = createsocialmediaDto.Icon,
                Title = createsocialmediaDto.Title,
                Url = createsocialmediaDto.Url,
            });
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
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialmedia(UpdateSocialMediaDto updatesocialmediaDto)
        {
            _socialmediaService.TUpdate(new SocialMedia()
            {
                Icon = updatesocialmediaDto.Icon,
                Title = updatesocialmediaDto.Title,
                Url = updatesocialmediaDto.Url,
                SocialMediaID = updatesocialmediaDto.SocialMediaID,
            });
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}
