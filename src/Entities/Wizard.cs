namespace project.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            base.name = name;
            base.level = level;
            base.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Lançou Magia";
        }

    }
}