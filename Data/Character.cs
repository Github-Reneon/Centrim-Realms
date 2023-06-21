namespace Centrim_Realms.Data
{
    // Class used for PCs and enemies. NPCs will just be forms I think.
    public abstract class Character
    {
        public string Name { get; set; }

        public int MaxHp { get; set; }

        private int _Hp;

        public int Hp { 
            get => _Hp;
            set {
                if (value > MaxHp)
                {
                    _Hp = MaxHp;
                }
                else
                {
                    _Hp = value;
                }
            } 
        }

        public List<IClass> Classes { get; set; }
        public int Level
        {
            get { return Classes.Count; }
        }
    }

    // PC class 
    /// <summary>
    /// Represents a player character, including a character information.
    /// </summary>
    public class Player : Character
    {
        protected int Age { get; set; }
        protected IRace Race { get; set; }
        protected string? BackStory { get; set; }
        
        // Init fresh
        /// <summary>
        /// Player constructor used for creating a new player character.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="race"></param>
        /// <param name="startingClass"></param>
        public Player(string name, int age, IRace race, IClass startingClass)
        {
            Name = name;
            Age = age;
            Race = race;
            Classes = new List<IClass>() { startingClass };
        }

        // Init reload
        /// <summary>
        /// Player constructor used for recreating a player character.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="race"></param>
        /// <param name="classes"></param>
        /// <param name="backStory"></param>
        public Player(string name, int age, IRace race, List<IClass> classes, string backStory)
        {
            Name = name;
            Age = age;
            Race = race;
            Classes = classes;
            BackStory = backStory;
        }
    }

    /// <summary>
    /// Represents something the PC can fight.
    /// </summary>
    public class Enemy : Character
    {
        public int Level { get; set; }
        public string? Description { get; set; }
        public int Xp { get; set; }
    }
}

