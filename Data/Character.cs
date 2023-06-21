namespace Centrim_Realms.Data
{
    //Abstract Class
    public abstract class Character
    {
        string Name { get; set; }
    }


    public class Player : Character
    {
        int Age { get; set; }
        IRace Race { get; set; }
        List<IClass> Levels { get; set; }
    }
    public class Enemy : Character
    {
        public int Level { get; set; }
        public string? Description { get; set; }
        public int Xp { get; set; }
    }
}

