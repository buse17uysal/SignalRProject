using Microsoft.AspNetCore.Http;
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

        public MessageController(IMessageService messageSevice)
        {
            _messageSevice = messageSevice;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageSevice.TGetListAll();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                Mail = createMessageDto.Mail,
                MessageContent=createMessageDto.MessageContent,
                SendDate=DateTime.Now,
                NameSurname=createMessageDto.NameSurname,
                Phone=createMessageDto.Phone,
                Subject = createMessageDto.Subject,
                Status=false,
                MessageID = createMessageDto.MessageID,
               
            };

            _messageSevice.TAdd(message);
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
            Message message = new Message()
            {
                Mail = updateMessageDto.Mail,
                MessageContent = updateMessageDto.MessageContent,
                SendDate = updateMessageDto.SendDate,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                Subject = updateMessageDto.Subject,
                Status = updateMessageDto.Status,
                MessageID = updateMessageDto.MessageID,

            };
            _messageSevice.TUpdate(message);
            return Ok("Mesaj Alanı Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageSevice.TGetByID(id);
            return Ok(value);
        }
    }
}
