using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult featureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Createfeature(CreateFeatureDto createfeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Description1 = createfeatureDto.Description1,
                Description2 = createfeatureDto.Description2,
                Description3 = createfeatureDto.Description3,
                Title1 = createfeatureDto.Title1,
                Title2 = createfeatureDto.Title2,
                Title3 = createfeatureDto.Title3,
            });
            return Ok("Öne Çıkan Bilgisi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Öne Çıkan Bilgisi Silindi");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Updatefeature(UpdateFeatureDto updatefeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Description1 = updatefeatureDto.Description1,
                Description2 = updatefeatureDto.Description2,
                Description3 = updatefeatureDto.Description3,
                Title1 = updatefeatureDto.Title1,
                Title2 = updatefeatureDto.Title2,
                Title3 = updatefeatureDto.Title3,
                FeatureID = updatefeatureDto.FeatureID
            });
            return Ok("Öne Çıkan Bilgisi Güncellendi");
        }
    }
}
