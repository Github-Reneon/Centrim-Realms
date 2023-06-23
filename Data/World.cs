namespace Centrim_Realms.Data
{
    public class World
    {
        private string? _image;
        public string? Image
        {
            get
            {
                if (_image == null)
                {
                    return "images/default.png";
                } 
                else return _image;
            }
            set => _image = value; 
        }

        private string? _name;
        public string? Name
        {
            get
            {
                if (_name == null)
                {
                    return "No name applied.";
                } 
                else return (_name);
            }
            set => _name = value; 
        }

        private string? _description;

        public string? Description
        {
            get
            {
                if (_description == null)
                {
                    return "No description applied";
                }
                else return _description;
            }
            set => _description = value;
        }

        public World() {
            Image = null;
            Name = null;
            Description = null;
        }

        public World(string? image, string? name, string? description)
        {
            Image = image;
            Name = name;
            Description = description;
        }



    }
}
