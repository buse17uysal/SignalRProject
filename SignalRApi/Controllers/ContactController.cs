using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Createcontact(CreateContactDto createcontactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescripton = createcontactDto.FooterDescripton,
                Location = createcontactDto.Location,
                Mail = createcontactDto.Mail,
                Phone = createcontactDto.Phone,
            });
            return Ok("İndirim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Deletecontact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İndirim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Updatecontact(UpdateContactDto updatecontactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID = updatecontactDto.ContactID,
                FooterDescripton = updatecontactDto.FooterDescripton,
                Location = updatecontactDto.Location,
                Mail = updatecontactDto.Mail,
                Phone = updatecontactDto.Phone,
            });
            return Ok("İndirim Bilgisi Güncellendi");
        }
    }
}
