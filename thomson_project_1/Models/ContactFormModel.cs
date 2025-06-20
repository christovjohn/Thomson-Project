namespace thomson_project_1.Models
{
    public class ContactFormModel
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }
        public required string Address2 { get; set; }
        public required string Landmark { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Zip { get; set; }
        public required string Phone { get; set; }
        public required string Message { get; set; }
        public bool Complaints { get; set; }
        public bool Enquiry { get; set; }
    }
}
