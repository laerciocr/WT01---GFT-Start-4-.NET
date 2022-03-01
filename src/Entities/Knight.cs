namespace project.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            base.name = name;
            base.level = level;
            base.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Atacou com espada";
        }

    }
}