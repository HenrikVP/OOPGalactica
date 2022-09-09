namespace OOPGalactica
{
    public abstract class SpaceObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Position? Pos { get; set; }
        public override string ToString()
        {
            if (Pos == null) return string.Empty;
            else return $"({Pos.X},{Pos.Y})";
        }
        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Position() { }
            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
