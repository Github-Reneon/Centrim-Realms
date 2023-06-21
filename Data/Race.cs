namespace Centrim_Realms.Data
{
    public interface IRace
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IAbility> RacialBonuses { get; set; }        
    }
}
