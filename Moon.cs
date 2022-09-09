namespace OOPGalactica
{
    public sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
        public double Distance()
        {
            //distance=√((x_2-x_1)²+(y_2-y_1)²)
            if (Orbiting == null || Orbiting.Pos == null || Pos == null) return -1;
            else return Math.Sqrt(Math.Pow(Orbiting.Pos.X - Pos.X, 2) + Math.Pow(Orbiting.Pos.Y - Pos.Y, 2));
        }
    }
}