namespace OOPGalactica
{
    public class Planet : SpaceObject
    {
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant };
        public PlanetType Type { get; set; }
        //public int Diameter { get; set; }
        //public int RotationPeriod { get; set; }
        //public int RevolutionPeriod { get; set; }
        public List<Moon>? MoonList { get; set; }

        public double Distance(Star star)
        {
            //distance=√((x_2-x_1)²+(y_2-y_1)²)
            if (star == null || star.Pos == null || Pos == null) return -1;
            return Math.Sqrt(Math.Pow(star.Pos.X - Pos.X, 2) + Math.Pow(star.Pos.Y - Pos.Y, 2));
        }

    }
}