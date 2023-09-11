namespace ninjaflex.Domain.Entities.EntitieBase
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int UserCreation { get; set; }
        public int? UserAlteration { get; set; }
        public int? UserExclusion { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateAlteration { get; set; }
        public DateTime? DateExclusion { get; set; }
    }
}
