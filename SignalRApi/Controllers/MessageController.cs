using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageSevice;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageSevice, IMapper mapper)
        {
            _messageSevice = messageSevice;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageSevice.TGetListAll();
            return Ok(_mapper.Map<List<ResultMessageDto>>(values));

        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            createMessageDto.Status = false;
            createMessageDto.SendDate = DateTime.Now;
            var value = _mapper.Map<Message>(createMessageDto);
            _messageSevice.TAdd(value);
            return Ok("Mesaj Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageSevice.TGetByID(id);
            _messageSevice.TDelete(value);
            return Ok("Mesaj Alanı Silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageSevice.TUpdate(value);
            return Ok("Mesaj Alanı Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageSevice.TGetByID(id);
            return Ok(_mapper.Map<GetMessageDto>(value));
        }
    }
}
