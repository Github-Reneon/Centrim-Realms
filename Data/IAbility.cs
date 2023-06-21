namespace Centrim_Realms.Data
{
    
    public interface IAbility
    {
        int LevelUnlock { get; set; }
        string AbilityDescription { get; set; }

        void ExecuteOnCharacter(Character character);
    }
}
