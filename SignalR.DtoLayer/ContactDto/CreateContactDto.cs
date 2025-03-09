namespace SignalR.DtoLayer.ContactDto
{
    public class CreateContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescripton { get; set; }
    }
}
