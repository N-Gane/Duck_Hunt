namespace GameLibrary.Duck
{
    public class DecoratorProperities : DuckProperities
    {
        protected DuckProperities duckProperities;

        public DecoratorProperities(DuckProperities duckProperities)
        {
            this.duckProperities = duckProperities;
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public override float Speed { get => duckProperities.Speed; set => duckProperities.Speed = value; }

        /// <summary>
        /// Здоровье
        /// </summary>
        public override float HP { get => duckProperities.HP; set => duckProperities.HP = value; }
    }
}