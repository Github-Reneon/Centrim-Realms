namespace Centrim_Realms.Data
{
    internal interface IClass
    {
        int Level { get; set; }
        List<IAbility> Abilities { get; set; }
    }
}