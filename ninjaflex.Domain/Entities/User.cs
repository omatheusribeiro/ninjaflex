using ninjaflex.Domain.Entities.EntitieBase;

namespace ninjaflex.Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? BarCode { get; set; }
        public int UserTypeId { get; set; }
        public bool Status { get; set; }
    }
}
