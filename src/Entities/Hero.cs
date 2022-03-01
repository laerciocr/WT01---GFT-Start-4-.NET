namespace project.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }

        public abstract string Attack();

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.heroType;
        }
    }
}