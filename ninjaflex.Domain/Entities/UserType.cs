using ninjaflex.Domain.Entities.EntitieBase;

namespace ninjaflex.Domain.Entities
{
    public class UserType : EntityBase
    {
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
