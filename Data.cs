namespace OOPGalactica
{
    internal class Data
    {
        public Data()
        {
            ShowData(AddData());
        }

        private Star AddData()
        {
            Star Sun = new Star() { Id = 1, Name = "Sun", Pos = new() { X = 0, Y = 0 }, Temperature = 10000, Type = Star.Startype.YellowDwarf };

            Planet Mercury = new Planet() { Id = 2, Name = "Mercury", Pos = new(10, 30), Type = Planet.PlanetType.Terrestial };
            Planet Venus = new Planet() { Id = 3, Name = "Venus", Pos = new(10, 50), Type = Planet.PlanetType.Terrestial };
            Planet Earth = new Planet() { Id = 4, Name = "Earth", Pos = new(10, 100), Type = Planet.PlanetType.Terrestial };
            Planet Mars = new Planet() { Id = 5, Name = "Mars", Pos = new(10, 150), Type = Planet.PlanetType.Terrestial };
            Sun.PlanetList = new() { Mercury, Venus, Earth, Mars };

            Moon Luna = new Moon() { Id = 6, Name = "Luna", Pos = new(10, 103), Orbiting = Earth };
            Earth.MoonList = new(){ Luna };
            Moon Phobos = new Moon() { Id = 6, Name = "Phobos", Pos = new(10, 152), Orbiting = Mars };
            Moon Deimos = new Moon() { Id = 6, Name = "Deimos", Pos = new(10, 155), Orbiting = Mars };
            Mars.MoonList = new() { Phobos, Deimos };
            return Sun;
        }

        private void ShowData(Star star)
        {
            Console.WriteLine($"***STAR***\n{star.Name} {star} {star.Type}");
            Console.WriteLine("\t***PLANETS***");
            if (star.PlanetList != null)
                foreach (Planet planet in star.PlanetList)
                {
                    Console.WriteLine($"\t{planet.Name} {planet} {planet.Distance(star)} {planet.Type}");
                    if (planet.MoonList != null && planet.MoonList.Count != 0)
                    {
                        Console.WriteLine("\t\t***MOON(S)***");
                        foreach (Moon moon in planet.MoonList)
                        {
                            Console.WriteLine($"\t\t{moon.Name} {moon} {moon.Distance()}");
                        }
                    }
                }
        }
    }
}
