using FluentValidation;
using SignalR.DtoLayer.BookingDto;

namespace SignalR.BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateBookingValidation:AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez!");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kişi Alanı Boş Geçilemez!");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih Alanı Boş Geçilemez!");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen İsim Alnına En Az 5 Karakter Veri Girişi Yapınız!")
                .MaximumLength(50).WithMessage(("Lütfen İsim Alnına En Fazla 50 Karakter Veri Girişi Yapınız!"));        
            RuleFor(x => x.Description).MaximumLength(500).WithMessage(("Lütfen Açıklama Alnına En Fazla 500 Karakter Veri Girişi Yapınız!"));
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Adresi Giriniz!");
        }
    }
}
