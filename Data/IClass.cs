namespace Centrim_Realms.Data
{
    public interface IClass
    {
        List<IAbility> Abilities { get; set; }
        int Level {
            get { return Abilities.Count; }
        }
    }
}