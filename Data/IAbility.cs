namespace Centrim_Realms.Data
{
    
    public interface IAbility
    {
        int LevelUnlock { get; }
        string AbilityDescription { get; }
        void ExecuteOnCharacter(out Character character);
    }
}
