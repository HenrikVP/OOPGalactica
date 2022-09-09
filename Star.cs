namespace OOPGalactica
{   
    public class Star : SpaceObject
    {
        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet>? PlanetList { get; set; }
    }
}
