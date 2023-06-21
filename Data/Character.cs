namespace Centrim_Realms.Data
{
    //Abstract Class
    public abstract class Character
    {
        public string Name { get; set; }

        public int MaxHp { get; set; }

        public List<IClass> Classes { get; set; }
        public int Level
        {
            get { return Classes.Count; }
        }
    }


    public class Player : Character
    {
        int Age { get; set; }
        IRace Race { get; set; }
        public string? BackStory { get; set; }
        public Player(string name, int age, IRace race, IClass startingClass)
        {
            Name = name;
            Age = age;
            Race = race;
            Classes = new List<IClass>() { startingClass };
        }
        public Player(string name, int age, IRace race, List<IClass> classes, string backStory)
        {
            Name = name;
            Age = age;
            Race = race;
            Classes = classes;
            BackStory = backStory;
        }
    }

    public class Enemy : Character
    {
        public int Level { get; set; }
        public string? Description { get; set; }
        public int Xp { get; set; }
    }
}

